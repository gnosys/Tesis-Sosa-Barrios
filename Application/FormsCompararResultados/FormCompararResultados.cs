using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppPrincipal.FormsCompararResultados
{
    public partial class FormCompararResultados : Form
    {
        private float exactitud;
        private float error;

        public FormCompararResultados(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            Init();
        }

        public void Init()
        {
            exactitud = (float)(((App)MdiParent).PipeConfiguration).metrics.exactitude;
            error = (float)(((App)MdiParent).PipeConfiguration).metrics.error;
            
            chartComparaciones.Series["Exactitud"].Points.AddXY(1, exactitud * 100);
            chartComparaciones.Series["Exactitud"].Points[0].Label = (exactitud * 100).ToString() + "%";
            chartComparaciones.Series["Exactitud"].Points[0].AxisLabel = "Actual";
            chartComparaciones.Series["Error"].Points.AddXY(1, error * 100);
            chartComparaciones.Series["Error"].Points[0].Label = (error * 100).ToString() + "%";
        }
        
        private void buttonBuscarPipe_Click(object sender, EventArgs e)
        {
            labelPipeCargado.Hide();
            OpenFileDialog buscarArchivo = new OpenFileDialog();
            buscarArchivo.ShowDialog();
            string directorio = buscarArchivo.FileName;
            textBoxArchivoSeleccionado.Text = directorio;

            if (directorio.EndsWith(".pip"))
            {
                buttonSeleccionarPipe.Enabled = true;
            }
            else
            {
                if (!directorio.Equals(""))
                {
                    DialogResult result = MessageBox.Show("El archivo no tiene un formato valido .pip", "Archivo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool NoExistePipe(string nombrePipe)
        {
            foreach (DataPoint point in chartComparaciones.Series["Exactitud"].Points)
            {
                if (point.AxisLabel.Equals(nombrePipe))
                    return false;
            }
            return true;
        }

        private bool metricasCompletas(dynamic pipeComparativo, ref float exactitudComparativa, ref float errorComparativa)
        {
            try
            {
                exactitudComparativa = (float)(pipeComparativo).metrics.exactitude;
                errorComparativa = (float)(pipeComparativo).metrics.error;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void buttonSeleccionarPipe_Click(object sender, EventArgs e)
        {
            string[] pipeSeleccionado = textBoxArchivoSeleccionado.Text.Split('\\');
            string nombrePipe = pipeSeleccionado[pipeSeleccionado.Length - 1].Replace(".pip", "");
            if (NoExistePipe(nombrePipe))
            {
                dynamic pipeComparativo = JObject.Parse(File.ReadAllText(textBoxArchivoSeleccionado.Text));
                float exactitudComparativa = 0;
                float errorComparativa = 0;
                if (metricasCompletas(pipeComparativo, ref exactitudComparativa, ref errorComparativa))
                {
                    int cantBarras = chartComparaciones.Series["Exactitud"].Points.Count;
                    chartComparaciones.Series["Exactitud"].Points.AddXY(2, exactitudComparativa * 100);
                    chartComparaciones.Series["Exactitud"].Points[cantBarras].Label = (exactitudComparativa * 100).ToString() + "%";
                    chartComparaciones.Series["Exactitud"].Points[cantBarras].AxisLabel = nombrePipe;
                    chartComparaciones.Series["Error"].Points.AddXY(2, errorComparativa * 100);
                    chartComparaciones.Series["Error"].Points[cantBarras].Label = (errorComparativa * 100).ToString() + "%";
                    listBoxPipes.Items.Add(nombrePipe);
                    labelPipeCargado.Show();
                    buttonSeleccionarPipe.Enabled = false;
                    textBoxArchivoSeleccionado.Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("El Pipe seleccionado no contiene las metricas completas", "Pipe Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Un Pipe con el mismo nombre ya ha sido seleccionado", "Pipe Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void buttonEliminarPipe_Click(object sender, EventArgs e)
        {
            if (listBoxPipes.SelectedIndex != -1)
            {
                chartComparaciones.Series["Exactitud"].Points.RemoveAt(listBoxPipes.SelectedIndex + 1);
                chartComparaciones.Series["Error"].Points.RemoveAt(listBoxPipes.SelectedIndex + 1);
                listBoxPipes.Items.RemoveAt(listBoxPipes.SelectedIndex);
            }
        }

    }
}
