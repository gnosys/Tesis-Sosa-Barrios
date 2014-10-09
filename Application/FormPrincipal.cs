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


        //from file.pip
        public dynamic PipeConfiguration { get; set; }

        public App()
        {
            crearFormularios();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void crearFormularios()
        {
            this.IsMdiContainer = true;

            // Formulario de los botones "Data Base" y "Seleccionar Categoria"
            formDataBaseYSeleccionarCategoria = new FormDataBaseYSeleccionarCategoria();
            formDataBaseYSeleccionarCategoria.MdiParent = this;

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

        private void cargarPipeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog buscarArchivo = new OpenFileDialog();
            buscarArchivo.ShowDialog();
            string path = buscarArchivo.FileName;

            if (path.EndsWith(".pip"))
            {
                string readText = File.ReadAllText(path);
                PipeConfiguration = JObject.Parse(readText);
                string message = "Su configuracion fue cargada exitosamente";
                string caption = "Carga Completa";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                if (!path.Equals(""))
                {
                    string message = "El archivo no tiene un formato valido .pip";
                    string caption = "Archivo Invalido";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, caption, buttons);
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
            IRepresentation representation = new Representation();
            List<Tweet> tweets = DataBase.Instance.GetTweetsForClassify((int)PipeConfiguration.categoryLevel);
            List<string[]> tokens = DataBase.Instance.GetTokens((string)PipeConfiguration.preprocessing.guid);
            representation.CreateRepresentationFile(tokens, tokens.Count, tweets.Select(t => t.Id_Category).ToArray(), @"VSM.txt");

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

    }
}
