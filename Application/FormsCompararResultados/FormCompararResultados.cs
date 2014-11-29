using DataBaseSQL;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppPrincipal.FormsCompararResultados
{
    public partial class FormCompararResultados : Form
    {
        private string _vsmClassificationFile;
        private string _predictionsFile;
        private string nombreArchivoClassify = "svm-classify.dat";
        private string nombreArchivoPrediccion = "predicciones";
        List<matrizPipe> matrices;

        public FormCompararResultados(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        public void Init()
        {
            _vsmClassificationFile = (string)(((App)MdiParent).PipeConfiguration).representation.directoryFilePath + "\\" + nombreArchivoClassify;
            _predictionsFile = (string)(((App)MdiParent).PipeConfiguration).svm.predictionsFilename + "\\" + nombreArchivoPrediccion;

            try
            {
                if (File.Exists(_vsmClassificationFile) && File.Exists(_predictionsFile))
                {
                    matrices = new List<matrizPipe>();

                    string[] linesActualCategories = File.ReadAllLines(_vsmClassificationFile);
                    string[] linesPredictedCategories = File.ReadAllLines(_predictionsFile);

                    int[] actualCategories = linesActualCategories.Select(x => int.Parse(x.Split(' ').ElementAt(0))).ToArray();
                    int[] predictedCategories = linesPredictedCategories.Select(x => int.Parse(x.Split(' ').ElementAt(0))).ToArray();
                    var missingCategories = predictedCategories.Where(x => !actualCategories.Contains(x)).ToList();
                    List<int> categoryLabels = actualCategories.Union(missingCategories).ToList();

                    int[][] confusionMatrix = ((App)MdiParent).BuildConfusionMatrix(actualCategories, predictedCategories, categoryLabels);

                    matrices.Add(new matrizPipe("Actual", confusionMatrix));

                    float exactitud = (float)(Math.Round((double)((App)MdiParent).CalcularTasaDeExactitud(confusionMatrix), 3));
                    float error = (float)(Math.Round((double)((App)MdiParent).CalcularTasaDeError(confusionMatrix), 3));

                    chartComparaciones.Series["Exactitud de Pipe"].Points.AddXY(1, exactitud * 100);
                    if (exactitud > 0)
                        chartComparaciones.Series["Exactitud de Pipe"].Points[0].Label = (exactitud * 100).ToString() + "%";
                    chartComparaciones.Series["Exactitud de Pipe"].Points[0].AxisLabel = "Actual";
                    chartComparaciones.Series["Error de Pipe"].Points.AddXY(1, error * 100);
                    if (error > 0)
                        chartComparaciones.Series["Error de Pipe"].Points[0].Label = (error * 100).ToString() + "%";

                    float precision = (float)(Math.Round((double)((App)MdiParent).CalcularPresicion(confusionMatrix, 0), 3));

                    chartComparaciones.Series["Exactitud de Categoria"].Points.AddXY(1, precision * 100);
                    if (precision > 0)
                        chartComparaciones.Series["Exactitud de Categoria"].Points[0].Label = (precision * 100).ToString() + "%";
                    chartComparaciones.Series["Exactitud de Categoria"].Points[0].AxisLabel = "Actual";
                    chartComparaciones.Series["Error de Categoria"].Points.AddXY(1, (1 - precision) * 100);
                    if (precision < 1)
                        chartComparaciones.Series["Error de Categoria"].Points[0].Label = ((1 - precision) * 100).ToString() + "%";

                    DataBase.connectionString = (string)(((App)MdiParent).PipeConfiguration).database.connectionString;
                    List<string> labels = DataBase.Instance.GetCategoryLabels(categoryLabels);
                    comboBoxSeleccionarCategoria.DataSource = labels;

                    ((App)MdiParent).ActivarBotonComparar();
                }
            }
            catch
            {
                DialogResult result = MessageBox.Show("Se produjo un error al cargar los resultados", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void buttonBuscarPipe_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarArchivo = new OpenFileDialog();
            buscarArchivo.ShowDialog();
            string directorio = buscarArchivo.FileName;
            textBoxArchivoSeleccionado.Text = directorio;

            if (directorio.EndsWith(".pip"))
            {
                agregarPipe();
            }
            else
            {
                if (!directorio.Equals(""))
                {
                    DialogResult result = MessageBox.Show("El archivo no tiene un formato valido .pip", "Archivo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool NoExistePipe(string nombrePipe)
        {
            foreach (DataPoint point in chartComparaciones.Series["Exactitud de Pipe"].Points)
            {
                if (point.AxisLabel.Equals(nombrePipe))
                    return false;
            }
            return true;
        }

        private bool metricasCompletas(dynamic pipeComparativo, ref string _vsmClassificationFileCompare, ref string _predictionsFileCompare)
        {
            try
            {
                _vsmClassificationFileCompare = (string)(((App)MdiParent).PipeConfiguration).representation.directoryFilePath + "\\" + nombreArchivoClassify;
                _predictionsFileCompare = (string)(((App)MdiParent).PipeConfiguration).svm.predictionsFilename + "\\" + nombreArchivoPrediccion;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void agregarPipe()
        {
            string[] pipeSeleccionado = textBoxArchivoSeleccionado.Text.Split('\\');
            string nombrePipe = pipeSeleccionado[pipeSeleccionado.Length - 1].Replace(".pip", "");
            string _vsmClassificationFileCompare = String.Empty;
            string _predictionsFileCompare = String.Empty;

            if (NoExistePipe(nombrePipe))
            {
                dynamic pipeComparativo = JObject.Parse(File.ReadAllText(textBoxArchivoSeleccionado.Text));
                if (metricasCompletas(pipeComparativo, ref _vsmClassificationFileCompare, ref _predictionsFileCompare))
                {
                    string[] linesActualCategories = File.ReadAllLines(_vsmClassificationFileCompare);
                    string[] linesPredictedCategories = File.ReadAllLines(_predictionsFileCompare);

                    int[] actualCategories = linesActualCategories.Select(x => int.Parse(x.Split(' ').ElementAt(0))).ToArray();
                    int[] predictedCategories = linesPredictedCategories.Select(x => int.Parse(x.Split(' ').ElementAt(0))).ToArray();
                    var missingCategories = predictedCategories.Where(x => !actualCategories.Contains(x)).ToList();
                    List<int> categoryLabels = actualCategories.Union(missingCategories).ToList();

                    int[][] confusionMatrixComparative = ((App)MdiParent).BuildConfusionMatrix(actualCategories, predictedCategories, categoryLabels);

                    matrices.Add(new matrizPipe(nombrePipe, confusionMatrixComparative));

                    float exactitudComparativa = (float)(Math.Round((double)((App)MdiParent).CalcularTasaDeExactitud(confusionMatrixComparative), 3));
                    float errorComparativa = (float)(Math.Round((double)((App)MdiParent).CalcularTasaDeError(confusionMatrixComparative), 3));

                    int cantBarras = listBoxPipes.Items.Count + 1;

                    chartComparaciones.Series["Exactitud de Pipe"].Points.AddXY(cantBarras + 1, exactitudComparativa * 100);
                    if (exactitudComparativa > 0)
                        chartComparaciones.Series["Exactitud de Pipe"].Points.Last().Label = (exactitudComparativa * 100).ToString() + "%";
                    chartComparaciones.Series["Exactitud de Pipe"].Points.Last().AxisLabel = nombrePipe;
                    chartComparaciones.Series["Error de Pipe"].Points.AddXY(cantBarras + 1, errorComparativa * 100);
                    if (errorComparativa > 0)
                        chartComparaciones.Series["Error de Pipe"].Points.Last().Label = (errorComparativa * 100).ToString() + "%";

                    float presicionComparativa = (float)(Math.Round((double)((App)MdiParent).CalcularPresicion(confusionMatrixComparative, comboBoxSeleccionarCategoria.SelectedIndex), 3));

                    chartComparaciones.Series["Exactitud de Categoria"].Points.AddXY(cantBarras + 1, presicionComparativa * 100);
                    if (presicionComparativa > 0)
                        chartComparaciones.Series["Exactitud de Categoria"].Points.Last().Label = (presicionComparativa * 100).ToString() + "%";
                    chartComparaciones.Series["Exactitud de Categoria"].Points.Last().AxisLabel = nombrePipe;
                    chartComparaciones.Series["Error de Categoria"].Points.AddXY(cantBarras + 1, (1 - presicionComparativa) * 100);
                    if (presicionComparativa < 1)
                        chartComparaciones.Series["Error de Categoria"].Points.Last().Label = ((1 - presicionComparativa) * 100).ToString() + "%";

                    listBoxPipes.Items.Add(nombrePipe);
                }
                else
                {
                    DialogResult result = MessageBox.Show("El Pipe seleccionado no tiene el proceso completo para obtener las metricas", "Pipe Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Un Pipe con el mismo nombre ya ha sido seleccionado", "Pipe Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEliminarPipe_Click(object sender, EventArgs e)
        {
            if (listBoxPipes.SelectedIndex != -1)
            {
                chartComparaciones.Series["Exactitud de Pipe"].Points.RemoveAt(listBoxPipes.SelectedIndex + 1);
                chartComparaciones.Series["Error de Pipe"].Points.RemoveAt(listBoxPipes.SelectedIndex + 1);
                chartComparaciones.Series["Exactitud de Categoria"].Points.RemoveAt(listBoxPipes.SelectedIndex + 1);
                chartComparaciones.Series["Error de Categoria"].Points.RemoveAt(listBoxPipes.SelectedIndex + 1);

                for (int i = listBoxPipes.SelectedIndex + 1; i < listBoxPipes.Items.Count; i++)
                {
                    chartComparaciones.Series["Exactitud de Pipe"].Points[i].XValue--;
                    chartComparaciones.Series["Error de Pipe"].Points[i].XValue--;
                    chartComparaciones.Series["Exactitud de Categoria"].Points[i].XValue--;
                    chartComparaciones.Series["Error de Categoria"].Points[i].XValue--;
                }

                matrices.RemoveAt(listBoxPipes.SelectedIndex + 1);
                listBoxPipes.Items.RemoveAt(listBoxPipes.SelectedIndex);
            }
        }

        private void checkBoxPipe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPipe.Checked)
                chartComparaciones.ChartAreas["Pipe"].Visible = true;
            else
                chartComparaciones.ChartAreas["Pipe"].Visible = false;
        }

        private void checkBoxCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCategoria.Checked)
                chartComparaciones.ChartAreas["Categoria"].Visible = true;
            else
                chartComparaciones.ChartAreas["Categoria"].Visible = false;
        }

        private void comboBoxSeleccionarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            float presicionComparativa;
            chartComparaciones.Series["Exactitud de Categoria"].Points.Clear();
            chartComparaciones.Series["Error de Categoria"].Points.Clear();
            int indice = 0;

            foreach (matrizPipe m in matrices)
            {
                presicionComparativa = (float)(Math.Round((double)((App)MdiParent).CalcularPresicion(m.matrizDeConfusion, comboBoxSeleccionarCategoria.SelectedIndex), 3));
                chartComparaciones.Series["Exactitud de Categoria"].Points.AddXY(indice + 1, presicionComparativa * 100);
                if (presicionComparativa > 0)
                    chartComparaciones.Series["Exactitud de Categoria"].Points.Last().Label = (presicionComparativa * 100).ToString() + "%";
                chartComparaciones.Series["Exactitud de Categoria"].Points.Last().AxisLabel = m.nombrePipe;
                chartComparaciones.Series["Error de Categoria"].Points.AddXY(indice + 1, (1 - presicionComparativa) * 100);
                if (presicionComparativa < 1)
                    chartComparaciones.Series["Error de Categoria"].Points.Last().Label = ((1 - presicionComparativa) * 100).ToString() + "%";
                indice++;
            }
        }

    }

    public class matrizPipe
    {
        public string nombrePipe;
        public int[][] matrizDeConfusion;

        public matrizPipe(string nombrePipe, int[][] matrizDeConfusion)
        {
            this.nombrePipe = nombrePipe;
            this.matrizDeConfusion = matrizDeConfusion;
        }

    }
}
