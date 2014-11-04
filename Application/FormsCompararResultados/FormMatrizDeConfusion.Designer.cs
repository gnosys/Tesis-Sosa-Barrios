namespace AppPrincipal.FormsCompararResultados
{
    partial class FormMatrizDeConfusion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatrizDeConfusion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonObtenerMatriz = new System.Windows.Forms.Button();
            this.labelObtenerMatriz = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelExactitud = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.buttonCalcularMetricas = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.labelPresicion = new System.Windows.Forms.Label();
            this.dataGridViewMatrizConfusion = new System.Windows.Forms.DataGridView();
            this.labelMetricasCalculadas = new System.Windows.Forms.Label();
            this.buttonExportarAExcel = new System.Windows.Forms.Button();
            this.labelMatrizExportada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizConfusion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATRIZ DE CONFUSION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(790, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // buttonObtenerMatriz
            // 
            this.buttonObtenerMatriz.Location = new System.Drawing.Point(192, 124);
            this.buttonObtenerMatriz.Name = "buttonObtenerMatriz";
            this.buttonObtenerMatriz.Size = new System.Drawing.Size(129, 23);
            this.buttonObtenerMatriz.TabIndex = 2;
            this.buttonObtenerMatriz.Text = "Obtener Matriz";
            this.buttonObtenerMatriz.UseVisualStyleBackColor = true;
            this.buttonObtenerMatriz.Click += new System.EventHandler(this.buttonObtenerMatriz_Click);
            // 
            // labelObtenerMatriz
            // 
            this.labelObtenerMatriz.AutoSize = true;
            this.labelObtenerMatriz.ForeColor = System.Drawing.Color.Green;
            this.labelObtenerMatriz.Location = new System.Drawing.Point(327, 129);
            this.labelObtenerMatriz.Name = "labelObtenerMatriz";
            this.labelObtenerMatriz.Size = new System.Drawing.Size(81, 13);
            this.labelObtenerMatriz.TabIndex = 4;
            this.labelObtenerMatriz.Text = "Matriz Obtenida";
            this.labelObtenerMatriz.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "EXACTITUD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Es la cantidad de predicciones correctas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "La exactitud es de:";
            // 
            // labelExactitud
            // 
            this.labelExactitud.AutoSize = true;
            this.labelExactitud.ForeColor = System.Drawing.Color.Green;
            this.labelExactitud.Location = new System.Drawing.Point(282, 491);
            this.labelExactitud.Name = "labelExactitud";
            this.labelExactitud.Size = new System.Drawing.Size(0, 13);
            this.labelExactitud.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Es la cantidad de predicciones incorrectas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "ERROR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "El error es de:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(505, 490);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(688, 518);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "La presición de la categoría es de:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(688, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Es la cantidad de predicciones correctas por categoría";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(688, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "PRESICION POR CATEGORIA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(688, 493);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Seleccione Categoría:";
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.Enabled = false;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(807, 490);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(129, 21);
            this.comboBoxCategorias.TabIndex = 19;
            // 
            // buttonCalcularMetricas
            // 
            this.buttonCalcularMetricas.Enabled = false;
            this.buttonCalcularMetricas.Location = new System.Drawing.Point(192, 527);
            this.buttonCalcularMetricas.Name = "buttonCalcularMetricas";
            this.buttonCalcularMetricas.Size = new System.Drawing.Size(129, 23);
            this.buttonCalcularMetricas.TabIndex = 20;
            this.buttonCalcularMetricas.Text = "Calcular Métricas";
            this.buttonCalcularMetricas.UseVisualStyleBackColor = true;
            this.buttonCalcularMetricas.Click += new System.EventHandler(this.buttonCalcularMetricas_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(189, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "METRICAS";
            // 
            // labelPresicion
            // 
            this.labelPresicion.AutoSize = true;
            this.labelPresicion.Location = new System.Drawing.Point(856, 518);
            this.labelPresicion.Name = "labelPresicion";
            this.labelPresicion.Size = new System.Drawing.Size(0, 13);
            this.labelPresicion.TabIndex = 22;
            // 
            // dataGridViewMatrizConfusion
            // 
            this.dataGridViewMatrizConfusion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatrizConfusion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMatrizConfusion.Location = new System.Drawing.Point(192, 161);
            this.dataGridViewMatrizConfusion.Name = "dataGridViewMatrizConfusion";
            this.dataGridViewMatrizConfusion.RowTemplate.Height = 20;
            this.dataGridViewMatrizConfusion.Size = new System.Drawing.Size(787, 240);
            this.dataGridViewMatrizConfusion.TabIndex = 0;
            // 
            // labelMetricasCalculadas
            // 
            this.labelMetricasCalculadas.AutoSize = true;
            this.labelMetricasCalculadas.ForeColor = System.Drawing.Color.Green;
            this.labelMetricasCalculadas.Location = new System.Drawing.Point(327, 532);
            this.labelMetricasCalculadas.Name = "labelMetricasCalculadas";
            this.labelMetricasCalculadas.Size = new System.Drawing.Size(102, 13);
            this.labelMetricasCalculadas.TabIndex = 23;
            this.labelMetricasCalculadas.Text = "Métricas Calculadas";
            this.labelMetricasCalculadas.Visible = false;
            // 
            // buttonExportarAExcel
            // 
            this.buttonExportarAExcel.Location = new System.Drawing.Point(682, 124);
            this.buttonExportarAExcel.Name = "buttonExportarAExcel";
            this.buttonExportarAExcel.Size = new System.Drawing.Size(129, 23);
            this.buttonExportarAExcel.TabIndex = 24;
            this.buttonExportarAExcel.Text = "Exportar Matriz a Excel";
            this.buttonExportarAExcel.UseVisualStyleBackColor = true;
            this.buttonExportarAExcel.Click += new System.EventHandler(this.buttonExportarAExcel_Click);
            // 
            // labelMatrizExportada
            // 
            this.labelMatrizExportada.AutoSize = true;
            this.labelMatrizExportada.ForeColor = System.Drawing.Color.Green;
            this.labelMatrizExportada.Location = new System.Drawing.Point(817, 129);
            this.labelMatrizExportada.Name = "labelMatrizExportada";
            this.labelMatrizExportada.Size = new System.Drawing.Size(139, 13);
            this.labelMatrizExportada.TabIndex = 25;
            this.labelMatrizExportada.Text = "Matriz Exportada a un Excel";
            this.labelMatrizExportada.Visible = false;
            // 
            // FormMatrizDeConfusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.labelMatrizExportada);
            this.Controls.Add(this.buttonExportarAExcel);
            this.Controls.Add(this.dataGridViewMatrizConfusion);
            this.Controls.Add(this.labelMetricasCalculadas);
            this.Controls.Add(this.labelPresicion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonCalcularMetricas);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelExactitud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelObtenerMatriz);
            this.Controls.Add(this.buttonObtenerMatriz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMatrizDeConfusion";
            this.Text = "FormMatrizDeConfusion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrizConfusion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonObtenerMatriz;
        private System.Windows.Forms.Label labelObtenerMatriz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelExactitud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.Button buttonCalcularMetricas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPresicion;
        private System.Windows.Forms.DataGridView dataGridViewMatrizConfusion;
        private System.Windows.Forms.Label labelMetricasCalculadas;
        private System.Windows.Forms.Button buttonExportarAExcel;
        private System.Windows.Forms.Label labelMatrizExportada;
    }
}