using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private string _vsmClassificationFile;
        private string _predictionsFile;

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

        private int[][] BuildConfusionMatrix(int[] actualCategories, int[] predictedCategories, List<int> categoryLabels)
        {
            int length = categoryLabels.Count;
            int[][] confusionMatrix = new int[length][];

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
            return confusionMatrix;
        }

        private void buttonObtenerMatriz_Click(object sender, EventArgs e)
        {

            string[] linesActualCategories = File.ReadAllLines(_vsmClassificationFile);
            string[] linesPredictedCategories = File.ReadAllLines(_predictionsFile);

            int[] actualCategories = linesActualCategories.Select(x => int.Parse(x.Split(' ').ElementAt(0))).ToArray();
            int[] predictedCategories = linesPredictedCategories.Select(x => int.Parse(x.Split(' ').ElementAt(0))).ToArray();
            var missingCategories = predictedCategories.Where(x => !actualCategories.Contains(x)).ToList();
            List<int> categoryLabels = actualCategories.Union(missingCategories).ToList();

            int[][] confusionMatrix = BuildConfusionMatrix(actualCategories, predictedCategories, categoryLabels);

            DrawConfusionMatrix(confusionMatrix);
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
            bitmap.Save(@"C:\Users\Pablo\Desktop\mc.png", ImageFormat.Png);
            panelMatriz.BackgroundImage = bitmap;
            labelObtenerMatriz.Show();
        }

        

        private void DrawConfusionMatrixSquare(Bitmap bitmap, int i, int j, int weight, int n, int minValue, int maxValue)
        {
            int minY = i * n;
            int minX = j * n;
            Color squareColor = GetColor(weight, minValue, maxValue);
            Color fontColor = Color.FromArgb(255 - squareColor.R, 255 - squareColor.G, 255 - squareColor.B);
            using(Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillRectangle(new SolidBrush(squareColor), new Rectangle(minX, minY, 10, 10));
                //TextRenderer.DrawText(g, String.Format("{2}", i, j, weight), Font, new Point(j * n + n / 2, i * n + n / 2), fontColor);
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
    }
}
