using SVM_Multiclass_Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal.FormsAplicacionDePipe
{
    public partial class FormSVMLigth : Form
    {
        private string nombreArchivoModelo = "modelo";
        private string nombreArchivoPrediccion = "predicciones";
        private string carpetaDestino = string.Empty;
        private StringBuilder textoModelo = new StringBuilder();
        private StringBuilder textoPrediccion = new StringBuilder();
        private string c;

        public FormSVMLigth(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        public void Init()
        {
            this.c = (string)(((App)MdiParent).PipeConfiguration).svm.c;

            string directoryFilesPath = (string)(((App)MdiParent).PipeConfiguration).svm.directoryFilesPath;

            if (!String.IsNullOrWhiteSpace(directoryFilesPath))
            {
                textBoxCarpetaDestino.Text = directoryFilesPath;
                carpetaDestino = directoryFilesPath;

                if (File.Exists(String.Format(@"{0}\{1}", directoryFilesPath, nombreArchivoModelo)))
                {
                    this.buttonVisualizarModelo.Enabled = true;
                    this.buttonGenerarPrediccion.Enabled = true;
                    this.buttonAbrirCarpetaContenedora.Enabled = true;
                    labelModeloGenerado.Show();
                }

                if (File.Exists(String.Format(@"{0}\{1}", directoryFilesPath, nombreArchivoPrediccion)))
                {
                    this.buttonVisualizarPrediccion.Enabled = true;
                    this.buttonAbrirCarpetaContenedora.Enabled = true;
                    labelPrediccionesGeneradas.Show();
                }
            }
        }

        public void Clean()
        {
            labelErrorCarpeta.Hide();
            labelModeloGenerado.Hide();
            labelPrediccionesGeneradas.Hide();
            textBoxCarpetaDestino.Clear();
            this.buttonVisualizarModelo.Enabled = false;
            this.buttonGenerarPrediccion.Enabled = false;
            this.buttonVisualizarPrediccion.Enabled = false;
            this.buttonAbrirCarpetaContenedora.Enabled = false;
            ((App)MdiParent).DesactivarBotonMatriz();
            ((App)MdiParent).DesactivarBotonComparar();
        }


        private void buttonSeleccionarCarpetaModelo_Click(object sender, EventArgs e)
        {
            labelErrorCarpeta.Hide();
            labelModeloGenerado.Hide();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                carpetaDestino = folderBrowserDialog.SelectedPath;
                textBoxCarpetaDestino.Text = carpetaDestino;
                (((App)MdiParent).PipeConfiguration).svm.directoryFilesPath = textBoxCarpetaDestino.Text;
            }
        }

        private void buttonAbrirCarpetaContenedoraModelo_Click(object sender, EventArgs e)
        {
            labelModeloGenerado.Hide();
            Process.Start("explorer.exe", carpetaDestino);
        }

        private void buttonGenerarModelo_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxCarpetaDestino.Text))
            {
                labelErrorCarpeta.Hide();
                labelModeloGenerado.Hide();
                labelPrediccionesGeneradas.Hide();
                richTextBoxTextoModelo.Enabled = false;
                richTextBoxTextoModelo.Text = string.Empty;
                ISVMMulticlass svm = new SVMMulticlass();
                string directoryFilePath = (string)(((App)MdiParent).PipeConfiguration).representation.directoryFilePath;
                string directoryFilesPath = (string)(((App)MdiParent).PipeConfiguration).svm.directoryFilesPath;
                string vsmFileName = String.Format(@"{0}\svm-learn.dat", directoryFilePath);
                int code = 0;
                svm.Learn(vsmFileName, directoryFilesPath + "\\" + nombreArchivoModelo, c, ref code);
                if (code.Equals(0))
                {
                    labelModeloGenerado.Show();
                    buttonVisualizarModelo.Enabled = true;
                    buttonAbrirCarpetaContenedora.Enabled = true;
                    buttonGenerarPrediccion.Enabled = true;
                }
            }
            else
            {
                labelErrorCarpeta.Show();
            }
        }

        private void buttonVisualizarModelo_Click(object sender, EventArgs e)
        {
            labelModeloGenerado.Hide();
            string line;
            textoModelo.Clear();
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"" + textBoxCarpetaDestino.Text + "\\" + nombreArchivoModelo);
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
            if (!String.IsNullOrEmpty(textBoxCarpetaDestino.Text))
            {
                labelErrorCarpeta.Hide();
                labelPrediccionesGeneradas.Hide();
                richTextBoxTextoPrediccion.Enabled = false;
                richTextBoxTextoPrediccion.Text = string.Empty;

                ISVMMulticlass svm = new SVMMulticlass();

                string directoryFilePath = (string)(((App)MdiParent).PipeConfiguration).representation.directoryFilePath;
                string directoryFilesPath = (string)(((App)MdiParent).PipeConfiguration).svm.directoryFilesPath;

                string vsmFileName = String.Format(@"{0}\svm-classify.dat", directoryFilePath);
                int code = 0;
                svm.Classify(vsmFileName, directoryFilesPath + "\\" + nombreArchivoModelo, directoryFilesPath + "\\" + nombreArchivoPrediccion, ref code);
                if (code.Equals(0))
                {
                    labelPrediccionesGeneradas.Show();
                    buttonVisualizarPrediccion.Enabled = true;
                    buttonAbrirCarpetaContenedora.Enabled = true;
                    ((App)MdiParent).ActivarBotonMatriz();
                    ((App)MdiParent).formCompararResultados.Init();
                    ((App)MdiParent).ActivarBotonComparar();
                }
            }
            else
            {
                labelErrorCarpeta.Show();
            }
        }

        private void buttonVisualizarPrediccion_Click(object sender, EventArgs e)
        {
            labelPrediccionesGeneradas.Hide();
            string line;
            textoPrediccion.Clear();
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"" + textBoxCarpetaDestino.Text + "\\" + nombreArchivoPrediccion);
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
