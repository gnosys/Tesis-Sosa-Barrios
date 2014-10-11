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
using TFIDFWeighting;

namespace AppPrincipal.FormsAplicacionDePipe
{
    public partial class FormRepresentacion : Form
    {
        public FormRepresentacion()
        {
            InitializeComponent();
        }

        private void buttonObtenerRepresentacion_Click(object sender, EventArgs e)
        {
            IRepresentation representation = new Representation();
            List<Tweet> tweets = DataBase.Instance.GetTweetsForClassify((int)(((App)this.MdiParent).PipeConfiguration.categoryLevel));
            List<string[]> tokens = DataBase.Instance.GetTokens((string)(((App)this.MdiParent).PipeConfiguration.preprocessing.guid));
            representation.CreateRepresentationFile(tokens, tokens.Count, tweets.Select(t => t.Id_Category).ToArray(), @"VSM.txt");
        }
    }
}
