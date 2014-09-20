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
        public FormPreprocesamiento()
        {
            InitializeComponent();
        }

        private void buttonPreprocesar_Click(object sender, EventArgs e)
        {
            //List<Tweet> tweets = db.SearchTweetsUpdates(0);

            //List<string> docs = tweets.Select(x => x.Text).ToList();


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
                listViewOdenPreprocesos.Items.Add(seleccion);
                listViewOdenPreprocesos.Focus();
            }
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            if (listViewOdenPreprocesos.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listViewOdenPreprocesos.SelectedItems[0];
                listViewOdenPreprocesos.SelectedItems[0].Remove();
                listViewPreprocesamientos.Items.Add(seleccion);
                listViewPreprocesamientos.Focus();
            }
        }

        private void buttonSubir_Click(object sender, EventArgs e)
        {
            if (listViewOdenPreprocesos.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listViewOdenPreprocesos.SelectedItems[0];
                if (seleccion.Index > 0)
                {
                    int pos = seleccion.Index - 1;
                    listViewOdenPreprocesos.Items.RemoveAt(seleccion.Index);
                    listViewOdenPreprocesos.Items.Insert(pos, seleccion);
                }
            }
            listViewOdenPreprocesos.Focus();
        }

        private void buttonBajar_Click(object sender, EventArgs e)
        {
            if (listViewOdenPreprocesos.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listViewOdenPreprocesos.SelectedItems[0];
                if (seleccion.Index < (listViewOdenPreprocesos.Items.Count - 1))
                {
                    int pos = seleccion.Index + 1;
                    listViewOdenPreprocesos.Items.RemoveAt(seleccion.Index);
                    listViewOdenPreprocesos.Items.Insert(pos, seleccion);
                }
            }
            listViewOdenPreprocesos.Focus();
        }
    }
}
