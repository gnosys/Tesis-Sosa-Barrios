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
    }
}
