using DataBaseSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AppPrincipal.FormsCompararResultados
{
    public partial class FormMatrizDeConfusion : Form
    {
        private string _vsmClassificationFile;
        private string _predictionsFile;
        private int[][] confusionMatrix;

        public FormMatrizDeConfusion(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            Init();
        }

        public void Init()
        {
            _vsmClassificationFile = (string)(((App)MdiParent).PipeConfiguration).representation.directoryFilePath + "\\svm-classify.dat";
            _predictionsFile = (string)(((App)MdiParent).PipeConfiguration).svm.predictionsFilename;
        }

        private void buttonObtenerMatriz_Click(object sender, EventArgs e)
        {
            string[] linesActualCategories = File.ReadAllLines(_vsmClassificationFile);
            string[] linesPredictedCategories = File.ReadAllLines(_predictionsFile);

            int[] actualCategories = linesActualCategories.Select(x => int.Parse(x.Split(' ').ElementAt(0))).ToArray();
            int[] predictedCategories = linesPredictedCategories.Select(x => int.Parse(x.Split(' ').ElementAt(0))).ToArray();
            var missingCategories = predictedCategories.Where(x => !actualCategories.Contains(x)).ToList();
            List<int> categoryLabels = actualCategories.Union(missingCategories).ToList();

            confusionMatrix = ((App)MdiParent).BuildConfusionMatrix(actualCategories, predictedCategories, categoryLabels);

            dataGridViewMatrizConfusion.ColumnCount = confusionMatrix.Length;
            dataGridViewMatrizConfusion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrizConfusion.RowCount = confusionMatrix.Length;
            dataGridViewMatrizConfusion.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            string[] fila = new string[confusionMatrix.Length];

            List<string> labels = DataBase.Instance.GetCategoryLabels(categoryLabels);

            for (int i = 0; i < confusionMatrix.Length; i++)
            {
                dataGridViewMatrizConfusion.Columns[i].Name = labels.ElementAt(i);
                dataGridViewMatrizConfusion.Rows[i].HeaderCell.Value = labels.ElementAt(i);

                for (int j = 0; j < confusionMatrix.Length; j++)
                    fila[j] = confusionMatrix[i][j].ToString();

                dataGridViewMatrizConfusion.Rows[i].SetValues(fila);
            }
             
            DrawConfusionMatrix(confusionMatrix);
            foreach (string categoria in labels)
            {
                comboBoxCategorias.Items.Add(categoria);
            }

            buttonCalcularMetricas.Enabled = true;
            labelObtenerMatriz.Show();
        }

        private int _bitmapLength;

        private void DrawConfusionMatrix(int[][] confusionMatrix)
        {
            int length = confusionMatrix.Length;
            _bitmapLength = length * 10;

            Bitmap bitmap = new Bitmap(_bitmapLength, _bitmapLength);
            int n = _bitmapLength / length;
            for (int i = 0; i < length; i++)
            {
                int maxValue = confusionMatrix[i].Sum();
                int minValue = confusionMatrix[i].Min();
                for (int j = 0; j < length; j++)
                {
                    DrawConfusionMatrixSquare(bitmap, i, j, confusionMatrix[i][j], n, minValue, maxValue);
                }
            }

            dataGridViewMatrizConfusion.AutoResizeColumns();
            dataGridViewMatrizConfusion.Rows[0].Selected = false;
        }

        private void DrawConfusionMatrixSquare(Bitmap bitmap, int i, int j, int weight, int n, int minValue, int maxValue)
        {
            int minY = i * n;
            int minX = j * n;
            Color squareColor = GetColor(weight, minValue, maxValue);
            dataGridViewMatrizConfusion[j, i].Style.BackColor = squareColor;
            Color fontColor = Color.FromArgb(255 - squareColor.R, 255 - squareColor.G, 255 - squareColor.B);
            using(Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillRectangle(new SolidBrush(squareColor), new Rectangle(minX, minY, 10, 10));
            }
        }

        private static Bitmap SCALE = AppPrincipal.Properties.Resources.scale;

        private Color GetColor(int weight, int minValue, int maxValue)
        {
            int indiceNorm = weight - minValue;
            int maxNorm = maxValue - minValue;

            int i = maxNorm != 0 ? indiceNorm * 100 / maxNorm : 0;
            if (i < 0)
                i = 1;
            if (i > SCALE.Width - 1)
                i = SCALE.Width - 1;
            return SCALE.GetPixel(i, 10);
        }

        private void buttonCalcularMetricas_Click(object sender, EventArgs e)
        {
            labelExactitud.Text = ((App)MdiParent).CalcularTasaDeExactitud(confusionMatrix).ToString("0.000");
            labelError.Text = ((App)MdiParent).CalcularTasaDeError(confusionMatrix).ToString("0.000");
            comboBoxCategorias.Enabled = true;
            labelMetricasCalculadas.Show();
        }

        public void exportarAExcel(DataGridView tabla)
        {
            Excel.Application excel = new Excel.Application();
            Excel._Workbook libro = null;
            Excel._Worksheet hoja = null;

            try
            {
                libro = (Excel._Workbook)excel.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                hoja = (Excel._Worksheet)libro.Worksheets.Add();
                hoja.Name = "MATRIZ DE CONFUSION";

                int IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    hoja.Cells[1, IndiceColumna] = col.Name;
                    hoja.Cells[1, IndiceColumna].ColumnWidth = col.Name.Length + 4;
                    hoja.Cells[1, IndiceColumna].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }

                int IndeceFila = 0;

                foreach (DataGridViewRow row in tabla.Rows)
                {
                    IndeceFila++;
                    IndiceColumna = 0;

                    foreach (DataGridViewColumn col in tabla.Columns)
                    {
                        IndiceColumna++;
                        hoja.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                        hoja.Cells[IndeceFila + 1, IndiceColumna].Interior.Color = row.Cells[col.Name].Style.BackColor;
                        hoja.Cells[IndeceFila + 1, IndiceColumna].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        hoja.Cells[IndeceFila + 1, IndiceColumna].Font.ColorIndex = 2;
                        hoja.Cells[IndeceFila + 1, IndiceColumna].Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                        if (IndeceFila == IndiceColumna)
                        {
                            hoja.Cells[IndeceFila + 1, IndiceColumna].BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexNone, Excel.XlColorIndex.xlColorIndexNone);
                            hoja.Cells[IndeceFila + 1, IndiceColumna].Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                        }
                    }
                }

                libro.Saved = true;
                libro.SaveAs(@"C:\Users\Mati\Desktop\Matriz_De_Confusion.xlsx");

                libro.Close();
                releaseObject(libro);

                excel.UserControl = false;
                excel.Quit();
                releaseObject(excel);
            }
            catch
            {
                libro.Close();
                releaseObject(libro);

                excel.UserControl = false;
                excel.Quit();
                releaseObject(excel);
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Error mientras liberaba objecto " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void buttonExportarAExcel_Click(object sender, EventArgs e)
        {
            exportarAExcel(dataGridViewMatrizConfusion);
            labelMatrizExportada.Show();
        }

        private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPresicion.Text = ((App)MdiParent).CalcularPresicion(confusionMatrix, comboBoxCategorias.SelectedIndex).ToString("0.000");
        }
    }
}
