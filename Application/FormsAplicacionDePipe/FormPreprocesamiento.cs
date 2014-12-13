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
using Newtonsoft.Json.Linq;
using Tonkenizer.Filters;
using Tonkenizer.Filters.AroundFilters;
using System.Text.RegularExpressions;
using Tonkenizer.Filters.PreFilters;
using Tonkenizer.Core;
using System.IO;

namespace AppPrincipal
{
    public partial class FormPreprocesamiento : Form
    {
        bool cambiarTabs = false;

        public FormPreprocesamiento(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        private void acomodarFiltros(JArray preprocessingFiltersConfiguration)
        {
            ListViewItem seleccion;
            string nombreFiltro = String.Empty;

            foreach (var filter in preprocessingFiltersConfiguration)
            {
                switch ((string)filter["_type"])
                {
                    case "richment": { nombreFiltro = "Enriquecimiento"; break; }
                    case "words": { nombreFiltro = "Tratamiento en Texto"; break; }
                    case "tokenizing": { nombreFiltro = "Tokenization"; break; }
                    case "stemming": { nombreFiltro = "Stemmer"; break; }
                    case "stopWords": { nombreFiltro = "Stop Words"; break; }
                }

                if (nombreFiltro.Equals("Tokenization"))
                {
                    textBoxExpresionRegular.Text = (string)filter["regexp"] ?? "";
                    checkBoxERPorDefecto.Checked = (bool)filter["byDefault"];
                }
                else
                {
                    seleccion = listViewPreprocesamientos.FindItemWithText(nombreFiltro);
                    listViewPreprocesamientos.Items.Remove(seleccion);

                    if (nombreFiltro.Equals("Enriquecimiento"))
                    {
                        checkBoxKeywords.Checked = (bool)filter["keywords"];
                        checkBoxTitulo.Checked = (bool)filter["title"];
                        checkBoxDescripcion.Checked = (bool)filter["description"];
                    }
                    else if (nombreFiltro.Equals("Tratamiento en Texto"))
                    {
                        checkBoxReemplazarAbreviatura.Checked = (bool)filter["replaceAbbreviations"];
                        textBoxDireccionAbreviaturas.Text = (string)filter["filename"] ?? "";
                        checkBoxListaAbreviaturasPorDefecto.Checked = (bool)filter["byDefault"];
                        checkBoxEliminarLinks.Checked = (bool)filter["removeLinks"];
                    }
                    else if (nombreFiltro.Equals("Stop Words"))
                    {
                        textBoxDireccionStopWords.Text = (string)filter["filename"] ?? "";
                        checkBoxListaStopWordsPorDefecto.Checked = (bool)filter["byDefault"];
                    }

                    ubicarSeleccion(seleccion);
                }
            }
        }

        public void EnriquecerTweets()
        {
            AddLinkContextPreFilter filter = new AddLinkContextPreFilter(null)
            {
                Description = true,
                Keywords = true,
                Title = true
            };

            List<Tweet> tweets = DataBase.Instance.GetAllTweetsForEnrich();
            List<string> textosEnriquecidos = filter.Filter(tweets.Select(x => x.Text).ToList());
            for(int i = 0; i < tweets.Count; i++)
            {
                tweets[i].TextEnrich = textosEnriquecidos[i]; 
            }
            DataBase.Instance.UpdateTweetsEnrich(tweets);
        }

        public void Init()
        {
            JArray preprocessingFiltersConfiguration = ((App)this.MdiParent).PipeConfiguration.preprocessing.filters;

            acomodarFiltros(preprocessingFiltersConfiguration);

            if (!String.IsNullOrEmpty((string)(((App)MdiParent).PipeConfiguration.preprocessing.guid)) && DataBase.Instance.ExistTokens((string)(((App)MdiParent).PipeConfiguration.preprocessing.guid)))
            {
                labelPreprocesadoAplicado.Show();
                ((App)MdiParent).ActivarBotonRepresentacion();
            }
        }

        public void Clean()
        {
            foreach (ListViewItem item in listViewOrdenPreprocesos.Items)
            {
                if (item.Text != "Tokenization")
                {
                    listViewOrdenPreprocesos.Items.Remove(item);
                    listViewPreprocesamientos.Items.Add(item);
                }
            }
            labelPreprocesadoAplicado.Hide();
            labelEnriquecimientoAplicado.Hide();
            labelExpresionRegularAplicada.Hide();
            labelTratamientoAplicado.Hide();
            labelListaAplicadaStopWords.Hide();
            ((App)MdiParent).DesactivarBotonRepresentacion();
        }

        public PreFilter BuildPrefilter(JArray preprocessingFiltersConfiguration, int i = 0)
        {
            if (i == preprocessingFiltersConfiguration.Count) return null;

            PreFilter ret = GetConfiguredPrefilter(preprocessingFiltersConfiguration.ElementAt(i));
            if (ret != null)
            {
                ret.Next = BuildPrefilter(preprocessingFiltersConfiguration, i + 1);
            }
            else
            {
                ret = BuildPrefilter(preprocessingFiltersConfiguration, i + 1);
            }
            return ret;
        }

        private PreFilter GetConfiguredPrefilter(JToken jToken)
        {
            switch ((string)jToken["_type"])
            {
                case "richment": return null;
                //return new AddLinkContextPreFilter(null)
                //{
                //    Description = (bool)jToken["description"],
                //    Title = (bool)jToken["title"],
                //    Keywords = (bool)jToken["keywords"]
                //};
                case "words": return new OnlyWordsPreFilter(null, (bool)jToken["removeLinks"], (bool)jToken["replaceAbbreviations"], (bool)jToken["byDefault"], (string)jToken["filename"]);
                default: return null;
            }
        }


        public AroundFilter BuildAroundfilter(JArray preprocessingFiltersConfiguration, int i = 0)
        {
            if (i == preprocessingFiltersConfiguration.Count) return null;

            AroundFilter ret = GetConfiguredAroundfilter(preprocessingFiltersConfiguration.ElementAt(i));
            if (ret != null)
            {
                ret.Next = BuildAroundfilter(preprocessingFiltersConfiguration, i + 1);
            }
            else
            {
                ret = BuildAroundfilter(preprocessingFiltersConfiguration, i + 1);
            }
            return ret;
        }

        private AroundFilter GetConfiguredAroundfilter(JToken jToken)
        {
            switch ((string)jToken["_type"])
            {
                case "stopWords": return new StopWordFilter(null, (bool)jToken["byDefault"], (string)jToken["filename"]);
                case "stemming": return new StemmingFilter(null);
                default: return null;
            }
        }

        private void buttonPreprocesar_Click(object sender, EventArgs e)
        {
            labelPreprocesadoAplicado.Hide();
            ((App)this.MdiParent).limpiarFormSinRepresentacion();
            JArray preprocessingFiltersConfiguration = ((App)this.MdiParent).PipeConfiguration.preprocessing.filters;
            PreFilter preFilter = null;
            AroundFilter aroundFilter = null;
            Regex delimiter = null;
            ITokenizer tokenizer = null;

            int categoryLevel = (int)((App)this.MdiParent).PipeConfiguration.categoryLevel;
            List<Tweet> tweets = DataBase.Instance.GetTweetsForClassify(categoryLevel);
            
            
            dynamic tokenizingConfiguration = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "tokenizing");
            if ((bool)tokenizingConfiguration.byDefault)
            {
                delimiter = new Regex((string)tokenizingConfiguration.regexpByDefault);
            }
            else
            {
                delimiter = new Regex((string)tokenizingConfiguration.regexp);
            }

            preFilter = BuildPrefilter(preprocessingFiltersConfiguration);

            List<string> docs = new List<string>();
            if (preprocessingFiltersConfiguration.Any(x => (string)x["_type"] == "richment"))
            {
                bool missingEnrich = tweets.Any(x => String.IsNullOrEmpty(x.TextEnrich));
                if (missingEnrich)
                {
                    DialogResult result = MessageBox.Show("Para preprocesar debe aplicar el filtro de enriquecimiento", "Configuracion faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                docs = tweets.Select(x => x.TextEnrich).ToList();
            }
            else
            {
                docs = tweets.Select(x => x.Text).ToList();
            }


            aroundFilter = BuildAroundfilter(preprocessingFiltersConfiguration);

            ////preprocessing
            tokenizer = new Tokenizer(delimiter, preFilter, aroundFilter);
            List<string[]> TFIDFInput = tokenizer.Tokenize(docs).ToList();

            string preprocessingGuid = DataBase.Instance.SavePreprocessingTokens(tweets, TFIDFInput);
            ((App)this.MdiParent).PipeConfiguration.preprocessing.guid = preprocessingGuid;
            ((App)this.MdiParent).ActivarBotonRepresentacion();
            labelPreprocesadoAplicado.Show();
        }
        
        private void agregarFiltroAlPipe(ListViewItem seleccion)
        {
            JArray preprocessingFiltersConfiguration = ((App)this.MdiParent).PipeConfiguration.preprocessing.filters;
            
            if (seleccion.Text.Equals("Stemmer"))
            {
                var nuevoJson = JObject.Parse(@"{ ""_type"" : ""stemming"" }");
                var nuevoJtokenFiltro = nuevoJson as JToken;
                preprocessingFiltersConfiguration.Add(nuevoJtokenFiltro);
            }
            else if (seleccion.Text.Equals("Stop Words"))
            {
                var nuevoJson = JObject.Parse(@"{ ""_type"" : ""stopWords"", ""filename"" : null, ""byDefault"" : true }");
                var nuevoJtokenFiltro = nuevoJson as JToken;
                preprocessingFiltersConfiguration.Add(nuevoJtokenFiltro);
            }
            else
            {
                char[] delimitadores = new char[] { '[', ']' };
                int indexTokenizing = int.Parse(preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "tokenizing").Path.Split(delimitadores)[1]);

                if (seleccion.Text.Equals("Enriquecimiento"))
                {
                    var nuevoJson = JObject.Parse(@"{ ""_type"" : ""richment"", ""keywords"" : true, ""title"" : true, ""description"" : true }");
                    var nuevoJtokenFiltro = nuevoJson as JToken;
                    preprocessingFiltersConfiguration[indexTokenizing].AddBeforeSelf(nuevoJtokenFiltro);
                }
                else if (seleccion.Text.Equals("Tratamiento en Texto"))
                {
                    var nuevoJson = JObject.Parse(@"{ ""_type"" : ""words"", ""replaceAbbreviations"" : true, ""filename"" : null, ""byDefault"" : true, ""removeLinks"" : false }");
                    var nuevoJtokenFiltro = nuevoJson as JToken;
                    preprocessingFiltersConfiguration[indexTokenizing].AddBeforeSelf(nuevoJtokenFiltro);
                }
            }
        }

        private void ubicarSeleccion(ListViewItem seleccion)
        {
            if (seleccion.Text == "Enriquecimiento" || seleccion.Text == "Tratamiento en Texto")
            {
                int indexTokenization = listViewOrdenPreprocesos.FindItemWithText("Tokenization").Index;
                listViewOrdenPreprocesos.Items.Insert(indexTokenization, seleccion);
            }
            else if (seleccion.Text == "Stemmer" || seleccion.Text == "Stop Words")
            {
                listViewOrdenPreprocesos.Items.Add(seleccion);
            }
            listViewOrdenPreprocesos.Focus();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            labelPreprocesadoAplicado.Hide();
            if (listViewPreprocesamientos.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listViewPreprocesamientos.SelectedItems[0];
                listViewPreprocesamientos.SelectedItems[0].Remove();
                ubicarSeleccion(seleccion);
                agregarFiltroAlPipe(seleccion);
            }
        }

        private void borrarFiltroAlPipe(ListViewItem seleccion)
        {
            JArray preprocessingFiltersConfiguration = ((App)this.MdiParent).PipeConfiguration.preprocessing.filters;

            if (seleccion.Text.Equals("Stemmer"))
            {
                preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "stemming").Remove();
            }
            else if (seleccion.Text.Equals("Stop Words"))
            {
                preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "stopWords").Remove();
            }
            else if (seleccion.Text.Equals("Enriquecimiento"))
            {
                preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "richment").Remove();
            }
            else if (seleccion.Text.Equals("Tratamiento en Texto"))
            {
                preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "words").Remove();
            }
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            labelPreprocesadoAplicado.Hide();
            if (listViewOrdenPreprocesos.SelectedItems.Count > 0 && !listViewOrdenPreprocesos.SelectedItems[0].Text.Equals("Tokenization"))
            {
                ListViewItem seleccion = listViewOrdenPreprocesos.SelectedItems[0];
                listViewOrdenPreprocesos.SelectedItems[0].Remove();
                listViewPreprocesamientos.Items.Add(seleccion);
                listViewPreprocesamientos.Focus();
                tabControlConfiguraciones.Hide();
                borrarFiltroAlPipe(seleccion);
            }
        }

        private void buttonSubir_Click(object sender, EventArgs e)
        {
            labelPreprocesadoAplicado.Hide();
            JArray preprocessingFiltersConfiguration = ((App)this.MdiParent).PipeConfiguration.preprocessing.filters;
            JToken filtro;

            if (listViewOrdenPreprocesos.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listViewOrdenPreprocesos.SelectedItems[0];
                if (seleccion.Text == "Enriquecimiento" || seleccion.Text == "Tratamiento en Texto")
                {
                    if (seleccion.Index > 0)
                    {
                        int pos = seleccion.Index - 1;
                        listViewOrdenPreprocesos.Items.RemoveAt(seleccion.Index);
                        listViewOrdenPreprocesos.Items.Insert(pos, seleccion);
                        if (seleccion.Text == "Enriquecimiento")
                        {
                            filtro = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "richment");
                            preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "richment").Remove();
                        }
                        else
                        {
                            filtro = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "words");
                            preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "words").Remove();
                        }
                        preprocessingFiltersConfiguration[0].AddBeforeSelf(filtro);
                    }
                }
                else if (seleccion.Text == "Stemmer" || seleccion.Text == "Stop Words")
                {
                    int indexTokenization = listViewOrdenPreprocesos.FindItemWithText("Tokenization").Index;

                    if (seleccion.Index > 0 && seleccion.Index > indexTokenization + 1)
                    {
                        int pos = seleccion.Index - 1;
                        listViewOrdenPreprocesos.Items.RemoveAt(seleccion.Index);
                        listViewOrdenPreprocesos.Items.Insert(pos, seleccion);
                        if (seleccion.Text == "Stemmer")
                        {
                            filtro = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "stemming");
                            preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "stemming").Remove();
                        }
                        else
                        {
                            filtro = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "stopWords");
                            preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "stopWords").Remove();
                        }
                        preprocessingFiltersConfiguration[indexTokenization].AddAfterSelf(filtro);
                    }
                }
            }
            listViewOrdenPreprocesos.Focus();
        }

        private void buttonBajar_Click(object sender, EventArgs e)
        {
            labelPreprocesadoAplicado.Hide();
            JArray preprocessingFiltersConfiguration = ((App)this.MdiParent).PipeConfiguration.preprocessing.filters;
            JToken filtro;

            if (listViewOrdenPreprocesos.SelectedItems.Count > 0)
            {
                ListViewItem seleccion = listViewOrdenPreprocesos.SelectedItems[0];
                if (seleccion.Text == "Enriquecimiento" || seleccion.Text == "Tratamiento en Texto")
                {
                    int indexTokenization = listViewOrdenPreprocesos.FindItemWithText("Tokenization").Index;
                    if (seleccion.Index < (listViewOrdenPreprocesos.Items.Count - 1) && seleccion.Index + 1 < indexTokenization)
                    {
                        int pos = seleccion.Index + 1;
                        listViewOrdenPreprocesos.Items.RemoveAt(seleccion.Index);
                        listViewOrdenPreprocesos.Items.Insert(pos, seleccion);
                        if (seleccion.Text == "Enriquecimiento")
                        {
                            filtro = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "richment");
                            preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "richment").Remove();
                        }
                        else
                        {
                            filtro = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "words");
                            preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "words").Remove();
                        }
                        preprocessingFiltersConfiguration[indexTokenization - 1].AddBeforeSelf(filtro);
                    }
                }
                else if (seleccion.Text == "Stemmer" || seleccion.Text == "Stop Words")
                {
                    if (seleccion.Index < (listViewOrdenPreprocesos.Items.Count - 1))
                    {
                        int pos = seleccion.Index + 1;
                        listViewOrdenPreprocesos.Items.RemoveAt(seleccion.Index);
                        listViewOrdenPreprocesos.Items.Insert(pos, seleccion);
                        if (seleccion.Text == "Stemmer")
                        {
                            filtro = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "stemming");
                            preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "stemming").Remove();
                        }
                        else
                        {
                            filtro = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "stopWords");
                            preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "stopWords").Remove();
                        }
                        preprocessingFiltersConfiguration.Add(filtro);
                    }
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
                else if (seleccion.Text.Equals("Tokenization"))
                {
                    tabControlConfiguraciones.SelectTab(2);
                }
                else if (seleccion.Text.Equals("Enriquecimiento"))
                {
                    tabControlConfiguraciones.SelectTab(3);
                }
                else if (seleccion.Text.Equals("Tratamiento en Texto"))
                {
                    tabControlConfiguraciones.SelectTab(4);
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
            labelListaAplicadaStopWords.Hide();

            if (checkBoxListaStopWordsPorDefecto.Checked)
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
            labelPreprocesadoAplicado.Hide();
            if (!cambiarTabs)
                e.Cancel = true;
        }

        private void listViewOrdenPreprocesos_Click(object sender, EventArgs e)
        {
            manejoConfiguraciones();
        }

        private void buttonBuscarListStopWords_Click(object sender, EventArgs e)
        {
            labelListaAplicadaStopWords.Hide();
            OpenFileDialog buscarArchivo = new OpenFileDialog();
            buscarArchivo.ShowDialog();
            string directorio = buscarArchivo.FileName;
            textBoxDireccionStopWords.Text = directorio;

            if (!directorio.EndsWith(".txt"))
            {
                textBoxDireccionStopWords.Clear();
                DialogResult result = MessageBox.Show("El archivo no tiene un formato valido .txt", "Archivo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxReemplazarAbreviatura_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReemplazarAbreviatura.Checked)
            {
                checkBoxListaAbreviaturasPorDefecto.Enabled = true;
                buttonBuscarListaAbreviatura.Enabled = true;
                textBoxDireccionAbreviaturas.Enabled = true;
            }
            else
            {
                checkBoxListaAbreviaturasPorDefecto.Enabled = false;
                buttonBuscarListaAbreviatura.Enabled = false;
                textBoxDireccionAbreviaturas.Enabled = false;
            }
            if (checkBoxListaAbreviaturasPorDefecto.Checked)
            {
                buttonBuscarListaAbreviatura.Enabled = false;
                textBoxDireccionAbreviaturas.Enabled = false;
            }
        }

        private void checkBoxListaAbreviaturasDefecto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxListaAbreviaturasPorDefecto.Checked)
            {
                buttonBuscarListaAbreviatura.Enabled = false;
                textBoxDireccionAbreviaturas.Enabled = false;
            }
            else
            {
                buttonBuscarListaAbreviatura.Enabled = true;
                textBoxDireccionAbreviaturas.Enabled = true;
            }
        }

        private void buttonBuscarListaAbreviatura_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarArchivo = new OpenFileDialog();
            buscarArchivo.ShowDialog();
            string directorio = buscarArchivo.FileName;
            textBoxDireccionAbreviaturas.Text = directorio;

            if (!directorio.EndsWith(".txt"))
            {
                textBoxDireccionAbreviaturas.Clear();
                DialogResult result = MessageBox.Show("El archivo no tiene un formato valido .txt", "Archivo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAplicarListaStopWords_Click(object sender, EventArgs e)
        {
            ((App)this.MdiParent).limpiarFormSinRepresentacion();
            JArray preprocessingFiltersConfiguration = ((App)this.MdiParent).PipeConfiguration.preprocessing.filters;
            dynamic stopWordsConfiguration = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "stopWords");

            stopWordsConfiguration.byDefault = checkBoxListaStopWordsPorDefecto.Checked;
            if (!checkBoxListaStopWordsPorDefecto.Checked)
                stopWordsConfiguration.filename = textBoxDireccionStopWords.Text;

            labelListaAplicadaStopWords.Show();
        }

        private void buttonAplicarExpresionRegular_Click(object sender, EventArgs e)
        {
            ((App)this.MdiParent).limpiarFormSinRepresentacion();
            JArray preprocessingFiltersConfiguration = ((App)this.MdiParent).PipeConfiguration.preprocessing.filters;
            dynamic tokenizingConfiguration = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "tokenizing");

            tokenizingConfiguration.byDefault = checkBoxERPorDefecto.Checked;
            if (!checkBoxERPorDefecto.Checked)
                tokenizingConfiguration.regexp = textBoxExpresionRegular.Text;

            labelExpresionRegularAplicada.Show();
        }

        private void buttonAplicarEnriquecimiento_Click(object sender, EventArgs e)
        {
            EnriquecerTweets();
            
            ((App)this.MdiParent).limpiarFormSinRepresentacion();
            JArray preprocessingFiltersConfiguration = ((App)this.MdiParent).PipeConfiguration.preprocessing.filters;
            dynamic richmentConfiguration = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "richment");

            richmentConfiguration.keywords = checkBoxKeywords.Checked;
            richmentConfiguration.title = checkBoxTitulo.Checked;
            richmentConfiguration.description = checkBoxDescripcion.Checked;

            labelEnriquecimientoAplicado.Show();
        }

        private void buttonAplicarTratamiento_Click(object sender, EventArgs e)
        {
            ((App)this.MdiParent).limpiarFormSinRepresentacion();
            JArray preprocessingFiltersConfiguration = ((App)this.MdiParent).PipeConfiguration.preprocessing.filters;
            dynamic wordsConfiguration = preprocessingFiltersConfiguration.First(x => (string)x["_type"] == "words");

            if (checkBoxReemplazarAbreviatura.Checked)
            {
                wordsConfiguration.replaceAbbreviations = checkBoxReemplazarAbreviatura.Checked;
                wordsConfiguration.byDefault = checkBoxListaAbreviaturasPorDefecto.Checked;
                if (!checkBoxListaAbreviaturasPorDefecto.Checked)
                    wordsConfiguration.filename = textBoxDireccionAbreviaturas.Text;
            }
            wordsConfiguration.removeLinks = checkBoxEliminarLinks.Checked;

            labelTratamientoAplicado.Show();
        }

        private void textBoxExpresionRegular_TextChanged(object sender, EventArgs e)
        {
            labelExpresionRegularAplicada.Hide();
        }

        private void checkBoxERPorDefecto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxERPorDefecto.Checked)
                textBoxExpresionRegular.Enabled = false;
            else
                textBoxExpresionRegular.Enabled = true;
        }

    }
}