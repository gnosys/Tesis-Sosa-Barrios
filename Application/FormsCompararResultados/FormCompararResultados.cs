using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal.FormsCompararResultados
{
    public partial class FormCompararResultados : Form
    {
        public FormCompararResultados()
        {
            InitializeComponent();
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
                if (true)
                {
                    buttonSeleccionarPipe.Enabled = true;
                }
                else
                {
                    DialogResult result = MessageBox.Show("El Pipe seleccionado no contiene las metricas completas", "Pipe Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("El archivo no tiene un formato valido .pip", "Archivo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSeleccionarPipe_Click(object sender, EventArgs e)
        {
            //CODIGO QUE CARGA LOS DATOS EN EL GRAFICO
            labelPipeCargado.Show();
            buttonSeleccionarPipe.Enabled = false;
            textBoxArchivoSeleccionado.Clear();
        }

    }
}
