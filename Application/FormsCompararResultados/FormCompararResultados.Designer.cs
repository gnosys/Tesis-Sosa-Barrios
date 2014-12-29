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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartComparaciones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxArchivoSeleccionado = new System.Windows.Forms.TextBox();
            this.buttonBuscarPipe = new System.Windows.Forms.Button();
            this.listBoxPipes = new System.Windows.Forms.ListBox();
            this.buttonEliminarPipe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSeleccionarCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxPipe = new System.Windows.Forms.CheckBox();
            this.checkBoxCategoria = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartComparaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // chartComparaciones
            // 
            this.chartComparaciones.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "Pipe";
            chartArea2.Name = "Categoria";
            chartArea2.Visible = false;
            this.chartComparaciones.ChartAreas.Add(chartArea1);
            this.chartComparaciones.ChartAreas.Add(chartArea2);
            legend1.DockedToChartArea = "Pipe";
            legend1.IsDockedInsideChartArea = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Pipe";
            legend2.DockedToChartArea = "Categoria";
            legend2.IsDockedInsideChartArea = false;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Categoria";
            this.chartComparaciones.Legends.Add(legend1);
            this.chartComparaciones.Legends.Add(legend2);
            this.chartComparaciones.Location = new System.Drawing.Point(178, 128);
            this.chartComparaciones.Name = "chartComparaciones";
            series1.ChartArea = "Pipe";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series1.Color = System.Drawing.Color.Green;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series1.Legend = "Pipe";
            series1.Name = "Exactitud de Pipe";
            series2.ChartArea = "Pipe";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series2.Color = System.Drawing.Color.Red;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series2.Legend = "Pipe";
            series2.Name = "Error de Pipe";
            series3.ChartArea = "Categoria";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series3.Color = System.Drawing.Color.Green;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series3.Legend = "Categoria";
            series3.Name = "Exactitud de Categoria";
            series4.ChartArea = "Categoria";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series4.Color = System.Drawing.Color.Red;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series4.Legend = "Categoria";
            series4.Name = "Error de Categoria";
            this.chartComparaciones.Series.Add(series1);
            this.chartComparaciones.Series.Add(series2);
            this.chartComparaciones.Series.Add(series3);
            this.chartComparaciones.Series.Add(series4);
            this.chartComparaciones.Size = new System.Drawing.Size(669, 428);
            this.chartComparaciones.TabIndex = 0;
            this.chartComparaciones.Text = "Comparaciones";
            title1.Name = "TitlePipes";
            title1.Text = "COMPARACION DE EXACTITUD Y ERROR";
            this.chartComparaciones.Titles.Add(title1);
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
            this.textBoxArchivoSeleccionado.Size = new System.Drawing.Size(261, 20);
            this.textBoxArchivoSeleccionado.TabIndex = 10;
            // 
            // buttonBuscarPipe
            // 
            this.buttonBuscarPipe.Location = new System.Drawing.Point(733, 96);
            this.buttonBuscarPipe.Name = "buttonBuscarPipe";
            this.buttonBuscarPipe.Size = new System.Drawing.Size(95, 23);
            this.buttonBuscarPipe.TabIndex = 11;
            this.buttonBuscarPipe.Text = "Seleccionar Pipe";
            this.buttonBuscarPipe.UseVisualStyleBackColor = true;
            this.buttonBuscarPipe.Click += new System.EventHandler(this.buttonBuscarPipe_Click);
            // 
            // listBoxPipes
            // 
            this.listBoxPipes.FormattingEnabled = true;
            this.listBoxPipes.Location = new System.Drawing.Point(844, 210);
            this.listBoxPipes.Name = "listBoxPipes";
            this.listBoxPipes.Size = new System.Drawing.Size(120, 147);
            this.listBoxPipes.TabIndex = 21;
            // 
            // buttonEliminarPipe
            // 
            this.buttonEliminarPipe.Location = new System.Drawing.Point(844, 363);
            this.buttonEliminarPipe.Name = "buttonEliminarPipe";
            this.buttonEliminarPipe.Size = new System.Drawing.Size(120, 23);
            this.buttonEliminarPipe.TabIndex = 22;
            this.buttonEliminarPipe.Text = "Eliminar Pipe";
            this.buttonEliminarPipe.UseVisualStyleBackColor = true;
            this.buttonEliminarPipe.Click += new System.EventHandler(this.buttonEliminarPipe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(841, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Pipes Elegidos";
            // 
            // comboBoxSeleccionarCategoria
            // 
            this.comboBoxSeleccionarCategoria.FormattingEnabled = true;
            this.comboBoxSeleccionarCategoria.Location = new System.Drawing.Point(844, 417);
            this.comboBoxSeleccionarCategoria.Name = "comboBoxSeleccionarCategoria";
            this.comboBoxSeleccionarCategoria.Size = new System.Drawing.Size(120, 21);
            this.comboBoxSeleccionarCategoria.TabIndex = 24;
            this.comboBoxSeleccionarCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeleccionarCategoria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(844, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Selecionar Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(841, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Selecionar Comparaciones";
            // 
            // checkBoxPipe
            // 
            this.checkBoxPipe.AutoSize = true;
            this.checkBoxPipe.Checked = true;
            this.checkBoxPipe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPipe.Location = new System.Drawing.Point(844, 127);
            this.checkBoxPipe.Name = "checkBoxPipe";
            this.checkBoxPipe.Size = new System.Drawing.Size(52, 17);
            this.checkBoxPipe.TabIndex = 28;
            this.checkBoxPipe.Text = "Pipes";
            this.checkBoxPipe.UseVisualStyleBackColor = true;
            this.checkBoxPipe.CheckedChanged += new System.EventHandler(this.checkBoxPipe_CheckedChanged);
            // 
            // checkBoxCategoria
            // 
            this.checkBoxCategoria.AutoSize = true;
            this.checkBoxCategoria.Location = new System.Drawing.Point(844, 151);
            this.checkBoxCategoria.Name = "checkBoxCategoria";
            this.checkBoxCategoria.Size = new System.Drawing.Size(76, 17);
            this.checkBoxCategoria.TabIndex = 29;
            this.checkBoxCategoria.Text = "Categorias";
            this.checkBoxCategoria.UseVisualStyleBackColor = true;
            this.checkBoxCategoria.CheckedChanged += new System.EventHandler(this.checkBoxCategoria_CheckedChanged);
            // 
            // FormCompararResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.checkBoxCategoria);
            this.Controls.Add(this.checkBoxPipe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSeleccionarCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEliminarPipe);
            this.Controls.Add(this.listBoxPipes);
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
        private System.Windows.Forms.ListBox listBoxPipes;
        private System.Windows.Forms.Button buttonEliminarPipe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSeleccionarCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxPipe;
        private System.Windows.Forms.CheckBox checkBoxCategoria;
    }
}