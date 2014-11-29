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
            this.textBoxCarpetaDestinoModelo = new System.Windows.Forms.TextBox();
            this.buttonSeleccionarCarpetaModelo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSeleccionarCarpetaPrediccion = new System.Windows.Forms.Button();
            this.textBoxCarpetaDestinoPrediccion = new System.Windows.Forms.TextBox();
            this.buttonGenerarModelo = new System.Windows.Forms.Button();
            this.buttonAbrirCarpetaContenedoraModelo = new System.Windows.Forms.Button();
            this.buttonVisualizarModelo = new System.Windows.Forms.Button();
            this.buttonAbrirCarpetaContenedoraPrediccion = new System.Windows.Forms.Button();
            this.buttonVisualizarPrediccion = new System.Windows.Forms.Button();
            this.buttonGenerarPrediccion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelModeloGenerado = new System.Windows.Forms.Label();
            this.labelErrorCarpetaModelo = new System.Windows.Forms.Label();
            this.richTextBoxTextoModelo = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPrediccionesGeneradas = new System.Windows.Forms.Label();
            this.labelErrorCarpetaPrediccion = new System.Windows.Forms.Label();
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
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione la carpeta de destino para guardar el archivo \"modelo\" generado:";
            // 
            // textBoxCarpetaDestinoModelo
            // 
            this.textBoxCarpetaDestinoModelo.Location = new System.Drawing.Point(10, 63);
            this.textBoxCarpetaDestinoModelo.Name = "textBoxCarpetaDestinoModelo";
            this.textBoxCarpetaDestinoModelo.ReadOnly = true;
            this.textBoxCarpetaDestinoModelo.Size = new System.Drawing.Size(270, 20);
            this.textBoxCarpetaDestinoModelo.TabIndex = 7;
            this.textBoxCarpetaDestinoModelo.Text = "modelo";
            // 
            // buttonSeleccionarCarpetaModelo
            // 
            this.buttonSeleccionarCarpetaModelo.Location = new System.Drawing.Point(286, 61);
            this.buttonSeleccionarCarpetaModelo.Name = "buttonSeleccionarCarpetaModelo";
            this.buttonSeleccionarCarpetaModelo.Size = new System.Drawing.Size(113, 23);
            this.buttonSeleccionarCarpetaModelo.TabIndex = 9;
            this.buttonSeleccionarCarpetaModelo.Text = "Seleccionar Carpeta";
            this.buttonSeleccionarCarpetaModelo.UseVisualStyleBackColor = true;
            this.buttonSeleccionarCarpetaModelo.Click += new System.EventHandler(this.buttonSeleccionarCarpetaModelo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Seleccione la carpeta de destino para guardar el archivo \"predicciones\" generado:" +
    "";
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
            // buttonSeleccionarCarpetaPrediccion
            // 
            this.buttonSeleccionarCarpetaPrediccion.Location = new System.Drawing.Point(286, 61);
            this.buttonSeleccionarCarpetaPrediccion.Name = "buttonSeleccionarCarpetaPrediccion";
            this.buttonSeleccionarCarpetaPrediccion.Size = new System.Drawing.Size(113, 23);
            this.buttonSeleccionarCarpetaPrediccion.TabIndex = 13;
            this.buttonSeleccionarCarpetaPrediccion.Text = "Seleccionar Carpeta";
            this.buttonSeleccionarCarpetaPrediccion.UseVisualStyleBackColor = true;
            this.buttonSeleccionarCarpetaPrediccion.Click += new System.EventHandler(this.buttonSeleccionarCarpetaPrediccion_Click);
            // 
            // textBoxCarpetaDestinoPrediccion
            // 
            this.textBoxCarpetaDestinoPrediccion.Location = new System.Drawing.Point(9, 63);
            this.textBoxCarpetaDestinoPrediccion.Name = "textBoxCarpetaDestinoPrediccion";
            this.textBoxCarpetaDestinoPrediccion.ReadOnly = true;
            this.textBoxCarpetaDestinoPrediccion.Size = new System.Drawing.Size(271, 20);
            this.textBoxCarpetaDestinoPrediccion.TabIndex = 12;
            this.textBoxCarpetaDestinoPrediccion.Text = "predicciones";
            // 
            // buttonGenerarModelo
            // 
            this.buttonGenerarModelo.Location = new System.Drawing.Point(9, 99);
            this.buttonGenerarModelo.Name = "buttonGenerarModelo";
            this.buttonGenerarModelo.Size = new System.Drawing.Size(92, 23);
            this.buttonGenerarModelo.TabIndex = 14;
            this.buttonGenerarModelo.Text = "Generar Modelo";
            this.buttonGenerarModelo.UseVisualStyleBackColor = true;
            this.buttonGenerarModelo.Click += new System.EventHandler(this.buttonGenerarModelo_Click);
            // 
            // buttonAbrirCarpetaContenedoraModelo
            // 
            this.buttonAbrirCarpetaContenedoraModelo.Enabled = false;
            this.buttonAbrirCarpetaContenedoraModelo.Location = new System.Drawing.Point(254, 99);
            this.buttonAbrirCarpetaContenedoraModelo.Name = "buttonAbrirCarpetaContenedoraModelo";
            this.buttonAbrirCarpetaContenedoraModelo.Size = new System.Drawing.Size(145, 23);
            this.buttonAbrirCarpetaContenedoraModelo.TabIndex = 16;
            this.buttonAbrirCarpetaContenedoraModelo.Text = "Abrir Carpeta Contenedora";
            this.buttonAbrirCarpetaContenedoraModelo.UseVisualStyleBackColor = true;
            this.buttonAbrirCarpetaContenedoraModelo.Click += new System.EventHandler(this.buttonAbrirCarpetaContenedoraModelo_Click);
            // 
            // buttonVisualizarModelo
            // 
            this.buttonVisualizarModelo.Enabled = false;
            this.buttonVisualizarModelo.Location = new System.Drawing.Point(104, 99);
            this.buttonVisualizarModelo.Name = "buttonVisualizarModelo";
            this.buttonVisualizarModelo.Size = new System.Drawing.Size(146, 23);
            this.buttonVisualizarModelo.TabIndex = 15;
            this.buttonVisualizarModelo.Text = "Visualizar Modelo";
            this.buttonVisualizarModelo.UseVisualStyleBackColor = true;
            this.buttonVisualizarModelo.Click += new System.EventHandler(this.buttonVisualizarModelo_Click);
            // 
            // buttonAbrirCarpetaContenedoraPrediccion
            // 
            this.buttonAbrirCarpetaContenedoraPrediccion.Enabled = false;
            this.buttonAbrirCarpetaContenedoraPrediccion.Location = new System.Drawing.Point(253, 99);
            this.buttonAbrirCarpetaContenedoraPrediccion.Name = "buttonAbrirCarpetaContenedoraPrediccion";
            this.buttonAbrirCarpetaContenedoraPrediccion.Size = new System.Drawing.Size(146, 23);
            this.buttonAbrirCarpetaContenedoraPrediccion.TabIndex = 19;
            this.buttonAbrirCarpetaContenedoraPrediccion.Text = "Abrir Carpeta Contenedora";
            this.buttonAbrirCarpetaContenedoraPrediccion.UseVisualStyleBackColor = true;
            this.buttonAbrirCarpetaContenedoraPrediccion.Click += new System.EventHandler(this.buttonAbrirCarpetaContenedoraPrediccion_Click);
            // 
            // buttonVisualizarPrediccion
            // 
            this.buttonVisualizarPrediccion.Enabled = false;
            this.buttonVisualizarPrediccion.Location = new System.Drawing.Point(120, 99);
            this.buttonVisualizarPrediccion.Name = "buttonVisualizarPrediccion";
            this.buttonVisualizarPrediccion.Size = new System.Drawing.Size(129, 23);
            this.buttonVisualizarPrediccion.TabIndex = 18;
            this.buttonVisualizarPrediccion.Text = "Visualizar Predicciones";
            this.buttonVisualizarPrediccion.UseVisualStyleBackColor = true;
            this.buttonVisualizarPrediccion.Click += new System.EventHandler(this.buttonVisualizarPrediccion_Click);
            // 
            // buttonGenerarPrediccion
            // 
            this.buttonGenerarPrediccion.Enabled = false;
            this.buttonGenerarPrediccion.Location = new System.Drawing.Point(9, 99);
            this.buttonGenerarPrediccion.Name = "buttonGenerarPrediccion";
            this.buttonGenerarPrediccion.Size = new System.Drawing.Size(107, 23);
            this.buttonGenerarPrediccion.TabIndex = 17;
            this.buttonGenerarPrediccion.Text = "Generar Predicción";
            this.buttonGenerarPrediccion.UseVisualStyleBackColor = true;
            this.buttonGenerarPrediccion.Click += new System.EventHandler(this.buttonGenerarPrediccion_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelModeloGenerado);
            this.panel1.Controls.Add(this.labelErrorCarpetaModelo);
            this.panel1.Controls.Add(this.richTextBoxTextoModelo);
            this.panel1.Controls.Add(this.buttonVisualizarModelo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxCarpetaDestinoModelo);
            this.panel1.Controls.Add(this.buttonAbrirCarpetaContenedoraModelo);
            this.panel1.Controls.Add(this.buttonSeleccionarCarpetaModelo);
            this.panel1.Controls.Add(this.buttonGenerarModelo);
            this.panel1.Location = new System.Drawing.Point(186, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 434);
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
            // labelErrorCarpetaModelo
            // 
            this.labelErrorCarpetaModelo.AutoSize = true;
            this.labelErrorCarpetaModelo.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCarpetaModelo.Location = new System.Drawing.Point(249, 13);
            this.labelErrorCarpetaModelo.Name = "labelErrorCarpetaModelo";
            this.labelErrorCarpetaModelo.Size = new System.Drawing.Size(150, 13);
            this.labelErrorCarpetaModelo.TabIndex = 18;
            this.labelErrorCarpetaModelo.Text = "Debe seleccionar una carpeta";
            this.labelErrorCarpetaModelo.Visible = false;
            // 
            // richTextBoxTextoModelo
            // 
            this.richTextBoxTextoModelo.Enabled = false;
            this.richTextBoxTextoModelo.Location = new System.Drawing.Point(9, 128);
            this.richTextBoxTextoModelo.Name = "richTextBoxTextoModelo";
            this.richTextBoxTextoModelo.ReadOnly = true;
            this.richTextBoxTextoModelo.Size = new System.Drawing.Size(390, 295);
            this.richTextBoxTextoModelo.TabIndex = 17;
            this.richTextBoxTextoModelo.Text = "";
            this.richTextBoxTextoModelo.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelPrediccionesGeneradas);
            this.panel2.Controls.Add(this.labelErrorCarpetaPrediccion);
            this.panel2.Controls.Add(this.richTextBoxTextoPrediccion);
            this.panel2.Controls.Add(this.buttonVisualizarPrediccion);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buttonAbrirCarpetaContenedoraPrediccion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxCarpetaDestinoPrediccion);
            this.panel2.Controls.Add(this.buttonGenerarPrediccion);
            this.panel2.Controls.Add(this.buttonSeleccionarCarpetaPrediccion);
            this.panel2.Location = new System.Drawing.Point(594, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 434);
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
            // labelErrorCarpetaPrediccion
            // 
            this.labelErrorCarpetaPrediccion.AutoSize = true;
            this.labelErrorCarpetaPrediccion.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCarpetaPrediccion.Location = new System.Drawing.Point(249, 13);
            this.labelErrorCarpetaPrediccion.Name = "labelErrorCarpetaPrediccion";
            this.labelErrorCarpetaPrediccion.Size = new System.Drawing.Size(150, 13);
            this.labelErrorCarpetaPrediccion.TabIndex = 19;
            this.labelErrorCarpetaPrediccion.Text = "Debe seleccionar una carpeta";
            this.labelErrorCarpetaPrediccion.Visible = false;
            // 
            // richTextBoxTextoPrediccion
            // 
            this.richTextBoxTextoPrediccion.Enabled = false;
            this.richTextBoxTextoPrediccion.Location = new System.Drawing.Point(9, 128);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox textBoxCarpetaDestinoModelo;
        private System.Windows.Forms.Button buttonSeleccionarCarpetaModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSeleccionarCarpetaPrediccion;
        private System.Windows.Forms.TextBox textBoxCarpetaDestinoPrediccion;
        private System.Windows.Forms.Button buttonGenerarModelo;
        private System.Windows.Forms.Button buttonAbrirCarpetaContenedoraModelo;
        private System.Windows.Forms.Button buttonVisualizarModelo;
        private System.Windows.Forms.Button buttonAbrirCarpetaContenedoraPrediccion;
        private System.Windows.Forms.Button buttonVisualizarPrediccion;
        private System.Windows.Forms.Button buttonGenerarPrediccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxTextoModelo;
        private System.Windows.Forms.RichTextBox richTextBoxTextoPrediccion;
        private System.Windows.Forms.Label labelErrorCarpetaModelo;
        private System.Windows.Forms.Label labelErrorCarpetaPrediccion;
        private System.Windows.Forms.Label labelModeloGenerado;
        private System.Windows.Forms.Label labelPrediccionesGeneradas;
    }
}