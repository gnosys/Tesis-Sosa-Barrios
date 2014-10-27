using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal.FormsCompararResultados
{
    public partial class FormMatrizDeConfusion : Form
    {
        private string _vsmActualPredictionsFile;
        private string _predictionsFile;

        public FormMatrizDeConfusion(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            Init();
        }


        public void Init()
        {
            _vsmActualPredictionsFile = (string)(((App)MdiParent).PipeConfiguration).representation.directoryFilePath + "/svm-classify.dat";
            _predictionsFile = (string)(((App)MdiParent).PipeConfiguration).svm.predictionsFilename;
        }

        private int[][] BuildConfusionMatrix(int[] actualCategories, int[] predictedCategories, List<int> categoryLabels, out int minValue, out int maxValue)
        {
            int length = categoryLabels.Count;
            int[][] confusionMatrix = new int[length][];
            minValue = int.MaxValue;
            maxValue = 0;

            for (int i = 0; i < length; i++)
            {
                confusionMatrix[i] = new int[length];
            }
            for (int i = 0; i < actualCategories.Length; i++)
            {
                int actualCategory = categoryLabels.IndexOf(actualCategories[i]);
                int predictedCategory = categoryLabels.IndexOf(predictedCategories[i]);
                confusionMatrix[actualCategory][predictedCategory]++;

            }
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (confusionMatrix[i][j] > maxValue)
                    {
                        maxValue = confusionMatrix[i][j];
                    }
                    if (confusionMatrix[i][j] < minValue)
                    {
                        minValue = confusionMatrix[i][j];
                    }
                }
            }
            return confusionMatrix;
        }

        private void buttonObtenerMatriz_Click(object sender, EventArgs e)
        {

            string[] linesActualCategories = File.ReadAllLines(_vsmActualPredictionsFile); //TODO: (100 - trainingPercentage) % restantes
            string[] linesPredictedCategories = File.ReadAllLines(_predictionsFile);

            int[] actualCategories = linesActualCategories.Select(x => int.Parse(x.Split(' ').ElementAt(0))).ToArray();
            int[] predictedCategories = linesPredictedCategories.Select(x => int.Parse(x.Split(' ').ElementAt(0))).ToArray();
            List<int> categoryLabels = actualCategories.Distinct().ToList();

            int minValue = 0;
            int maxValue = 0;

            int[][] confusionMatrix = BuildConfusionMatrix(actualCategories, predictedCategories, categoryLabels, out minValue, out maxValue);

            DrawConfusionMatrix(confusionMatrix, minValue, maxValue);
        }

        private string GetConfusionMatrixText(int[][] confusionMatrix)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < confusionMatrix.Length; i++)
            {
                for (int j = 0; j < confusionMatrix.Length; j++)
                {
                    builder.Append(String.Format("{0} ".PadLeft(3, '0'), confusionMatrix[i][j]));
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }

        public int sumarColumna(int[][] confusionMatrix, int fila)
        {
            int r = 0;
            for (int i = 0; i < confusionMatrix.Length; i++)
                r += confusionMatrix[fila][i];
            return r;
        }

        private void DrawConfusionMatrix(int[][] confusionMatrix, int minValue, int maxValue)
        {
            int length = confusionMatrix.Length;
            Bitmap bitmap = new Bitmap(480, 480);
            int n = 480 / length;
            for (int i = 0; i < length; i++)
            {
                maxValue = sumarColumna(confusionMatrix, i);
                for (int j = 0; j < length; j++)
                {
                    DrawConfusionMatrixSquare(bitmap, i, j, confusionMatrix[i][j], n, minValue, maxValue);
                }
            }
            bitmap.Save(@"C:\Users\Mati\Desktop\mc.png", ImageFormat.Png);
            panelMatriz.BackgroundImage = bitmap;
            labelObtenerMatriz.Show();
        }

        private void DrawConfusionMatrixSquare(Bitmap bitmap, int i, int j, int weight, int n, int minValue, int maxValue)
        {
            int minY = i * n;
            int minX = j * n;
            int maxY = Math.Min(479, minY + n);
            int maxX = Math.Min(479, minX + n);
            Color fontColor = Color.Black;


            for (int y = minY; y <= maxY; y++)
            {
                for (int x = minX; x <= maxX; x++)
                {
                    Color squareColor = GetColor(weight, minValue, maxValue);
                    fontColor = Color.FromArgb(255 - squareColor.R, 255 - squareColor.G, 255 - squareColor.B);
                    bitmap.SetPixel(x, y, squareColor);
                }
            }

            Graphics g = Graphics.FromImage(bitmap);

            TextRenderer.DrawText(g, String.Format("{2}", i, j, weight), Font, new Point(j * n + n / 2, i * n + n / 2), fontColor);
        }

        private static Bitmap SCALE = AppPrincipal.Properties.Resources.scale;

        private Color GetColor(int weight, int minValue, int maxValue)
        {
            int indiceNorm = weight - minValue;
            int maxNorm = maxValue - minValue;

            int i = indiceNorm * 100 / maxNorm;
            if (i < 0)
                i = 1;
            if (i > SCALE.Width - 1)
                i = SCALE.Width - 1;
            return SCALE.GetPixel(i, 10);
        }
    }
}
