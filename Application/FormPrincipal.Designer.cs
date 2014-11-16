namespace AppPrincipal
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.buttonDataBase = new System.Windows.Forms.Button();
            this.buttonStopWords = new System.Windows.Forms.Button();
            this.buttonStemmer = new System.Windows.Forms.Button();
            this.buttonSeleccionarCategoria = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonPreprocesamiento = new System.Windows.Forms.Button();
            this.buttonRepresentacion = new System.Windows.Forms.Button();
            this.buttonEjecutarSVMLigth = new System.Windows.Forms.Button();
            this.panelBotonera = new System.Windows.Forms.Panel();
            this.buttonMatrizConfusion = new System.Windows.Forms.Button();
            this.buttonCompararResultados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTratamientoEnTexto = new System.Windows.Forms.Button();
            this.buttonEnriquecimiento = new System.Windows.Forms.Button();
            this.buttonTokenization = new System.Windows.Forms.Button();
            this.menuStripSolapas = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarPipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaPreprocesadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBotonera.SuspendLayout();
            this.menuStripSolapas.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDataBase
            // 
            this.buttonDataBase.Location = new System.Drawing.Point(16, 36);
            this.buttonDataBase.Name = "buttonDataBase";
            this.buttonDataBase.Size = new System.Drawing.Size(130, 23);
            this.buttonDataBase.TabIndex = 9;
            this.buttonDataBase.Text = "Base de Datos";
            this.buttonDataBase.UseVisualStyleBackColor = true;
            this.buttonDataBase.Click += new System.EventHandler(this.buttonDataBase_Click);
            // 
            // buttonStopWords
            // 
            this.buttonStopWords.Location = new System.Drawing.Point(16, 165);
            this.buttonStopWords.Name = "buttonStopWords";
            this.buttonStopWords.Size = new System.Drawing.Size(130, 23);
            this.buttonStopWords.TabIndex = 10;
            this.buttonStopWords.Text = "Stop Words";
            this.buttonStopWords.UseVisualStyleBackColor = true;
            this.buttonStopWords.Click += new System.EventHandler(this.buttonStopWords_Click);
            // 
            // buttonStemmer
            // 
            this.buttonStemmer.Location = new System.Drawing.Point(16, 194);
            this.buttonStemmer.Name = "buttonStemmer";
            this.buttonStemmer.Size = new System.Drawing.Size(130, 23);
            this.buttonStemmer.TabIndex = 11;
            this.buttonStemmer.Text = "Stemmer";
            this.buttonStemmer.UseVisualStyleBackColor = true;
            this.buttonStemmer.Click += new System.EventHandler(this.buttonStemmer_Click);
            // 
            // buttonSeleccionarCategoria
            // 
            this.buttonSeleccionarCategoria.Location = new System.Drawing.Point(16, 65);
            this.buttonSeleccionarCategoria.Name = "buttonSeleccionarCategoria";
            this.buttonSeleccionarCategoria.Size = new System.Drawing.Size(130, 23);
            this.buttonSeleccionarCategoria.TabIndex = 12;
            this.buttonSeleccionarCategoria.Text = "Seleccionar Categoria";
            this.buttonSeleccionarCategoria.UseVisualStyleBackColor = true;
            this.buttonSeleccionarCategoria.Click += new System.EventHandler(this.buttonSeleccionarCategoria_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tratamiento de Datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Preprocesamientos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Aplicacion del Pipe";
            // 
            // buttonPreprocesamiento
            // 
            this.buttonPreprocesamiento.Enabled = false;
            this.buttonPreprocesamiento.Location = new System.Drawing.Point(16, 326);
            this.buttonPreprocesamiento.Name = "buttonPreprocesamiento";
            this.buttonPreprocesamiento.Size = new System.Drawing.Size(130, 23);
            this.buttonPreprocesamiento.TabIndex = 16;
            this.buttonPreprocesamiento.Text = "Preprocesamiento";
            this.buttonPreprocesamiento.UseVisualStyleBackColor = true;
            this.buttonPreprocesamiento.Click += new System.EventHandler(this.buttonPreprocesamiento_Click);
            // 
            // buttonRepresentacion
            // 
            this.buttonRepresentacion.Enabled = false;
            this.buttonRepresentacion.Location = new System.Drawing.Point(16, 355);
            this.buttonRepresentacion.Name = "buttonRepresentacion";
            this.buttonRepresentacion.Size = new System.Drawing.Size(130, 23);
            this.buttonRepresentacion.TabIndex = 17;
            this.buttonRepresentacion.Text = "Representación";
            this.buttonRepresentacion.UseVisualStyleBackColor = true;
            this.buttonRepresentacion.Click += new System.EventHandler(this.buttonRepresentacion_Click);
            // 
            // buttonEjecutarSVMLigth
            // 
            this.buttonEjecutarSVMLigth.Enabled = false;
            this.buttonEjecutarSVMLigth.Location = new System.Drawing.Point(16, 384);
            this.buttonEjecutarSVMLigth.Name = "buttonEjecutarSVMLigth";
            this.buttonEjecutarSVMLigth.Size = new System.Drawing.Size(130, 23);
            this.buttonEjecutarSVMLigth.TabIndex = 18;
            this.buttonEjecutarSVMLigth.Text = "SVM-Ligth";
            this.buttonEjecutarSVMLigth.UseVisualStyleBackColor = true;
            this.buttonEjecutarSVMLigth.Click += new System.EventHandler(this.buttonEjecutarSVMLigth_Click);
            // 
            // panelBotonera
            // 
            this.panelBotonera.Controls.Add(this.buttonMatrizConfusion);
            this.panelBotonera.Controls.Add(this.buttonCompararResultados);
            this.panelBotonera.Controls.Add(this.label1);
            this.panelBotonera.Controls.Add(this.buttonTratamientoEnTexto);
            this.panelBotonera.Controls.Add(this.buttonEjecutarSVMLigth);
            this.panelBotonera.Controls.Add(this.buttonEnriquecimiento);
            this.panelBotonera.Controls.Add(this.buttonTokenization);
            this.panelBotonera.Controls.Add(this.buttonDataBase);
            this.panelBotonera.Controls.Add(this.buttonRepresentacion);
            this.panelBotonera.Controls.Add(this.buttonStopWords);
            this.panelBotonera.Controls.Add(this.buttonPreprocesamiento);
            this.panelBotonera.Controls.Add(this.buttonStemmer);
            this.panelBotonera.Controls.Add(this.label9);
            this.panelBotonera.Controls.Add(this.buttonSeleccionarCategoria);
            this.panelBotonera.Controls.Add(this.label8);
            this.panelBotonera.Controls.Add(this.label7);
            this.panelBotonera.Location = new System.Drawing.Point(1, 26);
            this.panelBotonera.Name = "panelBotonera";
            this.panelBotonera.Size = new System.Drawing.Size(164, 569);
            this.panelBotonera.TabIndex = 19;
            // 
            // buttonMatrizConfusion
            // 
            this.buttonMatrizConfusion.Enabled = false;
            this.buttonMatrizConfusion.Location = new System.Drawing.Point(16, 455);
            this.buttonMatrizConfusion.Name = "buttonMatrizConfusion";
            this.buttonMatrizConfusion.Size = new System.Drawing.Size(130, 23);
            this.buttonMatrizConfusion.TabIndex = 21;
            this.buttonMatrizConfusion.Text = "Matriz de Confusión";
            this.buttonMatrizConfusion.UseVisualStyleBackColor = true;
            this.buttonMatrizConfusion.Click += new System.EventHandler(this.buttonMatrizConfusion_Click);
            // 
            // buttonCompararResultados
            // 
            this.buttonCompararResultados.Enabled = false;
            this.buttonCompararResultados.Location = new System.Drawing.Point(16, 484);
            this.buttonCompararResultados.Name = "buttonCompararResultados";
            this.buttonCompararResultados.Size = new System.Drawing.Size(130, 23);
            this.buttonCompararResultados.TabIndex = 23;
            this.buttonCompararResultados.Text = "Comparar Resultados";
            this.buttonCompararResultados.UseVisualStyleBackColor = true;
            this.buttonCompararResultados.Click += new System.EventHandler(this.buttonCompararResultados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Resultados";
            // 
            // buttonTratamientoEnTexto
            // 
            this.buttonTratamientoEnTexto.Location = new System.Drawing.Point(16, 253);
            this.buttonTratamientoEnTexto.Name = "buttonTratamientoEnTexto";
            this.buttonTratamientoEnTexto.Size = new System.Drawing.Size(130, 23);
            this.buttonTratamientoEnTexto.TabIndex = 21;
            this.buttonTratamientoEnTexto.Text = "Tratamiento en Texto";
            this.buttonTratamientoEnTexto.UseVisualStyleBackColor = true;
            this.buttonTratamientoEnTexto.Click += new System.EventHandler(this.buttonTratamientoEnTexto_Click);
            // 
            // buttonEnriquecimiento
            // 
            this.buttonEnriquecimiento.Location = new System.Drawing.Point(16, 224);
            this.buttonEnriquecimiento.Name = "buttonEnriquecimiento";
            this.buttonEnriquecimiento.Size = new System.Drawing.Size(130, 23);
            this.buttonEnriquecimiento.TabIndex = 20;
            this.buttonEnriquecimiento.Text = "Enriquecimiento";
            this.buttonEnriquecimiento.UseVisualStyleBackColor = true;
            this.buttonEnriquecimiento.Click += new System.EventHandler(this.buttonEnriquecimiento_Click);
            // 
            // buttonTokenization
            // 
            this.buttonTokenization.Location = new System.Drawing.Point(16, 136);
            this.buttonTokenization.Name = "buttonTokenization";
            this.buttonTokenization.Size = new System.Drawing.Size(130, 23);
            this.buttonTokenization.TabIndex = 19;
            this.buttonTokenization.Text = "Tokenization";
            this.buttonTokenization.UseVisualStyleBackColor = true;
            this.buttonTokenization.Click += new System.EventHandler(this.buttonTokenization_Click);
            // 
            // menuStripSolapas
            // 
            this.menuStripSolapas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInicio,
            this.ayudaToolStripMenuItem});
            this.menuStripSolapas.Location = new System.Drawing.Point(0, 0);
            this.menuStripSolapas.Name = "menuStripSolapas";
            this.menuStripSolapas.Size = new System.Drawing.Size(1007, 24);
            this.menuStripSolapas.TabIndex = 20;
            this.menuStripSolapas.Text = "Solapas";
            // 
            // toolStripMenuItemInicio
            // 
            this.toolStripMenuItemInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarPipeToolStripMenuItem,
            this.guardarPipeToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.toolStripMenuItemInicio.Name = "toolStripMenuItemInicio";
            this.toolStripMenuItemInicio.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItemInicio.Text = "&Inicio";
            // 
            // cargarPipeToolStripMenuItem
            // 
            this.cargarPipeToolStripMenuItem.Name = "cargarPipeToolStripMenuItem";
            this.cargarPipeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cargarPipeToolStripMenuItem.Text = "Cargar Pipe";
            this.cargarPipeToolStripMenuItem.Click += new System.EventHandler(this.cargarPipeToolStripMenuItem_Click);
            // 
            // guardarPipeToolStripMenuItem
            // 
            this.guardarPipeToolStripMenuItem.Name = "guardarPipeToolStripMenuItem";
            this.guardarPipeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.guardarPipeToolStripMenuItem.Text = "Guardar Pipe";
            this.guardarPipeToolStripMenuItem.Click += new System.EventHandler(this.guardarPipeToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaPreprocesadorToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaPreprocesadorToolStripMenuItem
            // 
            this.acercaPreprocesadorToolStripMenuItem.Name = "acercaPreprocesadorToolStripMenuItem";
            this.acercaPreprocesadorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.acercaPreprocesadorToolStripMenuItem.Text = "Acerca Preprocesador";
            this.acercaPreprocesadorToolStripMenuItem.Click += new System.EventHandler(this.acercaPreprocesadorToolStripMenuItem_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AppPrincipal.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1007, 597);
            this.Controls.Add(this.panelBotonera);
            this.Controls.Add(this.menuStripSolapas);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App";
            this.Text = "Preprocesamiento de Tweets";
            this.panelBotonera.ResumeLayout(false);
            this.panelBotonera.PerformLayout();
            this.menuStripSolapas.ResumeLayout(false);
            this.menuStripSolapas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDataBase;
        private System.Windows.Forms.Button buttonStopWords;
        private System.Windows.Forms.Button buttonStemmer;
        private System.Windows.Forms.Button buttonSeleccionarCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonPreprocesamiento;
        private System.Windows.Forms.Button buttonRepresentacion;
        private System.Windows.Forms.Button buttonEjecutarSVMLigth;
        private System.Windows.Forms.Panel panelBotonera;
        private System.Windows.Forms.Button buttonTokenization;
        private System.Windows.Forms.MenuStrip menuStripSolapas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInicio;
        private System.Windows.Forms.ToolStripMenuItem cargarPipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Button buttonEnriquecimiento;
        private System.Windows.Forms.Button buttonTratamientoEnTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCompararResultados;
        private System.Windows.Forms.ToolStripMenuItem guardarPipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaPreprocesadorToolStripMenuItem;
        private System.Windows.Forms.Button buttonMatrizConfusion;
    }
}

