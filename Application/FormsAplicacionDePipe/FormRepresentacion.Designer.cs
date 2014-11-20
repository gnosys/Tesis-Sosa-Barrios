namespace AppPrincipal.FormsAplicacionDePipe
{
    partial class FormRepresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRepresentacion));
            this.buttonObtenerRepresentacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMinWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCarpetaDestino = new System.Windows.Forms.TextBox();
            this.buttonSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.labelRepresentacionObtenida = new System.Windows.Forms.Label();
            this.buttonVisualizarSVMLearn = new System.Windows.Forms.Button();
            this.buttonAbrirCarpetaContenedora = new System.Windows.Forms.Button();
            this.labelErrorCarpeta = new System.Windows.Forms.Label();
            this.richTextBoxTextoArchivo = new System.Windows.Forms.RichTextBox();
            this.buttonVisualizarSVMClassify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonObtenerRepresentacion
            // 
            this.buttonObtenerRepresentacion.Location = new System.Drawing.Point(192, 336);
            this.buttonObtenerRepresentacion.Name = "buttonObtenerRepresentacion";
            this.buttonObtenerRepresentacion.Size = new System.Drawing.Size(146, 23);
            this.buttonObtenerRepresentacion.TabIndex = 0;
            this.buttonObtenerRepresentacion.Text = "Obtener Representación";
            this.buttonObtenerRepresentacion.UseVisualStyleBackColor = true;
            this.buttonObtenerRepresentacion.Click += new System.EventHandler(this.buttonObtenerRepresentacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 143);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TF-IDF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Se desea limitar el peso aceptado para la representación, agregue un valor en un " +
    "rango entre 0  y 1:";
            // 
            // textBoxMinWeight
            // 
            this.textBoxMinWeight.Location = new System.Drawing.Point(669, 234);
            this.textBoxMinWeight.Name = "textBoxMinWeight";
            this.textBoxMinWeight.Size = new System.Drawing.Size(31, 20);
            this.textBoxMinWeight.TabIndex = 4;
            this.textBoxMinWeight.Text = "0";
            this.textBoxMinWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(685, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione la carpeta de destino donde se grabaran los archivos \"svm-learn.dat\" y" +
    " \"svm-classify.dat\" generados, para ser utilizados por el SVM:";
            // 
            // textBoxCarpetaDestino
            // 
            this.textBoxCarpetaDestino.Location = new System.Drawing.Point(192, 294);
            this.textBoxCarpetaDestino.Name = "textBoxCarpetaDestino";
            this.textBoxCarpetaDestino.ReadOnly = true;
            this.textBoxCarpetaDestino.Size = new System.Drawing.Size(403, 20);
            this.textBoxCarpetaDestino.TabIndex = 6;
            // 
            // buttonSeleccionarCarpeta
            // 
            this.buttonSeleccionarCarpeta.Location = new System.Drawing.Point(601, 292);
            this.buttonSeleccionarCarpeta.Name = "buttonSeleccionarCarpeta";
            this.buttonSeleccionarCarpeta.Size = new System.Drawing.Size(113, 23);
            this.buttonSeleccionarCarpeta.TabIndex = 7;
            this.buttonSeleccionarCarpeta.Text = "Seleccionar Carpeta";
            this.buttonSeleccionarCarpeta.UseVisualStyleBackColor = true;
            this.buttonSeleccionarCarpeta.Click += new System.EventHandler(this.buttonSeleccionarCarpeta_Click);
            // 
            // labelRepresentacionObtenida
            // 
            this.labelRepresentacionObtenida.AutoSize = true;
            this.labelRepresentacionObtenida.ForeColor = System.Drawing.Color.Green;
            this.labelRepresentacionObtenida.Location = new System.Drawing.Point(200, 369);
            this.labelRepresentacionObtenida.Name = "labelRepresentacionObtenida";
            this.labelRepresentacionObtenida.Size = new System.Drawing.Size(128, 13);
            this.labelRepresentacionObtenida.TabIndex = 8;
            this.labelRepresentacionObtenida.Text = "Representación Obtenida";
            this.labelRepresentacionObtenida.Visible = false;
            // 
            // buttonVisualizarSVMLearn
            // 
            this.buttonVisualizarSVMLearn.Enabled = false;
            this.buttonVisualizarSVMLearn.Location = new System.Drawing.Point(192, 412);
            this.buttonVisualizarSVMLearn.Name = "buttonVisualizarSVMLearn";
            this.buttonVisualizarSVMLearn.Size = new System.Drawing.Size(146, 23);
            this.buttonVisualizarSVMLearn.TabIndex = 9;
            this.buttonVisualizarSVMLearn.Text = "Visualizar \"svm-learn.dat\"";
            this.buttonVisualizarSVMLearn.UseVisualStyleBackColor = true;
            this.buttonVisualizarSVMLearn.Click += new System.EventHandler(this.buttonVisualizarSVMLearn_Click);
            // 
            // buttonAbrirCarpetaContenedora
            // 
            this.buttonAbrirCarpetaContenedora.Enabled = false;
            this.buttonAbrirCarpetaContenedora.Location = new System.Drawing.Point(192, 470);
            this.buttonAbrirCarpetaContenedora.Name = "buttonAbrirCarpetaContenedora";
            this.buttonAbrirCarpetaContenedora.Size = new System.Drawing.Size(146, 23);
            this.buttonAbrirCarpetaContenedora.TabIndex = 10;
            this.buttonAbrirCarpetaContenedora.Text = "Abrir Carpeta Contenedora";
            this.buttonAbrirCarpetaContenedora.UseVisualStyleBackColor = true;
            this.buttonAbrirCarpetaContenedora.Click += new System.EventHandler(this.buttonAbrirCarpetaContenedora_Click);
            // 
            // labelErrorCarpeta
            // 
            this.labelErrorCarpeta.AutoSize = true;
            this.labelErrorCarpeta.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCarpeta.Location = new System.Drawing.Point(717, 297);
            this.labelErrorCarpeta.Name = "labelErrorCarpeta";
            this.labelErrorCarpeta.Size = new System.Drawing.Size(150, 13);
            this.labelErrorCarpeta.TabIndex = 12;
            this.labelErrorCarpeta.Text = "Debe seleccionar una carpeta";
            this.labelErrorCarpeta.Visible = false;
            // 
            // richTextBoxTextoArchivo
            // 
            this.richTextBoxTextoArchivo.Enabled = false;
            this.richTextBoxTextoArchivo.Location = new System.Drawing.Point(358, 336);
            this.richTextBoxTextoArchivo.Name = "richTextBoxTextoArchivo";
            this.richTextBoxTextoArchivo.ReadOnly = true;
            this.richTextBoxTextoArchivo.Size = new System.Drawing.Size(614, 204);
            this.richTextBoxTextoArchivo.TabIndex = 13;
            this.richTextBoxTextoArchivo.Text = "";
            this.richTextBoxTextoArchivo.WordWrap = false;
            // 
            // buttonVisualizarSVMClassify
            // 
            this.buttonVisualizarSVMClassify.Enabled = false;
            this.buttonVisualizarSVMClassify.Location = new System.Drawing.Point(192, 441);
            this.buttonVisualizarSVMClassify.Name = "buttonVisualizarSVMClassify";
            this.buttonVisualizarSVMClassify.Size = new System.Drawing.Size(146, 23);
            this.buttonVisualizarSVMClassify.TabIndex = 14;
            this.buttonVisualizarSVMClassify.Text = "Visualizar \"svm-classify.dat\"";
            this.buttonVisualizarSVMClassify.UseVisualStyleBackColor = true;
            this.buttonVisualizarSVMClassify.Click += new System.EventHandler(this.buttonVisualizarSVMClassify_Click);
            // 
            // FormRepresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.buttonVisualizarSVMClassify);
            this.Controls.Add(this.richTextBoxTextoArchivo);
            this.Controls.Add(this.labelErrorCarpeta);
            this.Controls.Add(this.buttonAbrirCarpetaContenedora);
            this.Controls.Add(this.buttonVisualizarSVMLearn);
            this.Controls.Add(this.labelRepresentacionObtenida);
            this.Controls.Add(this.buttonSeleccionarCarpeta);
            this.Controls.Add(this.textBoxCarpetaDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMinWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonObtenerRepresentacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRepresentacion";
            this.Text = "FormRepresentacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonObtenerRepresentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMinWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCarpetaDestino;
        private System.Windows.Forms.Button buttonSeleccionarCarpeta;
        private System.Windows.Forms.Label labelRepresentacionObtenida;
        private System.Windows.Forms.Button buttonVisualizarSVMLearn;
        private System.Windows.Forms.Button buttonAbrirCarpetaContenedora;
        private System.Windows.Forms.Label labelErrorCarpeta;
        private System.Windows.Forms.RichTextBox richTextBoxTextoArchivo;
        private System.Windows.Forms.Button buttonVisualizarSVMClassify;
    }
}