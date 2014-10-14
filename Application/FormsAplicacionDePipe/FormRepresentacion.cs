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
        private string nombreArchivo = "svm.dat";
        private string carpetaDestino = string.Empty;
        private StringBuilder texto = new StringBuilder();

        public FormRepresentacion(Form mdiParent)
        {
            InitializeComponent();
            this.MdiParent = mdiParent;
            
        }

        private void buttonObtenerRepresentacion_Click(object sender, EventArgs e)
        {
            if (!textBoxCarpetaDestino.Text.Equals(nombreArchivo))
            {
                richTextBoxTextoArchivo.Enabled = false;
                richTextBoxTextoArchivo.Text = string.Empty;
                IRepresentation representation = new Representation();
                List<Tweet> tweets = DataBase.Instance.GetTweetsForClassify((int)(((App)this.MdiParent).PipeConfiguration.categoryLevel));
                List<string[]> tokens = DataBase.Instance.GetTokens((string)(((App)this.MdiParent).PipeConfiguration.preprocessing.guid));
                float parsedMinWheight = 0;
                float.TryParse(textBoxMinWeight.Text, out parsedMinWheight);
                representation.CreateRepresentationFile(tokens, tokens.Count, tweets.Select(t => t.Id_Category).ToArray(), @"" + textBoxCarpetaDestino.Text, parsedMinWheight);
                ((App)MdiParent).PipeConfiguration.representation.filename = textBoxCarpetaDestino.Text;
                ((App)MdiParent).ValidateConfiguration();
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
                textBoxCarpetaDestino.Text = carpetaDestino + "\\" + nombreArchivo;
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
                System.IO.StreamReader file = new System.IO.StreamReader(@"" + textBoxCarpetaDestino.Text);
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
            string filename = (string)((App)MdiParent).PipeConfiguration.representation.filename;
            textBoxCarpetaDestino.Text = filename ?? nombreArchivo;
            if (!String.IsNullOrWhiteSpace(filename) && File.Exists(filename))
            {
                carpetaDestino = filename.Substring(0, filename.Length - 7);
                buttonVisualizarRepresentacion.Enabled = true;
                buttonAbrirCarpetaContenedora.Enabled = true;
            }
        }
    }
}
