using DataBaseSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal
{
    public partial class FormDataBaseYSeleccionarCategoria : Form
    {
        DataBase db = null;
        int indexs;

        public FormDataBaseYSeleccionarCategoria()
        {
            InitializeComponent();
        }

        private void cleanLabels()
        {
            labelConeccion.Visible = false;
        }

        private void enableForms()
        {
            SelectCantTuplas.Enabled = true;
            SelectCantDatos.Enabled = true;
            buttonMostrarTuplas.Enabled = true;
            buttonMostrarCategorias.Enabled = true;
            buttonMostrarTextos.Enabled = true;
            buttonCrearCategorias.Enabled = true;
            cleanGrid();
        }

        private void disableForms()
        {
            SelectCantTuplas.Enabled = false;
            SelectCantDatos.Enabled = false;
            buttonMostrarTuplas.Enabled = false;
            buttonMostrarCategorias.Enabled = false;
            buttonMostrarTextos.Enabled = false;
            buttonCrearCategorias.Enabled = false;
            cleanGrid();
        }

        private void cleanGrid()
        {
            dataGridViewTuplas.Rows.Clear();
            dataGridViewCategoriasCreadas.Rows.Clear();
            dataGridViewDatos.Rows.Clear();
            dataGridViewDatos.Columns.Clear();
            listBoxCategoriasNivel.Items.Clear();
        }

        private void buttonMostrarTuplas_Click(object sender, System.EventArgs e)
        {
            if (SelectCantTuplas.Text != "" && int.Parse(SelectCantTuplas.Text) > 0 && int.Parse(SelectCantTuplas.Text) < 10001)
            {
                List<Tweet> tuplas = db.SearchTweets(int.Parse(SelectCantTuplas.Text));
                dataGridViewTuplas.Rows.Clear();
                int indice = 1;
                foreach (Tweet t in tuplas)
                    dataGridViewTuplas.Rows.Add(indice++, t.Id, t.Tweet_Id, t.Author, t.Entity_Id, t.Category, t.Text, t.Id_Category);
            }
        }

        private void buttonMostrarCategorias_Click(object sender, System.EventArgs e)
        {
            if (SelectCantDatos.Text != "" && int.Parse(SelectCantDatos.Text) > 0 && int.Parse(SelectCantDatos.Text) < 10001)
            {
                List<string> categorias = db.CategoriesTableTweet(int.Parse(SelectCantDatos.Text));
                dataGridViewDatos.Rows.Clear();
                dataGridViewDatos.Columns.Clear();
                DataGridViewColumn columnaId = new DataGridViewTextBoxColumn();
                columnaId.HeaderText = "Id";
                columnaId.Width = 50;
                DataGridViewColumn columnaCategoria = new DataGridViewTextBoxColumn();
                columnaCategoria.HeaderText = "Categoria";
                columnaCategoria.Width = 650;
                dataGridViewDatos.Columns.Add(columnaId);
                dataGridViewDatos.Columns.Add(columnaCategoria);
                indexs = 1;
                foreach (string s in categorias)
                    dataGridViewDatos.Rows.Add(indexs++, s);
            }
        }

        private void buttonMostrarTextos_Click(object sender, System.EventArgs e)
        {
            if (SelectCantDatos.Text != "" && int.Parse(SelectCantDatos.Text) > 0 && int.Parse(SelectCantDatos.Text) < 10001)
            {
                List<string> textos = db.TextsTableTweet(int.Parse(SelectCantDatos.Text));
                dataGridViewDatos.Rows.Clear();
                dataGridViewDatos.Columns.Clear();
                DataGridViewColumn columnaId = new DataGridViewTextBoxColumn();
                columnaId.HeaderText = "Id";
                columnaId.Width = 50;
                DataGridViewColumn columnaTexto = new DataGridViewTextBoxColumn();
                columnaTexto.HeaderText = "Texto";
                columnaTexto.Width = 650;
                dataGridViewDatos.Columns.Add(columnaId);
                dataGridViewDatos.Columns.Add(columnaTexto);
                indexs = 1;
                foreach (string t in textos)
                    dataGridViewDatos.Rows.Add(indexs++, t);
            }
        }

        private void buttonComprobarConeccion_Click(object sender, System.EventArgs e)
        {
            cleanLabels();
            if (!textBoxConeccionSQL.Text.Equals(""))
            {
                if (db != null)
                    db.Dispose();
                DataBase.connectionString = textBoxConeccionSQL.Text;
                db = DataBase.Instance;
                if (db.CheckConnection())
                {
                    labelConeccion.ForeColor = Color.Green;
                    labelConeccion.Text = "Coneccion Establecida";
                    enableForms();
                }
                else
                {
                    labelConeccion.ForeColor = Color.Red;
                    labelConeccion.Text = "Coneccion Fallida";
                    disableForms();
                }
                labelConeccion.Visible = true;
            }
        }

        private void buttonSeleccionarNivel_Click(object sender, System.EventArgs e)
        {
            if (textBoxSeleccionarNivel.Text != "" && int.Parse(textBoxSeleccionarNivel.Text) <= int.Parse(labelCantidadNiveles.Text))
            {
                labelNivelSeleccionado.Visible = false;
                int amountTweetWithNivels = 0;
                int amountTweets = 0;
                List<string> categorias = db.CategoriesSelectedTableTweet(int.Parse(textBoxSeleccionarNivel.Text), ref amountTweets, ref amountTweetWithNivels);
                labelCantidadTweetProfundidadNivel.Text = amountTweetWithNivels.ToString();
                labelCantidadTweetProfundidadNivel.ForeColor = Color.Green;
                labelProfundidadNivelSeleccionado.Text = textBoxSeleccionarNivel.Text;
                labelProfundidadNivelSeleccionado.ForeColor = Color.Green;
                labelTotalCantidadDeTwwets.Text = amountTweets.ToString();
                labelTotalCantidadDeTwwets.ForeColor = Color.Green;
                labelCantidadDeCategoriasACrear.Text = categorias.Count.ToString();
                labelCantidadDeCategoriasACrear.ForeColor = Color.Green;
                listBoxCategoriasNivel.Items.Clear();
                foreach (string c in categorias)
                {
                    listBoxCategoriasNivel.Items.Add(c);
                }
                labelNivelSeleccionado.Visible = true;
                buttonMostrarTablaCategorias.Enabled = true;
            }
        }

        private void buttonCrearCategorias_Click(object sender, System.EventArgs e)
        {
            labelCategoriasCreadas.Visible = false;
            //db.RePopulateCategories();
            buttonSeleccionarNivel.Enabled = true;
            textBoxSeleccionarNivel.Enabled = true;
            labelCategoriasCreadas.Visible = true;
        }

        private void buttonMostrarTablaCategorias_Click(object sender, EventArgs e)
        {
            List<Category> categoriasDB = db.CategoriesTableCategory();
            dataGridViewCategoriasCreadas.Rows.Clear();
            foreach (Category c in categoriasDB)
            {
                dataGridViewCategoriasCreadas.Rows.Add(c.Id, c.Name);
            }
        }

        public void mostrarPanelSeleccionarCategoria()
        {
            panelSeleccionarCategoria.Show();
        }

        public void ocultarPanelSeleccionarCategoria()
        {
            panelSeleccionarCategoria.Hide();
        }

    }
}
