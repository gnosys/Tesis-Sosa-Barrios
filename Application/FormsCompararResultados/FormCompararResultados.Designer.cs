namespace AppPrincipal.FormsCompararResultados
{
    partial class FormCompararResultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartComparaciones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxArchivoSeleccionado = new System.Windows.Forms.TextBox();
            this.buttonBuscarPipe = new System.Windows.Forms.Button();
            this.buttonSeleccionarPipe = new System.Windows.Forms.Button();
            this.labelPipeCargado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartComparaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // chartComparaciones
            // 
            this.chartComparaciones.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartComparaciones.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartComparaciones.Legends.Add(legend1);
            this.chartComparaciones.Location = new System.Drawing.Point(178, 146);
            this.chartComparaciones.Name = "chartComparaciones";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.chartComparaciones.Series.Add(series1);
            this.chartComparaciones.Series.Add(series2);
            this.chartComparaciones.Series.Add(series3);
            this.chartComparaciones.Size = new System.Drawing.Size(813, 410);
            this.chartComparaciones.TabIndex = 0;
            this.chartComparaciones.Text = "Comparaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMPARACION DE LOS RESULTADOS OBTENIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "En el siguiente cuadro se compararan los resultados obtenidos en los diferentes p" +
    "ipes creados.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione Pipes con resultados completos a comparar:";
            // 
            // textBoxArchivoSeleccionado
            // 
            this.textBoxArchivoSeleccionado.Location = new System.Drawing.Point(466, 98);
            this.textBoxArchivoSeleccionado.Name = "textBoxArchivoSeleccionado";
            this.textBoxArchivoSeleccionado.ReadOnly = true;
            this.textBoxArchivoSeleccionado.Size = new System.Drawing.Size(270, 20);
            this.textBoxArchivoSeleccionado.TabIndex = 10;
            // 
            // buttonBuscarPipe
            // 
            this.buttonBuscarPipe.Location = new System.Drawing.Point(742, 96);
            this.buttonBuscarPipe.Name = "buttonBuscarPipe";
            this.buttonBuscarPipe.Size = new System.Drawing.Size(72, 23);
            this.buttonBuscarPipe.TabIndex = 11;
            this.buttonBuscarPipe.Text = "Buscar Pipe";
            this.buttonBuscarPipe.UseVisualStyleBackColor = true;
            this.buttonBuscarPipe.Click += new System.EventHandler(this.buttonBuscarPipe_Click);
            // 
            // buttonSeleccionarPipe
            // 
            this.buttonSeleccionarPipe.Enabled = false;
            this.buttonSeleccionarPipe.Location = new System.Drawing.Point(820, 96);
            this.buttonSeleccionarPipe.Name = "buttonSeleccionarPipe";
            this.buttonSeleccionarPipe.Size = new System.Drawing.Size(153, 23);
            this.buttonSeleccionarPipe.TabIndex = 12;
            this.buttonSeleccionarPipe.Text = "Seleccionar Pipe Encontrado";
            this.buttonSeleccionarPipe.UseVisualStyleBackColor = true;
            this.buttonSeleccionarPipe.Click += new System.EventHandler(this.buttonSeleccionarPipe_Click);
            // 
            // labelPipeCargado
            // 
            this.labelPipeCargado.AutoSize = true;
            this.labelPipeCargado.ForeColor = System.Drawing.Color.Green;
            this.labelPipeCargado.Location = new System.Drawing.Point(830, 124);
            this.labelPipeCargado.Name = "labelPipeCargado";
            this.labelPipeCargado.Size = new System.Drawing.Size(134, 13);
            this.labelPipeCargado.TabIndex = 20;
            this.labelPipeCargado.Text = "Pipe Cargado en el Gráfico";
            this.labelPipeCargado.Visible = false;
            // 
            // FormCompararResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.labelPipeCargado);
            this.Controls.Add(this.buttonSeleccionarPipe);
            this.Controls.Add(this.textBoxArchivoSeleccionado);
            this.Controls.Add(this.buttonBuscarPipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartComparaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompararResultados";
            this.Text = "FormCompararResultados";
            ((System.ComponentModel.ISupportInitialize)(this.chartComparaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartComparaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxArchivoSeleccionado;
        private System.Windows.Forms.Button buttonBuscarPipe;
        private System.Windows.Forms.Button buttonSeleccionarPipe;
        private System.Windows.Forms.Label labelPipeCargado;
    }
}