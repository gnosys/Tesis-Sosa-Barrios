using DataBaseSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFIDFWeighting;
using System.IO;

namespace AppPrincipal.FormsAplicacionDePipe
{
    public partial class FormRepresentacion : Form
    {

        private string nombreArchivoLearn = "svm-learn.dat";
        private string nombreArchivoClassify = "svm-classify.dat";
        private string carpetaDestino = string.Empty;
        private StringBuilder texto = new StringBuilder();

        public FormRepresentacion(Form mdiParent)
        {
            InitializeComponent();
            this.MdiParent = mdiParent;
        }

        private void buttonObtenerRepresentacion_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxCarpetaDestino.Text))
            {
                richTextBoxTextoArchivo.Enabled = false;
                richTextBoxTextoArchivo.Text = string.Empty;
                IRepresentation representation = new Representation();
                List<Tweet> tweets = DataBase.Instance.GetTweetsForClassify((int)(((App)this.MdiParent).PipeConfiguration.categoryLevel));
                List<string[]> tokens = DataBase.Instance.GetTokens((string)(((App)this.MdiParent).PipeConfiguration.preprocessing.guid));
                int trainingPercentage = (int)((App)this.MdiParent).PipeConfiguration.representation.trainingPercentage;
                float parsedMinWheight = 0;
                float.TryParse(textBoxMinWeight.Text, out parsedMinWheight);
                var categories = tweets.Select(t => t.Id_Category).ToArray();
                representation.CreateRepresentationFiles(tokens, tokens.Count, categories, @"" + textBoxCarpetaDestino.Text, parsedMinWheight, trainingPercentage);
                ((App)MdiParent).PipeConfiguration.representation.directoryFilePath = textBoxCarpetaDestino.Text;
                ((App)MdiParent).ValidateConfiguration();
                ((App)MdiParent).formMatrizDeConfusion.Init();
                labelRepresentacionObtenida.Show();
                buttonVisualizarRepresentacion.Enabled = true;
                buttonAbrirCarpetaContenedora.Enabled = true;
            }
            else
            {
                labelErrorCarpeta.Show();
            }
        }

        private void buttonSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            labelErrorCarpeta.Hide();
            labelRepresentacionObtenida.Hide();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                carpetaDestino = folderBrowserDialog.SelectedPath;
                textBoxCarpetaDestino.Text = carpetaDestino;
            }
        }

        private void buttonAbrirCarpetaContenedora_Click(object sender, EventArgs e)
        {
            labelRepresentacionObtenida.Hide();
            Process.Start("explorer.exe", carpetaDestino);
        }

        private void buttonVisualizarRepresentacion_Click(object sender, EventArgs e)
        {
            labelRepresentacionObtenida.Hide();
            string line;
            texto.Clear();
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(String.Format(@"{0}\{1}", textBoxCarpetaDestino.Text, nombreArchivoLearn));
                while ((line = file.ReadLine()) != null)
                {
                    texto.Append(line);
                    texto.AppendLine();
                }
                richTextBoxTextoArchivo.Text = texto.ToString();
                richTextBoxTextoArchivo.Enabled = true;
            }
            catch
            {
                DialogResult result = MessageBox.Show("El archivo no existe", "Archivo Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void Init()
        {
            string directoryFilePath = (string)((App)MdiParent).PipeConfiguration.representation.directoryFilePath;
            if (!String.IsNullOrWhiteSpace(directoryFilePath) && File.Exists(String.Format(@"{0}\{1}", directoryFilePath, nombreArchivoLearn)) && File.Exists(String.Format(@"{0}\{1}", directoryFilePath, nombreArchivoClassify)))
            {
                int lastSlash = directoryFilePath.LastIndexOf('/');
                directoryFilePath = (lastSlash > -1) ? directoryFilePath.Substring(0, lastSlash) : directoryFilePath;
                textBoxCarpetaDestino.Text = directoryFilePath ?? String.Empty;
                carpetaDestino = directoryFilePath;
                buttonVisualizarRepresentacion.Enabled = true;
                buttonAbrirCarpetaContenedora.Enabled = true;
            }
        }
    }
}
