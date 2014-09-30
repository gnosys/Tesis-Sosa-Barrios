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
    public partial class FormPreprocesamiento : Form
    {
        bool cambiarTabs = false;

        public FormPreprocesamiento()
        {
            InitializeComponent();
        }

        private void buttonPreprocesar_Click(object sender, EventArgs e)
        {

            List<Tweet> tweets = db.SearchTweetsUpdates(0);

            List<string> docs = tweets.Select(x => x.Text).ToList();


            ////tokenizer delimiter
            //Regex delimiter = new Regex("([ \\t{}():;. \n])");

            ////chain of responsability: docs and words transformations
            //PreFilter preFilter = new EmptyPreFilter(null);
            //AroundFilter aroundFilter = new StopWordFilter(new StemmingFilter(null));

            ////preprocessing
            //ITokenizer tokenizer = new Tokenizer(delimiter, preFilter, aroundFilter);
            //var TFIDFInput = tokenizer.Tokenize(docs).ToList();

            ////representation
            //TFIDFMeasure tfdif = new TFIDFMeasure(TFIDFInput);
            //var bow = StringUtils.ArrayListToArray(tfdif.Terms);
            //CreateBOWFile(bow);
            //CreateVSMFile(tfdif.TermWeight, TFIDFInput.Count);
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (listViewPreprocesamientos.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listViewPreprocesamientos.SelectedItems[0];
                listViewPreprocesamientos.SelectedItems[0].Remove();
                listViewOrdenPreprocesos.Items.Add(seleccion);
                listViewOrdenPreprocesos.Focus();
            }
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            if (listViewOrdenPreprocesos.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listViewOrdenPreprocesos.SelectedItems[0];
                listViewOrdenPreprocesos.SelectedItems[0].Remove();
                listViewPreprocesamientos.Items.Add(seleccion);
                listViewPreprocesamientos.Focus();
                tabControlConfiguraciones.Hide();
            }
        }

        private void buttonSubir_Click(object sender, EventArgs e)
        {
            if (listViewOrdenPreprocesos.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listViewOrdenPreprocesos.SelectedItems[0];
                if (seleccion.Index > 0)
                {
                    int pos = seleccion.Index - 1;
                    listViewOrdenPreprocesos.Items.RemoveAt(seleccion.Index);
                    listViewOrdenPreprocesos.Items.Insert(pos, seleccion);
                }
            }
            listViewOrdenPreprocesos.Focus();
        }

        private void buttonBajar_Click(object sender, EventArgs e)
        {
            if (listViewOrdenPreprocesos.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listViewOrdenPreprocesos.SelectedItems[0];
                if (seleccion.Index < (listViewOrdenPreprocesos.Items.Count - 1))
                {
                    int pos = seleccion.Index + 1;
                    listViewOrdenPreprocesos.Items.RemoveAt(seleccion.Index);
                    listViewOrdenPreprocesos.Items.Insert(pos, seleccion);
                }
            }
            listViewOrdenPreprocesos.Focus();
        }

        private void manejoConfiguraciones()
        {
            cambiarTabs = true;
            tabControlConfiguraciones.Hide();
            if (listViewOrdenPreprocesos.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listViewOrdenPreprocesos.SelectedItems[0];
                if (seleccion.Text.Equals("Stemmer"))
                {
                    tabControlConfiguraciones.SelectTab(0);
                }
                else if (seleccion.Text.Equals("Stop Words"))
                {
                    tabControlConfiguraciones.SelectTab(1);
                }
                else if (seleccion.Text.Equals("Tokenizacion"))
                {
                    tabControlConfiguraciones.SelectTab(2);
                }
                else if (seleccion.Text.Equals("Enriquecimiento"))
                {
                    tabControlConfiguraciones.SelectTab(3);
                }
                tabControlConfiguraciones.Show();
            }
            cambiarTabs = false;
            listViewOrdenPreprocesos.Focus();
        }

        private void listViewOrdenPreprocesos_Enter(object sender, EventArgs e)
        {
            manejoConfiguraciones();
        }

        private void checkBoxListaStopWordsDefecto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxListaStopWordsDefecto.Checked)
            {
                textBoxDireccionStopWords.Enabled = false;
                buttonBuscarListStopWords.Enabled = false;
            }
            else
            {
                textBoxDireccionStopWords.Enabled = true;
                buttonBuscarListStopWords.Enabled = true;
            }
        }

        private void tabControlConfiguraciones_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!cambiarTabs)
                e.Cancel = true;
        }

        private void listViewOrdenPreprocesos_Click(object sender, EventArgs e)
        {
            manejoConfiguraciones();
        }

        private void buttonBuscarListStopWords_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarArchivo = new OpenFileDialog();
            buscarArchivo.ShowDialog();
            string directorio = buscarArchivo.FileName;
            textBoxDireccionStopWords.Text = directorio;

            if (directorio.EndsWith(".txt"))
            {
                labelArchivosTxt.ForeColor = Color.Gray;
                //guardar en la base de datos y agregar.
            }
            else
            {
                labelArchivosTxt.ForeColor = Color.Red;
            }
        }
    }
}
