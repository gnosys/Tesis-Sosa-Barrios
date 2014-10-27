using SVM_Multiclass_Interface;
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

namespace AppPrincipal.FormsAplicacionDePipe
{
    public partial class FormSVMLigth : Form
    {
        private string nombreArchivoModelo = "modelo";
        private string carpetaDestinoModelo = string.Empty;
        private StringBuilder textoModelo = new StringBuilder();
        private string nombreArchivoPrediccion = "predicciones";
        private string carpetaDestinoPrediccion = string.Empty;
        private StringBuilder textoPrediccion = new StringBuilder();
        private string c;

        public FormSVMLigth(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            Init();            
        }

        public void Init()
        {
            this.c = (string)(((App)MdiParent).PipeConfiguration).svm.c;

            string modelFilename = (string)(((App)MdiParent).PipeConfiguration).svm.modelFilename;
            textBoxCarpetaDestinoModelo.Text = String.IsNullOrWhiteSpace(modelFilename) ? nombreArchivoModelo : modelFilename;
            carpetaDestinoModelo = String.IsNullOrWhiteSpace(modelFilename) ? String.Empty : modelFilename.Substring(0, modelFilename.Length - 7);
            
            this.buttonAbrirCarpetaContenedoraModelo.Enabled = 
            this.buttonVisualizarModelo.Enabled =
            this.buttonGenerarPrediccion.Enabled = !String.IsNullOrWhiteSpace(modelFilename);

            string predictionsFilename = (string)(((App)MdiParent).PipeConfiguration).svm.predictionsFilename;
            textBoxCarpetaDestinoPrediccion.Text = String.IsNullOrWhiteSpace(predictionsFilename) ? nombreArchivoPrediccion : predictionsFilename;
            carpetaDestinoPrediccion = String.IsNullOrWhiteSpace(predictionsFilename) ? String.Empty : predictionsFilename.Substring(0, predictionsFilename.Length - 13);
            textBoxCarpetaDestinoPrediccion.Text = nombreArchivoPrediccion;


            this.buttonAbrirCarpetaContenedoraPrediccion.Enabled =
            this.buttonVisualizarPrediccion.Enabled = !String.IsNullOrWhiteSpace(predictionsFilename);

            textBoxCarpetaDestinoPrediccion.Text = nombreArchivoPrediccion;
        }

        private void buttonSeleccionarCarpetaModelo_Click(object sender, EventArgs e)
        {
            labelErrorCarpetaModelo.Hide();
            labelModeloGenerado.Hide();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                carpetaDestinoModelo = folderBrowserDialog.SelectedPath;
                textBoxCarpetaDestinoModelo.Text = carpetaDestinoModelo + "\\" + nombreArchivoModelo;
            }
        }

        private void buttonSeleccionarCarpetaPrediccion_Click(object sender, EventArgs e)
        {
            labelErrorCarpetaPrediccion.Hide();
            labelPrediccionesGeneradas.Hide();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                carpetaDestinoPrediccion = folderBrowserDialog.SelectedPath;
                textBoxCarpetaDestinoPrediccion.Text = carpetaDestinoPrediccion + "\\" + nombreArchivoPrediccion;
            }
        }

        private void buttonAbrirCarpetaContenedoraModelo_Click(object sender, EventArgs e)
        {
            labelModeloGenerado.Hide();
            Process.Start("explorer.exe", carpetaDestinoModelo);
        }

        private void buttonAbrirCarpetaContenedoraPrediccion_Click(object sender, EventArgs e)
        {
            labelPrediccionesGeneradas.Hide();
            Process.Start("explorer.exe", carpetaDestinoPrediccion);
        }

        private void buttonGenerarModelo_Click(object sender, EventArgs e)
        {
            if (!textBoxCarpetaDestinoModelo.Text.Equals(nombreArchivoModelo))
            {

                labelErrorCarpetaModelo.Hide();
                labelModeloGenerado.Hide();
                richTextBoxTextoModelo.Enabled = false;
                richTextBoxTextoModelo.Text = string.Empty;
                ISVMMulticlass svm = new SVMMulticlass();
                string directoryFilePath = (string)(((App)MdiParent).PipeConfiguration).representation.directoryFilePath;
                string vsmFileName = String.Format(@"{0}\svm-learn.dat", directoryFilePath);
                svm.Learn(vsmFileName, textBoxCarpetaDestinoModelo.Text, c);
                (((App)MdiParent).PipeConfiguration).svm.modelFilename = textBoxCarpetaDestinoModelo.Text;
                labelModeloGenerado.Show();
                buttonVisualizarModelo.Enabled = true;
                buttonAbrirCarpetaContenedoraModelo.Enabled = true;
                buttonGenerarPrediccion.Enabled = true;
            }
            else
            {
                labelErrorCarpetaModelo.Show();
            }
            
        }

        private void buttonVisualizarModelo_Click(object sender, EventArgs e)
        {
            labelModeloGenerado.Hide();
            string line;
            textoModelo.Clear();
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"" + textBoxCarpetaDestinoModelo.Text);
                while ((line = file.ReadLine()) != null)
                {
                    textoModelo.Append(line);
                    textoModelo.AppendLine();
                }
                richTextBoxTextoModelo.Text = textoModelo.ToString();
                richTextBoxTextoModelo.Enabled = true;
            }
            catch
            {
                DialogResult result = MessageBox.Show("El archivo no existe", "Archivo Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGenerarPrediccion_Click(object sender, EventArgs e)
        {
            if (!textBoxCarpetaDestinoPrediccion.Text.Equals(nombreArchivoPrediccion))
            {
                labelErrorCarpetaPrediccion.Hide();
                labelPrediccionesGeneradas.Hide();
                richTextBoxTextoPrediccion.Enabled = false;
                richTextBoxTextoPrediccion.Text = string.Empty;

                ISVMMulticlass svm = new SVMMulticlass();
                string modelFilename = (string)(((App)MdiParent).PipeConfiguration).svm.modelFilename;

                string directoryFilePath = (string)(((App)MdiParent).PipeConfiguration).representation.directoryFilePath;
                string vsmFileName = String.Format(@"{0}\svm-classify.dat", directoryFilePath);


                svm.Classify(vsmFileName, modelFilename, textBoxCarpetaDestinoPrediccion.Text);
                (((App)MdiParent).PipeConfiguration).svm.predictionsFilename = textBoxCarpetaDestinoPrediccion.Text;
                labelPrediccionesGeneradas.Show();
                buttonVisualizarPrediccion.Enabled = true;
                buttonAbrirCarpetaContenedoraPrediccion.Enabled = true;

                ((App)this.MdiParent).ValidateConfiguration();
            }
            else
            {
                labelErrorCarpetaPrediccion.Show();
            }
        }

        private void buttonVisualizarPrediccion_Click(object sender, EventArgs e)
        {
            labelPrediccionesGeneradas.Hide();
            string line;
            textoPrediccion.Clear();
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"" + textBoxCarpetaDestinoPrediccion.Text);
                while ((line = file.ReadLine()) != null)
                {
                    textoPrediccion.Append(line);
                    textoPrediccion.AppendLine();
                }
                richTextBoxTextoPrediccion.Text = textoPrediccion.ToString();
                richTextBoxTextoPrediccion.Enabled = true;
            }
            catch
            {
                DialogResult result = MessageBox.Show("El archivo no existe", "Archivo Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
