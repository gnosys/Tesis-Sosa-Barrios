﻿using SVM_Multiclass_Interface;
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


        public FormSVMLigth(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            Init();            
        }

        public void Init()
        {
            string modelFilename = (string)(((App)MdiParent).PipeConfiguration).svm.modelFilename;
            textBoxCarpetaDestinoModelo.Text = String.IsNullOrWhiteSpace(modelFilename) ? nombreArchivoModelo : modelFilename;
            carpetaDestinoModelo = String.IsNullOrWhiteSpace(modelFilename) ? String.Empty : modelFilename.Substring(0, modelFilename.Length - 7);
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
                string vsmFileName = (string)(((App)MdiParent).PipeConfiguration).representation.filename;
                svm.Learn(vsmFileName, textBoxCarpetaDestinoModelo.Text);
                (((App)MdiParent).PipeConfiguration).svm.modelFilename = textBoxCarpetaDestinoModelo.Text;
                labelModeloGenerado.Show();
                buttonVisualizarModelo.Enabled = true;
                buttonAbrirCarpetaContenedoraModelo.Enabled = true;
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
                //ACA VA EL CODIGO PARA EJECUTAR SVM
                labelPrediccionesGeneradas.Show();
                buttonVisualizarPrediccion.Enabled = true;
                buttonAbrirCarpetaContenedoraPrediccion.Enabled = true;
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
