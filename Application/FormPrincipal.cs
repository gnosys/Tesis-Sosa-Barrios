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
        }

        private void buttonPreprocesamiento_Click(object sender, System.EventArgs e)
        {
            FormPreprocesamiento formPreprocesamiento = new FormPreprocesamiento();
            formPreprocesamiento.TopLevel = false;
           this.Controls.Add(formPreprocesamiento);
           formPreprocesamiento.Show();

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

        private static void CreateVSMFile(float[][] weights, int docs)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"VSM.txt"))
            {
                for (int i = 0; i < docs; i++)
                {
                    StringBuilder builder = new StringBuilder();
                    for (int j = 0; j < weights.Length; j++)
                    {
                        if (weights[j][i] > 0)
                        {
                            builder.AppendFormat("{0}:{1} ", j + 1, weights[j][i]);
                        }
                    }
                    file.WriteLine(builder.ToString());
                }
            }
        }

        private static void CreateBOWFile(string[] words)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"BOW.txt"))
            {
                foreach (string line in words)
                {
                    file.WriteLine(line);
                }
            }
        }

        private void buttonDataBase_Click(object sender, System.EventArgs e)
        {
            formDataBaseYSeleccionarCategoria.ocultarPanelSeleccionarCategoria();
            formDataBaseYSeleccionarCategoria.Show();
        }

        private void buttonSeleccionarCategoria_Click(object sender, System.EventArgs e)
        {
            formDataBaseYSeleccionarCategoria.mostrarPanelSeleccionarCategoria();
            formDataBaseYSeleccionarCategoria.Show();
        }

    }
}
