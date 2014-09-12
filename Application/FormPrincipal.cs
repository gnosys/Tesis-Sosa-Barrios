using DataBaseSQL;
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
    public partial class App : Form
    {
        DataBase db = null;
        int indexs;

        public App()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void cleanLabels()
        {
            labelConeccionEstablecida.Visible = false;
            labelConeccionFallida.Visible = false;
        }

        private void enableForms()
        {
            SelectCantTuplas.Enabled = true;
            SelectCantDatos.Enabled = true;
            buttonMostrarTuplas.Enabled = true;
            buttonMostrarCategorias.Enabled = true;
            buttonMostrarTextos.Enabled = true;
            cleanGrid();
        }

        private void disableForms()
        {
            SelectCantTuplas.Enabled = false;
            SelectCantDatos.Enabled = false;
            buttonMostrarTuplas.Enabled = false;
            buttonMostrarCategorias.Enabled = false;
            buttonMostrarTextos.Enabled = false;
            cleanGrid();
        }

        private void cleanGrid()
        {
            dataGridViewTuplas.Rows.Clear();
            dataGridViewDatos.Rows.Clear();
            dataGridViewDatos.Columns.Clear();
        }

        private void cleanPanels()
        {
            panelDataBase.Visible = false;
        }

        private void buttonMostrarTuplas_Click(object sender, System.EventArgs e)
        {
            if (SelectCantTuplas.Text!= "" && int.Parse(SelectCantTuplas.Text) > 0 && int.Parse(SelectCantTuplas.Text) < 10001)
            {
                List<Tweet> tuplas = db.Search(int.Parse(SelectCantTuplas.Text));
                dataGridViewTuplas.Rows.Clear();
                foreach (Tweet t in tuplas)
                    dataGridViewTuplas.Rows.Add(t.Id, t.Tweet_Id, t.Author, t.Entity_Id, t.Category, t.Text, t.Id_Category);
            }
        }

        private void buttonMostrarCategorias_Click(object sender, System.EventArgs e)
        {
            if (SelectCantDatos.Text!= "" && int.Parse(SelectCantDatos.Text) > 0 && int.Parse(SelectCantDatos.Text) < 10001)
            {
                List<string> categorias = db.Categories(int.Parse(SelectCantDatos.Text));
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
                List<string> textos = db.Texts(int.Parse(SelectCantDatos.Text));
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

        private void buttonDataBase_Click(object sender, System.EventArgs e)
        {
            cleanPanels();
            panelDataBase.Visible = true;
            panelSeleccionarCategoria.Visible = false;
        }

        private void buttonComprobarConeccion_Click(object sender, System.EventArgs e)
        {
            cleanLabels();
            if (!textBoxConeccionSQL.Text.Equals(""))
            {
                if (db != null)
                    db.Dispose();
                db = new DataBase(textBoxConeccionSQL.Text);
                if (db.CheckConnection())
                {
                    labelConeccionEstablecida.Visible = true;
                    enableForms();
                }
                else
                {
                    labelConeccionFallida.Visible = true;
                    disableForms();
                }
            }
        }

        private void buttonStopWords_Click(object sender, System.EventArgs e)
        {
            cleanPanels();
        }

        private void buttonStemmer_Click(object sender, System.EventArgs e)
        {
            cleanPanels();
        }

        private void buttonSeleccionarCategoria_Click(object sender, System.EventArgs e)
        {
            cleanPanels();
            panelDataBase.Visible = true;
            panelSeleccionarCategoria.Visible = true;
        }

        private void buttonCalcularNiveles_Click(object sender, System.EventArgs e)
        {
            labelCalculandoNiveles.Visible = true;
            labelNivelesCalculados.Visible = false;
            labelCantidadNiveles.Text = db.GetAmountNiveles().ToString();
            labelCalculandoNiveles.Visible = false;
            labelNivelesCalculados.Visible = true;
        }

        private void buttonSeleccionarNivel_Click(object sender, System.EventArgs e)
        {
            if (textBoxSeleccionarNivel.Text != "" && int.Parse(textBoxSeleccionarNivel.Text) <= int.Parse(labelCantidadNiveles.Text))
            {
                labelSeleccionandoNivel.Visible = true;
                List<string> categorias = db.CategoriesSelected(int.Parse(textBoxSeleccionarNivel.Text));
                listBoxCategoriasNivel.Items.Clear();
                foreach (string c in categorias)
                {
                    listBoxCategoriasNivel.Items.Add(c);
                }
                labelSeleccionandoNivel.Visible = false;
            }
        }

        private void buttonCrearCategorias_Click(object sender, System.EventArgs e)
        {
            if (listBoxCategoriasNivel.Items.Count != 0)
            {
                List<string> newCategorias = new List<string>();
                for (int i = 0; i < listBoxCategoriasNivel.Items.Count; i++)
                    newCategorias.Add(listBoxCategoriasNivel.Items[i].ToString());
                db.ClearTableCategories();
                db.CreateCategories(newCategorias);
                List<string> categoriasDB = db.AllNewCategories();
                dataGridViewCategoriasCreadas.Rows.Clear();
                int id = 1;
                foreach (string c in categoriasDB)
                {
                    dataGridViewCategoriasCreadas.Rows.Add(id++, c);
                }
            }
        }


    }
}
