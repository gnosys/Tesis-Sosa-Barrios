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
        DataBase db = new DataBase();

        public App()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
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
            if (SelectCantCategorias.Text!= "" && int.Parse(SelectCantCategorias.Text) > 0 && int.Parse(SelectCantCategorias.Text) < 1001)
            {
                List<string> categorias = db.Categories(int.Parse(SelectCantCategorias.Text));
                dataGridViewCategorias.Rows.Clear();
                foreach (string s in categorias)
                    dataGridViewCategorias.Rows.Add(s);
            }
        }


    }
}
