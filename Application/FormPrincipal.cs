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

        private void buttonMostrarTuplas_Click(object sender, System.EventArgs e)
        {
            if (SelectCantTuplas.Text!= "" && int.Parse(SelectCantTuplas.Text) > 0 && int.Parse(SelectCantTuplas.Text) < 1001)
            {
                List<Tweet> tuplas = db.Search(int.Parse(SelectCantTuplas.Text));
                dataGridViewTuplas.Rows.Clear();
                foreach (Tweet t in tuplas)
                    dataGridViewTuplas.Rows.Add(t.Id, t.Tweet_Id, t.Author, t.Entity_Id, t.Category, t.Text, t.Id_Category);
            }
        }

        private void buttonMostrarCategorias_Click(object sender, System.EventArgs e)
        {
            if (SelectCantDatos.Text!= "" && int.Parse(SelectCantDatos.Text) > 0 && int.Parse(SelectCantDatos.Text) < 1001)
            {
                List<string> categorias = db.Categories(int.Parse(SelectCantDatos.Text));
                dataGridViewDatos.Rows.Clear();
                dataGridViewDatos.Columns.Clear();
                DataGridViewColumn columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = "Categoria";
                columna.Width = 700;
                dataGridViewDatos.Columns.Add(columna);
                foreach (string s in categorias)
                    dataGridViewDatos.Rows.Add(s);
            }
        }

        private void buttonMostrarTextos_Click(object sender, System.EventArgs e)
        {
            if (SelectCantDatos.Text != "" && int.Parse(SelectCantDatos.Text) > 0 && int.Parse(SelectCantDatos.Text) < 1001)
            {
                List<string> textos = db.Texts(int.Parse(SelectCantDatos.Text));
                dataGridViewDatos.Rows.Clear();
                dataGridViewDatos.Columns.Clear();
                DataGridViewColumn columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = "Texto";
                columna.Width = 700;
                dataGridViewDatos.Columns.Add(columna);
                foreach (string t in textos)
                    dataGridViewDatos.Rows.Add(t);
            }
        }

        private void buttonDataBase_Click(object sender, System.EventArgs e)
        {
            panelDataBase.Visible = true;
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

        

    }
}
