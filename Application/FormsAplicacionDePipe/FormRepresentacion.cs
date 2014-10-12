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

namespace AppPrincipal.FormsAplicacionDePipe
{
    public partial class FormRepresentacion : Form
    {
        private string nombreArchivo = "svm.dat";
        private string carpetaDestino = string.Empty;
        private string texto = string.Empty;

        public FormRepresentacion()
        {
            InitializeComponent();
            textBoxCarpetaDestino.Text = nombreArchivo;
        }

        private void buttonObtenerRepresentacion_Click(object sender, EventArgs e)
        {
            if (!textBoxCarpetaDestino.Text.Equals(nombreArchivo))
            {
                richTextBoxTextoArchivo.Enabled = false;
                //IRepresentation representation = new Representation();
                //List<Tweet> tweets = DataBase.Instance.GetTweetsForClassify((int)(((App)this.MdiParent).PipeConfiguration.categoryLevel));
                //List<string[]> tokens = DataBase.Instance.GetTokens((string)(((App)this.MdiParent).PipeConfiguration.preprocessing.guid));
                //representation.CreateRepresentationFile(tokens, tokens.Count, tweets.Select(t => t.Id_Category).ToArray(), @""+nombreArchivo);
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
            Process.Start("explorer.exe", carpetaDestino);
        }

        private void buttonVisualizarRepresentacion_Click(object sender, EventArgs e)
        {
            string line;
            texto = string.Empty;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"" + textBoxCarpetaDestino.Text);
                while ((line = file.ReadLine()) != null)
                {
                    texto += line + "\r\n";
                }
                richTextBoxTextoArchivo.Text = texto;
                richTextBoxTextoArchivo.Enabled = true;
            }
            catch
            {
                DialogResult result = MessageBox.Show("El archivo no existe", "Archivo Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
