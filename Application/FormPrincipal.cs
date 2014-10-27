using DataBaseSQL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AppPrincipal.FormsPreprocesamientos;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using TFIDFWeighting;
using SVM_Multiclass_Interface;
using AppPrincipal.FormsAplicacionDePipe;
using System;
using AppPrincipal.FormsCompararResultados;

namespace AppPrincipal
{
    public partial class App : Form
    {
        FormDataBaseYSeleccionarCategoria formDataBaseYSeleccionarCategoria;
        FormTokenization formTokenization;
        FormStopWords formStopWords;
        FormStemmer formStemmer;
        FormPreprocesamiento formPreprocesamiento;
        FormEnriquecimiento formEnriquecimiento;
        FormTratamientoEnTexto formTratamientoEnTexto;
        FormRepresentacion formRepresentacion;
        FormSVMLigth formSVMLigth;
        FormCompararResultados formCompararResultados;
        FormMatrizDeConfusion formMatrizDeConfusion;

        //from file.pip
        public dynamic PipeConfiguration { get; set; }

        public App()
        {
            PipeConfiguration = JObject.Parse(File.ReadAllText(@"Recursos\Pipes\pipe-default.pip"));
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            crearFormularios();
        }

        private void crearFormularios()
        {
            this.IsMdiContainer = true;

            // Formulario de los botones "Data Base" y "Seleccionar Categoria"
            formDataBaseYSeleccionarCategoria = new FormDataBaseYSeleccionarCategoria(this);

            // Formulario del boton "Tokenization"
            formTokenization = new FormTokenization();
            formTokenization.MdiParent = this;

            // Formulario del boton "Stop Words"
            formStopWords = new FormStopWords();
            formStopWords.MdiParent = this;

            // Formulario del boton "Stemmer"
            formStemmer = new FormStemmer();
            formStemmer.MdiParent = this;

            // Formulario del boton "Enriquecimiento"
            formEnriquecimiento = new FormEnriquecimiento();
            formEnriquecimiento.MdiParent = this;

            // Formulario del boton "Preprocesamiento"
            formPreprocesamiento = new FormPreprocesamiento();
            formPreprocesamiento.MdiParent = this;

            // Formulario del boton "Tratamiento en Texto"
            formTratamientoEnTexto = new FormTratamientoEnTexto();
            formTratamientoEnTexto.MdiParent = this;

            // Formulario del boton "Representacion"
            formRepresentacion = new FormRepresentacion(this);

            // Formulario del boton "SVM-Ligth"
            formSVMLigth = new FormSVMLigth(this);

            // Formulario del boton "Comparar resultados"
            formCompararResultados = new FormCompararResultados();
            formCompararResultados.MdiParent = this;

            // Formulario del boton "Matriz de Confusion"
            formMatrizDeConfusion = new FormMatrizDeConfusion(this);
            

            ValidateConfiguration();
        }

        public void ValidateConfiguration()
        {
            string nombreArchivoLearn = "svm-learn.dat";
            string nombreArchivoClassify = "svm-classify.dat";
            string directoryFilePath = (string)PipeConfiguration.representation.directoryFilePath;

            this.buttonPreprocesamiento.Enabled = formDataBaseYSeleccionarCategoria.IsValidConfiguration();
            this.buttonRepresentacion.Enabled = buttonPreprocesamiento.Enabled && !String.IsNullOrWhiteSpace((string)PipeConfiguration.preprocessing.guid) && DataBase.Instance.ExistTokens((string)PipeConfiguration.preprocessing.guid);
            this.buttonEjecutarSVMLigth.Enabled = buttonRepresentacion.Enabled && !String.IsNullOrWhiteSpace(directoryFilePath) && File.Exists(String.Format(@"{0}\{1}", directoryFilePath, nombreArchivoLearn)) && File.Exists(String.Format(@"{0}\{1}", directoryFilePath, nombreArchivoClassify));
            this.buttonMatrizConfusion.Enabled = File.Exists((string)PipeConfiguration.svm.predictionsFilename);
        }

        // Oculta todos los formularios.
        private void ocultarFormularios()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Hide();
            }
        }

        private void buttonDataBase_Click(object sender, System.EventArgs e)
        {
            ocultarFormularios();
            formDataBaseYSeleccionarCategoria.Dock = DockStyle.Fill;
            formDataBaseYSeleccionarCategoria.ocultarPanelSeleccionarCategoria();
            formDataBaseYSeleccionarCategoria.Show();
        }

        private void buttonSeleccionarCategoria_Click(object sender, System.EventArgs e)
        {
            ocultarFormularios();
            formDataBaseYSeleccionarCategoria.Dock = DockStyle.Fill;
            formDataBaseYSeleccionarCategoria.mostrarPanelSeleccionarCategoria();
            formDataBaseYSeleccionarCategoria.Show();
        }

        private void buttonTokenization_Click(object sender, System.EventArgs e)
        {
            ocultarFormularios();
            formTokenization.Dock = DockStyle.Fill;
            formTokenization.Show();
        }

        private void buttonStopWords_Click(object sender, System.EventArgs e)
        {
            ocultarFormularios();
            formStopWords.Dock = DockStyle.Fill;
            formStopWords.Show();
        }

        private void buttonStemmer_Click(object sender, System.EventArgs e)
        {
            ocultarFormularios();
            formStemmer.Dock = DockStyle.Fill;
            formStemmer.Show();
        }

        private void buttonPreprocesamiento_Click(object sender, System.EventArgs e)
        {
            ocultarFormularios();
            formPreprocesamiento.Dock = DockStyle.Fill;
            formPreprocesamiento.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void cargarDatosDePipeEnFormularios()
        {
            formDataBaseYSeleccionarCategoria.setTextBoxConeccionSQL((string)PipeConfiguration.database.connectionString ?? "");
            formDataBaseYSeleccionarCategoria.setTextBoxSeleccionarNivel((string)PipeConfiguration.categoryLevel ?? "");
            formRepresentacion.Init();
            formSVMLigth.Init();
            formMatrizDeConfusion.Init();
        }

        private void cargarPipeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog buscarArchivo = new OpenFileDialog();
            buscarArchivo.ShowDialog();
            string path = buscarArchivo.FileName;

            if (path.EndsWith(".pip"))
            {
                try
                {
                    string readText = File.ReadAllText(path);
                    PipeConfiguration = JObject.Parse(readText);
                    cargarDatosDePipeEnFormularios();
                    DialogResult result = MessageBox.Show("Su configuracion fue cargada exitosamente", "Carga Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ValidateConfiguration();
                }
                catch
                {
                    DialogResult result = MessageBox.Show("El archivo se encuentra dañado o no es JSON válido", "Archivo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!path.Equals(""))
                {
                    DialogResult result = MessageBox.Show("El archivo no tiene un formato valido .pip", "Archivo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEnriquecimiento_Click(object sender, System.EventArgs e)
        {
            ocultarFormularios();
            formEnriquecimiento.Dock = DockStyle.Fill;
            formEnriquecimiento.Show();
        }

        private void buttonTratamientoEnTexto_Click(object sender, System.EventArgs e)
        {
            ocultarFormularios();
            formTratamientoEnTexto.Dock = DockStyle.Fill;
            formTratamientoEnTexto.Show();
        }

        private void buttonRepresentacion_Click(object sender, System.EventArgs e)
        {
            ocultarFormularios();
            formRepresentacion.Dock = DockStyle.Fill;
            formRepresentacion.Show();
        }

        private void guardarPipeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            string json = JsonConvert.SerializeObject(PipeConfiguration);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pipe|*.pip";
            saveFileDialog.Title = "Guardar configuracion en un archivo";
            saveFileDialog.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog.OpenFile();
                byte[] bytes = Encoding.UTF8.GetBytes(json.ToString());
                foreach (byte b in bytes)
                {
                    fs.WriteByte(b);
                }
                fs.Flush();
                fs.Close();
            }
        }

        private void buttonCompararResultados_Click(object sender, System.EventArgs e)
        {
            ocultarFormularios();
            formCompararResultados.Dock = DockStyle.Fill;
            formCompararResultados.Show();
        }

        private void buttonEjecutarSVMLigth_Click(object sender, System.EventArgs e)
        {
            ocultarFormularios();
            formSVMLigth.Dock = DockStyle.Fill;
            formSVMLigth.Show();
        }

        private void acercaPreprocesadorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Software desarrollado por:\n\n Barrios, Pablo Jesus\n Sosa, Matias Sebastian", "Acerca de Preprocesado", MessageBoxButtons.OK);
        }

        private void buttonMatrizConfusion_Click(object sender, EventArgs e)
        {
            ocultarFormularios();
            formMatrizDeConfusion.Dock = DockStyle.Fill;
            formMatrizDeConfusion.Show();
        }

    }
}
