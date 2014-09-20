namespace AppPrincipal
{
    partial class FormPreprocesamiento
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
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Stemmer");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Stop Words");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Tokenizacion");
            this.buttonPreprocesar = new System.Windows.Forms.Button();
            this.listViewPreprocesamientos = new System.Windows.Forms.ListView();
            this.columnHeaderListaSeleccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.listViewOdenPreprocesos = new System.Windows.Forms.ListView();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.buttonConfigurar = new System.Windows.Forms.Button();
            this.buttonSubir = new System.Windows.Forms.Button();
            this.buttonBajar = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.panelConfiguracionPreproceso = new System.Windows.Forms.Panel();
            this.labelPreproceso = new System.Windows.Forms.Label();
            this.panelConfiguracionPreproceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPreprocesar
            // 
            this.buttonPreprocesar.Location = new System.Drawing.Point(878, 354);
            this.buttonPreprocesar.Name = "buttonPreprocesar";
            this.buttonPreprocesar.Size = new System.Drawing.Size(116, 23);
            this.buttonPreprocesar.TabIndex = 0;
            this.buttonPreprocesar.Text = "Preprocesar";
            this.buttonPreprocesar.UseVisualStyleBackColor = true;
            this.buttonPreprocesar.Click += new System.EventHandler(this.buttonPreprocesar_Click);
            // 
            // listViewPreprocesamientos
            // 
            this.listViewPreprocesamientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderListaSeleccion});
            this.listViewPreprocesamientos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPreprocesamientos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.listViewPreprocesamientos.Location = new System.Drawing.Point(432, 91);
            this.listViewPreprocesamientos.MultiSelect = false;
            this.listViewPreprocesamientos.Name = "listViewPreprocesamientos";
            this.listViewPreprocesamientos.Size = new System.Drawing.Size(154, 186);
            this.listViewPreprocesamientos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPreprocesamientos.TabIndex = 2;
            this.listViewPreprocesamientos.UseCompatibleStateImageBehavior = false;
            this.listViewPreprocesamientos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderListaSeleccion
            // 
            this.columnHeaderListaSeleccion.Text = "Preprocesamientos";
            this.columnHeaderListaSeleccion.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione las diferentes formas de preprocesamiento y el orden en que se aplica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione de la siguiente lista\r\nlos diferentes preprocesados,\r\nluego debera con" +
    "figurar\r\nlos mismos segun corresponda";
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(607, 143);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 5;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // listViewOdenPreprocesos
            // 
            this.listViewOdenPreprocesos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewOdenPreprocesos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOdenPreprocesos.Location = new System.Drawing.Point(704, 91);
            this.listViewOdenPreprocesos.MultiSelect = false;
            this.listViewOdenPreprocesos.Name = "listViewOdenPreprocesos";
            this.listViewOdenPreprocesos.Size = new System.Drawing.Size(154, 186);
            this.listViewOdenPreprocesos.TabIndex = 6;
            this.listViewOdenPreprocesos.UseCompatibleStateImageBehavior = false;
            this.listViewOdenPreprocesos.View = System.Windows.Forms.View.Details;
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.Location = new System.Drawing.Point(607, 172);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitar.TabIndex = 7;
            this.buttonQuitar.Text = "Quitar";
            this.buttonQuitar.UseVisualStyleBackColor = true;
            this.buttonQuitar.Click += new System.EventHandler(this.buttonQuitar_Click);
            // 
            // buttonConfigurar
            // 
            this.buttonConfigurar.Location = new System.Drawing.Point(878, 225);
            this.buttonConfigurar.Name = "buttonConfigurar";
            this.buttonConfigurar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigurar.TabIndex = 8;
            this.buttonConfigurar.Text = "Configurar";
            this.buttonConfigurar.UseVisualStyleBackColor = true;
            // 
            // buttonSubir
            // 
            this.buttonSubir.Location = new System.Drawing.Point(878, 143);
            this.buttonSubir.Name = "buttonSubir";
            this.buttonSubir.Size = new System.Drawing.Size(75, 23);
            this.buttonSubir.TabIndex = 9;
            this.buttonSubir.Text = "Subir";
            this.buttonSubir.UseVisualStyleBackColor = true;
            this.buttonSubir.Click += new System.EventHandler(this.buttonSubir_Click);
            // 
            // buttonBajar
            // 
            this.buttonBajar.Location = new System.Drawing.Point(878, 172);
            this.buttonBajar.Name = "buttonBajar";
            this.buttonBajar.Size = new System.Drawing.Size(75, 23);
            this.buttonBajar.TabIndex = 10;
            this.buttonBajar.Text = "Bajar";
            this.buttonBajar.UseVisualStyleBackColor = true;
            this.buttonBajar.Click += new System.EventHandler(this.buttonBajar_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Orden de Preprocesos";
            this.columnHeader1.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Configuracion del preprocesado";
            // 
            // panelConfiguracionPreproceso
            // 
            this.panelConfiguracionPreproceso.Controls.Add(this.labelPreproceso);
            this.panelConfiguracionPreproceso.Controls.Add(this.label3);
            this.panelConfiguracionPreproceso.Location = new System.Drawing.Point(191, 305);
            this.panelConfiguracionPreproceso.Name = "panelConfiguracionPreproceso";
            this.panelConfiguracionPreproceso.Size = new System.Drawing.Size(667, 230);
            this.panelConfiguracionPreproceso.TabIndex = 12;
            // 
            // labelPreproceso
            // 
            this.labelPreproceso.AutoSize = true;
            this.labelPreproceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreproceso.Location = new System.Drawing.Point(169, 10);
            this.labelPreproceso.Name = "labelPreproceso";
            this.labelPreproceso.Size = new System.Drawing.Size(91, 13);
            this.labelPreproceso.TabIndex = 12;
            this.labelPreproceso.Text = "PREPROCESO";
            // 
            // FormPreprocesamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.panelConfiguracionPreproceso);
            this.Controls.Add(this.buttonBajar);
            this.Controls.Add(this.buttonSubir);
            this.Controls.Add(this.buttonConfigurar);
            this.Controls.Add(this.buttonQuitar);
            this.Controls.Add(this.listViewOdenPreprocesos);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPreprocesamientos);
            this.Controls.Add(this.buttonPreprocesar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPreprocesamiento";
            this.Text = "FormPreprocesamiento";
            this.panelConfiguracionPreproceso.ResumeLayout(false);
            this.panelConfiguracionPreproceso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreprocesar;
        private System.Windows.Forms.ListView listViewPreprocesamientos;
        private System.Windows.Forms.ColumnHeader columnHeaderListaSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.ListView listViewOdenPreprocesos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.Button buttonConfigurar;
        private System.Windows.Forms.Button buttonSubir;
        private System.Windows.Forms.Button buttonBajar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelConfiguracionPreproceso;
        private System.Windows.Forms.Label labelPreproceso;

    }
}