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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Stemmer");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Stop Words");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Tokenizacion");
            this.buttonPreprocesar = new System.Windows.Forms.Button();
            this.listViewPreprocesamientos = new System.Windows.Forms.ListView();
            this.columnHeaderListaSeleccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.listViewOrdenPreprocesos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.buttonSubir = new System.Windows.Forms.Button();
            this.buttonBajar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuscarListStopWords = new System.Windows.Forms.Button();
            this.textBoxDireccionStopWords = new System.Windows.Forms.TextBox();
            this.checkBoxListaStopWordsDefecto = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlConfiguraciones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelArchivosTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAplicarListaStopWords = new System.Windows.Forms.Button();
            this.buttonAplicarExpresionRegular = new System.Windows.Forms.Button();
            this.tabControlConfiguraciones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPreprocesar
            // 
            this.buttonPreprocesar.Location = new System.Drawing.Point(878, 364);
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
            listViewItem1,
            listViewItem2,
            listViewItem3});
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
            // listViewOrdenPreprocesos
            // 
            this.listViewOrdenPreprocesos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewOrdenPreprocesos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOrdenPreprocesos.Location = new System.Drawing.Point(704, 91);
            this.listViewOrdenPreprocesos.MultiSelect = false;
            this.listViewOrdenPreprocesos.Name = "listViewOrdenPreprocesos";
            this.listViewOrdenPreprocesos.Size = new System.Drawing.Size(154, 186);
            this.listViewOrdenPreprocesos.TabIndex = 6;
            this.listViewOrdenPreprocesos.UseCompatibleStateImageBehavior = false;
            this.listViewOrdenPreprocesos.View = System.Windows.Forms.View.Details;
            this.listViewOrdenPreprocesos.Click += new System.EventHandler(this.listViewOrdenPreprocesos_Click);
            this.listViewOrdenPreprocesos.Enter += new System.EventHandler(this.listViewOrdenPreprocesos_Enter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Orden de Preprocesos";
            this.columnHeader1.Width = 150;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Configuracion de Preprocesado";
            // 
            // buttonBuscarListStopWords
            // 
            this.buttonBuscarListStopWords.Location = new System.Drawing.Point(563, 19);
            this.buttonBuscarListStopWords.Name = "buttonBuscarListStopWords";
            this.buttonBuscarListStopWords.Size = new System.Drawing.Size(83, 23);
            this.buttonBuscarListStopWords.TabIndex = 4;
            this.buttonBuscarListStopWords.Text = "Buscar Lista";
            this.buttonBuscarListStopWords.UseVisualStyleBackColor = true;
            this.buttonBuscarListStopWords.Click += new System.EventHandler(this.buttonBuscarListStopWords_Click);
            // 
            // textBoxDireccionStopWords
            // 
            this.textBoxDireccionStopWords.Location = new System.Drawing.Point(201, 21);
            this.textBoxDireccionStopWords.Name = "textBoxDireccionStopWords";
            this.textBoxDireccionStopWords.Size = new System.Drawing.Size(356, 20);
            this.textBoxDireccionStopWords.TabIndex = 3;
            // 
            // checkBoxListaStopWordsDefecto
            // 
            this.checkBoxListaStopWordsDefecto.AutoSize = true;
            this.checkBoxListaStopWordsDefecto.Location = new System.Drawing.Point(129, 52);
            this.checkBoxListaStopWordsDefecto.Name = "checkBoxListaStopWordsDefecto";
            this.checkBoxListaStopWordsDefecto.Size = new System.Drawing.Size(15, 14);
            this.checkBoxListaStopWordsDefecto.TabIndex = 2;
            this.checkBoxListaStopWordsDefecto.UseVisualStyleBackColor = true;
            this.checkBoxListaStopWordsDefecto.CheckedChanged += new System.EventHandler(this.checkBoxListaStopWordsDefecto_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Usar lista por defecto ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seleccione una lista de Stop Words";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Este preproceso no necesita una configuracion especifica.";
            // 
            // tabControlConfiguraciones
            // 
            this.tabControlConfiguraciones.Controls.Add(this.tabPage1);
            this.tabControlConfiguraciones.Controls.Add(this.tabPage2);
            this.tabControlConfiguraciones.Controls.Add(this.tabPage3);
            this.tabControlConfiguraciones.Location = new System.Drawing.Point(208, 332);
            this.tabControlConfiguraciones.Name = "tabControlConfiguraciones";
            this.tabControlConfiguraciones.SelectedIndex = 0;
            this.tabControlConfiguraciones.Size = new System.Drawing.Size(664, 224);
            this.tabControlConfiguraciones.TabIndex = 14;
            this.tabControlConfiguraciones.Visible = false;
            this.tabControlConfiguraciones.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlConfiguraciones_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stemmer";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.buttonAplicarListaStopWords);
            this.tabPage2.Controls.Add(this.labelArchivosTxt);
            this.tabPage2.Controls.Add(this.buttonBuscarListStopWords);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxDireccionStopWords);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.checkBoxListaStopWordsDefecto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stop Words";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.buttonAplicarExpresionRegular);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(656, 198);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tokenizacion";
            // 
            // labelArchivosTxt
            // 
            this.labelArchivosTxt.AutoSize = true;
            this.labelArchivosTxt.ForeColor = System.Drawing.Color.Gray;
            this.labelArchivosTxt.Location = new System.Drawing.Point(562, 51);
            this.labelArchivosTxt.Name = "labelArchivosTxt";
            this.labelArchivosTxt.Size = new System.Drawing.Size(85, 13);
            this.labelArchivosTxt.TabIndex = 5;
            this.labelArchivosTxt.Text = "Solo archivos txt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ingrese Expresion Regular para separar en tokens";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonAplicarListaStopWords
            // 
            this.buttonAplicarListaStopWords.Location = new System.Drawing.Point(565, 159);
            this.buttonAplicarListaStopWords.Name = "buttonAplicarListaStopWords";
            this.buttonAplicarListaStopWords.Size = new System.Drawing.Size(81, 23);
            this.buttonAplicarListaStopWords.TabIndex = 6;
            this.buttonAplicarListaStopWords.Text = "Aplicar Lista";
            this.buttonAplicarListaStopWords.UseVisualStyleBackColor = true;
            // 
            // buttonAplicarExpresionRegular
            // 
            this.buttonAplicarExpresionRegular.Location = new System.Drawing.Point(565, 159);
            this.buttonAplicarExpresionRegular.Name = "buttonAplicarExpresionRegular";
            this.buttonAplicarExpresionRegular.Size = new System.Drawing.Size(81, 23);
            this.buttonAplicarExpresionRegular.TabIndex = 2;
            this.buttonAplicarExpresionRegular.Text = "Aplicar E.R.";
            this.buttonAplicarExpresionRegular.UseVisualStyleBackColor = true;
            // 
            // FormPreprocesamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.tabControlConfiguraciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBajar);
            this.Controls.Add(this.buttonSubir);
            this.Controls.Add(this.buttonQuitar);
            this.Controls.Add(this.listViewOrdenPreprocesos);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPreprocesamientos);
            this.Controls.Add(this.buttonPreprocesar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPreprocesamiento";
            this.Text = "FormPreprocesamiento";
            this.tabControlConfiguraciones.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.ListView listViewOrdenPreprocesos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.Button buttonSubir;
        private System.Windows.Forms.Button buttonBajar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxListaStopWordsDefecto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBuscarListStopWords;
        private System.Windows.Forms.TextBox textBoxDireccionStopWords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControlConfiguraciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelArchivosTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAplicarListaStopWords;
        private System.Windows.Forms.Button buttonAplicarExpresionRegular;

    }
}