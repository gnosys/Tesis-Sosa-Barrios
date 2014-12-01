namespace AppPrincipal.FormsAplicacionDePipe
{
    partial class FormSVMLigth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSVMLigth));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCarpetaDestino = new System.Windows.Forms.TextBox();
            this.buttonSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGenerarModelo = new System.Windows.Forms.Button();
            this.buttonAbrirCarpetaContenedora = new System.Windows.Forms.Button();
            this.buttonVisualizarModelo = new System.Windows.Forms.Button();
            this.buttonVisualizarPrediccion = new System.Windows.Forms.Button();
            this.buttonGenerarPrediccion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelModeloGenerado = new System.Windows.Forms.Label();
            this.richTextBoxTextoModelo = new System.Windows.Forms.RichTextBox();
            this.labelErrorCarpeta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPrediccionesGeneradas = new System.Windows.Forms.Label();
            this.richTextBoxTextoPrediccion = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SVM-LIGTH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(786, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Entrenar SVM, generar MODELO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione la carpeta de destino para guardar los archivos \"modelo\" y \"prediccion" +
    "es\" generados:";
            // 
            // textBoxCarpetaDestino
            // 
            this.textBoxCarpetaDestino.Location = new System.Drawing.Point(192, 147);
            this.textBoxCarpetaDestino.Name = "textBoxCarpetaDestino";
            this.textBoxCarpetaDestino.ReadOnly = true;
            this.textBoxCarpetaDestino.Size = new System.Drawing.Size(371, 20);
            this.textBoxCarpetaDestino.TabIndex = 7;
            // 
            // buttonSeleccionarCarpeta
            // 
            this.buttonSeleccionarCarpeta.Location = new System.Drawing.Point(569, 145);
            this.buttonSeleccionarCarpeta.Name = "buttonSeleccionarCarpeta";
            this.buttonSeleccionarCarpeta.Size = new System.Drawing.Size(113, 23);
            this.buttonSeleccionarCarpeta.TabIndex = 9;
            this.buttonSeleccionarCarpeta.Text = "Seleccionar Carpeta";
            this.buttonSeleccionarCarpeta.UseVisualStyleBackColor = true;
            this.buttonSeleccionarCarpeta.Click += new System.EventHandler(this.buttonSeleccionarCarpetaModelo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ejecutar SVM, generar PREDICCIONES";
            // 
            // buttonGenerarModelo
            // 
            this.buttonGenerarModelo.Location = new System.Drawing.Point(9, 36);
            this.buttonGenerarModelo.Name = "buttonGenerarModelo";
            this.buttonGenerarModelo.Size = new System.Drawing.Size(194, 23);
            this.buttonGenerarModelo.TabIndex = 14;
            this.buttonGenerarModelo.Text = "Generar Modelo";
            this.buttonGenerarModelo.UseVisualStyleBackColor = true;
            this.buttonGenerarModelo.Click += new System.EventHandler(this.buttonGenerarModelo_Click);
            // 
            // buttonAbrirCarpetaContenedora
            // 
            this.buttonAbrirCarpetaContenedora.Enabled = false;
            this.buttonAbrirCarpetaContenedora.Location = new System.Drawing.Point(688, 145);
            this.buttonAbrirCarpetaContenedora.Name = "buttonAbrirCarpetaContenedora";
            this.buttonAbrirCarpetaContenedora.Size = new System.Drawing.Size(145, 23);
            this.buttonAbrirCarpetaContenedora.TabIndex = 16;
            this.buttonAbrirCarpetaContenedora.Text = "Abrir Carpeta Contenedora";
            this.buttonAbrirCarpetaContenedora.UseVisualStyleBackColor = true;
            this.buttonAbrirCarpetaContenedora.Click += new System.EventHandler(this.buttonAbrirCarpetaContenedoraModelo_Click);
            // 
            // buttonVisualizarModelo
            // 
            this.buttonVisualizarModelo.Enabled = false;
            this.buttonVisualizarModelo.Location = new System.Drawing.Point(205, 36);
            this.buttonVisualizarModelo.Name = "buttonVisualizarModelo";
            this.buttonVisualizarModelo.Size = new System.Drawing.Size(194, 23);
            this.buttonVisualizarModelo.TabIndex = 15;
            this.buttonVisualizarModelo.Text = "Visualizar Modelo";
            this.buttonVisualizarModelo.UseVisualStyleBackColor = true;
            this.buttonVisualizarModelo.Click += new System.EventHandler(this.buttonVisualizarModelo_Click);
            // 
            // buttonVisualizarPrediccion
            // 
            this.buttonVisualizarPrediccion.Enabled = false;
            this.buttonVisualizarPrediccion.Location = new System.Drawing.Point(205, 36);
            this.buttonVisualizarPrediccion.Name = "buttonVisualizarPrediccion";
            this.buttonVisualizarPrediccion.Size = new System.Drawing.Size(194, 23);
            this.buttonVisualizarPrediccion.TabIndex = 18;
            this.buttonVisualizarPrediccion.Text = "Visualizar Predicciones";
            this.buttonVisualizarPrediccion.UseVisualStyleBackColor = true;
            this.buttonVisualizarPrediccion.Click += new System.EventHandler(this.buttonVisualizarPrediccion_Click);
            // 
            // buttonGenerarPrediccion
            // 
            this.buttonGenerarPrediccion.Enabled = false;
            this.buttonGenerarPrediccion.Location = new System.Drawing.Point(9, 36);
            this.buttonGenerarPrediccion.Name = "buttonGenerarPrediccion";
            this.buttonGenerarPrediccion.Size = new System.Drawing.Size(194, 23);
            this.buttonGenerarPrediccion.TabIndex = 17;
            this.buttonGenerarPrediccion.Text = "Generar Predicciones";
            this.buttonGenerarPrediccion.UseVisualStyleBackColor = true;
            this.buttonGenerarPrediccion.Click += new System.EventHandler(this.buttonGenerarPrediccion_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelModeloGenerado);
            this.panel1.Controls.Add(this.richTextBoxTextoModelo);
            this.panel1.Controls.Add(this.buttonVisualizarModelo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonGenerarModelo);
            this.panel1.Location = new System.Drawing.Point(186, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 370);
            this.panel1.TabIndex = 20;
            // 
            // labelModeloGenerado
            // 
            this.labelModeloGenerado.AutoSize = true;
            this.labelModeloGenerado.ForeColor = System.Drawing.Color.Green;
            this.labelModeloGenerado.Location = new System.Drawing.Point(307, 13);
            this.labelModeloGenerado.Name = "labelModeloGenerado";
            this.labelModeloGenerado.Size = new System.Drawing.Size(92, 13);
            this.labelModeloGenerado.TabIndex = 19;
            this.labelModeloGenerado.Text = "Modelo Generado";
            this.labelModeloGenerado.Visible = false;
            // 
            // richTextBoxTextoModelo
            // 
            this.richTextBoxTextoModelo.Enabled = false;
            this.richTextBoxTextoModelo.Location = new System.Drawing.Point(9, 65);
            this.richTextBoxTextoModelo.Name = "richTextBoxTextoModelo";
            this.richTextBoxTextoModelo.ReadOnly = true;
            this.richTextBoxTextoModelo.Size = new System.Drawing.Size(390, 295);
            this.richTextBoxTextoModelo.TabIndex = 17;
            this.richTextBoxTextoModelo.Text = "";
            this.richTextBoxTextoModelo.WordWrap = false;
            // 
            // labelErrorCarpeta
            // 
            this.labelErrorCarpeta.AutoSize = true;
            this.labelErrorCarpeta.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCarpeta.Location = new System.Drawing.Point(839, 150);
            this.labelErrorCarpeta.Name = "labelErrorCarpeta";
            this.labelErrorCarpeta.Size = new System.Drawing.Size(150, 13);
            this.labelErrorCarpeta.TabIndex = 18;
            this.labelErrorCarpeta.Text = "Debe seleccionar una carpeta";
            this.labelErrorCarpeta.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelPrediccionesGeneradas);
            this.panel2.Controls.Add(this.richTextBoxTextoPrediccion);
            this.panel2.Controls.Add(this.buttonVisualizarPrediccion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.buttonGenerarPrediccion);
            this.panel2.Location = new System.Drawing.Point(594, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 370);
            this.panel2.TabIndex = 21;
            // 
            // labelPrediccionesGeneradas
            // 
            this.labelPrediccionesGeneradas.AutoSize = true;
            this.labelPrediccionesGeneradas.ForeColor = System.Drawing.Color.Green;
            this.labelPrediccionesGeneradas.Location = new System.Drawing.Point(276, 13);
            this.labelPrediccionesGeneradas.Name = "labelPrediccionesGeneradas";
            this.labelPrediccionesGeneradas.Size = new System.Drawing.Size(123, 13);
            this.labelPrediccionesGeneradas.TabIndex = 20;
            this.labelPrediccionesGeneradas.Text = "Predicciones Generadas";
            this.labelPrediccionesGeneradas.Visible = false;
            // 
            // richTextBoxTextoPrediccion
            // 
            this.richTextBoxTextoPrediccion.Enabled = false;
            this.richTextBoxTextoPrediccion.Location = new System.Drawing.Point(9, 65);
            this.richTextBoxTextoPrediccion.Name = "richTextBoxTextoPrediccion";
            this.richTextBoxTextoPrediccion.ReadOnly = true;
            this.richTextBoxTextoPrediccion.Size = new System.Drawing.Size(390, 295);
            this.richTextBoxTextoPrediccion.TabIndex = 18;
            this.richTextBoxTextoPrediccion.Text = "";
            this.richTextBoxTextoPrediccion.WordWrap = false;
            // 
            // FormSVMLigth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelErrorCarpeta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCarpetaDestino);
            this.Controls.Add(this.buttonAbrirCarpetaContenedora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSeleccionarCarpeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSVMLigth";
            this.Text = "FormSVMLigth";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCarpetaDestino;
        private System.Windows.Forms.Button buttonSeleccionarCarpeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGenerarModelo;
        private System.Windows.Forms.Button buttonAbrirCarpetaContenedora;
        private System.Windows.Forms.Button buttonVisualizarModelo;
        private System.Windows.Forms.Button buttonVisualizarPrediccion;
        private System.Windows.Forms.Button buttonGenerarPrediccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxTextoModelo;
        private System.Windows.Forms.RichTextBox richTextBoxTextoPrediccion;
        private System.Windows.Forms.Label labelErrorCarpeta;
        private System.Windows.Forms.Label labelModeloGenerado;
        private System.Windows.Forms.Label labelPrediccionesGeneradas;
    }
}