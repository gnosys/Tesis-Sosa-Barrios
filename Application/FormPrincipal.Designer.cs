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
            this.buttonDescubrimientoConocimiento = new System.Windows.Forms.Button();
            this.panelBotonera = new System.Windows.Forms.Panel();
            this.buttonTokenization = new System.Windows.Forms.Button();
            this.menuStripSolapas = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.buttonDataBase.Text = "DataBase";
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
            this.buttonSeleccionarCategoria.Size = new System.Drawing.Size(129, 23);
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
            this.label9.Location = new System.Drawing.Point(16, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Aplicacion del Pipe";
            // 
            // buttonPreprocesamiento
            // 
            this.buttonPreprocesamiento.Location = new System.Drawing.Point(16, 300);
            this.buttonPreprocesamiento.Name = "buttonPreprocesamiento";
            this.buttonPreprocesamiento.Size = new System.Drawing.Size(130, 23);
            this.buttonPreprocesamiento.TabIndex = 16;
            this.buttonPreprocesamiento.Text = "Preprocesamiento";
            this.buttonPreprocesamiento.UseVisualStyleBackColor = true;
            this.buttonPreprocesamiento.Click += new System.EventHandler(this.buttonPreprocesamiento_Click);
            // 
            // buttonRepresentacion
            // 
            this.buttonRepresentacion.Location = new System.Drawing.Point(16, 334);
            this.buttonRepresentacion.Name = "buttonRepresentacion";
            this.buttonRepresentacion.Size = new System.Drawing.Size(129, 23);
            this.buttonRepresentacion.TabIndex = 17;
            this.buttonRepresentacion.Text = "Representación";
            this.buttonRepresentacion.UseVisualStyleBackColor = true;
            // 
            // buttonDescubrimientoConocimiento
            // 
            this.buttonDescubrimientoConocimiento.Location = new System.Drawing.Point(18, 370);
            this.buttonDescubrimientoConocimiento.Name = "buttonDescubrimientoConocimiento";
            this.buttonDescubrimientoConocimiento.Size = new System.Drawing.Size(126, 39);
            this.buttonDescubrimientoConocimiento.TabIndex = 18;
            this.buttonDescubrimientoConocimiento.Text = "Descubrimiento del Conocimiento";
            this.buttonDescubrimientoConocimiento.UseVisualStyleBackColor = true;
            // 
            // panelBotonera
            // 
            this.panelBotonera.Controls.Add(this.buttonTokenization);
            this.panelBotonera.Controls.Add(this.buttonDescubrimientoConocimiento);
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
            // buttonTokenization
            // 
            this.buttonTokenization.Location = new System.Drawing.Point(16, 136);
            this.buttonTokenization.Name = "buttonTokenization";
            this.buttonTokenization.Size = new System.Drawing.Size(129, 23);
            this.buttonTokenization.TabIndex = 19;
            this.buttonTokenization.Text = "Tokenization";
            this.buttonTokenization.UseVisualStyleBackColor = true;
            this.buttonTokenization.Click += new System.EventHandler(this.buttonTokenization_Click);
            // 
            // menuStripSolapas
            // 
            this.menuStripSolapas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInicio});
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
            this.cerrarToolStripMenuItem});
            this.toolStripMenuItemInicio.Name = "toolStripMenuItemInicio";
            this.toolStripMenuItemInicio.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItemInicio.Text = "&Inicio";
            // 
            // cargarPipeToolStripMenuItem
            // 
            this.cargarPipeToolStripMenuItem.Name = "cargarPipeToolStripMenuItem";
            this.cargarPipeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarPipeToolStripMenuItem.Text = "Cargar Pipe";
            this.cargarPipeToolStripMenuItem.Click += new System.EventHandler(this.cargarPipeToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
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
        private System.Windows.Forms.Button buttonDescubrimientoConocimiento;
        private System.Windows.Forms.Panel panelBotonera;
        private System.Windows.Forms.Button buttonTokenization;
        private System.Windows.Forms.MenuStrip menuStripSolapas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInicio;
        private System.Windows.Forms.ToolStripMenuItem cargarPipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}

