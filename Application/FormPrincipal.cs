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

namespace AppPrincipal
{
    public partial class App : Form
    {

        FormDataBaseYSeleccionarCategoria formDataBaseYSeleccionarCategoria;
        FormTokenization formTokenization;
        FormStopWords formStopWords;
        FormStemmer formStemmer;
        FormPreprocesamiento formPreprocesamiento;

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

            // formulario del boton "Preprocesamiento"
            formPreprocesamiento = new FormPreprocesamiento();
            formPreprocesamiento.MdiParent = this;
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

    }
}
