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
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Enriquecimiento");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Stemmer");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Stop Words");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Tratamiento en Texto");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreprocesamiento));
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Tokenization");
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
            this.checkBoxListaStopWordsPorDefecto = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlConfiguraciones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelListaAplicadaStopWords = new System.Windows.Forms.Label();
            this.buttonAplicarListaStopWords = new System.Windows.Forms.Button();
            this.labelArchivosTxtStopWords = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxERPorDefecto = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelExpresionRegularAplicada = new System.Windows.Forms.Label();
            this.buttonAplicarExpresionRegular = new System.Windows.Forms.Button();
            this.textBoxExpresionRegular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBoxDescripcion = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelEnriquecimientoAplicado = new System.Windows.Forms.Label();
            this.buttonAplicarEnriquecimiento = new System.Windows.Forms.Button();
            this.checkBoxTitulo = new System.Windows.Forms.CheckBox();
            this.checkBoxKeywords = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.labelTratamientoAplicado = new System.Windows.Forms.Label();
            this.checkBoxEliminarLinks = new System.Windows.Forms.CheckBox();
            this.checkBoxListaAbreviaturasPorDefecto = new System.Windows.Forms.CheckBox();
            this.checkBoxReemplazarAbreviatura = new System.Windows.Forms.CheckBox();
            this.buttonAplicarTratamiento = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelArchivosTxtTratamiento = new System.Windows.Forms.Label();
            this.buttonBuscarListaAbreviatura = new System.Windows.Forms.Button();
            this.textBoxDireccionAbreviaturas = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPreprocesadoAplicado = new System.Windows.Forms.Label();
            this.tabControlConfiguraciones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPreprocesar
            // 
            this.buttonPreprocesar.Location = new System.Drawing.Point(878, 364);
            this.buttonPreprocesar.Name = "buttonPreprocesar";
            this.buttonPreprocesar.Size = new System.Drawing.Size(116, 23);
            this.buttonPreprocesar.TabIndex = 0;
            this.buttonPreprocesar.Text = "Pre-procesar";
            this.buttonPreprocesar.UseVisualStyleBackColor = true;
            this.buttonPreprocesar.Click += new System.EventHandler(this.buttonPreprocesar_Click);
            // 
            // listViewPreprocesamientos
            // 
            this.listViewPreprocesamientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderListaSeleccion});
            this.listViewPreprocesamientos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPreprocesamientos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.listViewPreprocesamientos.Location = new System.Drawing.Point(365, 91);
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
            this.columnHeaderListaSeleccion.Text = "Pre-procesamientos";
            this.columnHeaderListaSeleccion.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione de la siguiente lista\r\nlos diferentes pre-procesados,\r\nluego debera co" +
    "nfigurar\r\nlos mismos segun corresponda.";
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(535, 143);
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
            this.listViewOrdenPreprocesos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem15});
            this.listViewOrdenPreprocesos.Location = new System.Drawing.Point(750, 91);
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
            this.columnHeader1.Text = "Orden de Pre-procesos";
            this.columnHeader1.Width = 150;
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.Location = new System.Drawing.Point(535, 172);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitar.TabIndex = 7;
            this.buttonQuitar.Text = "Quitar";
            this.buttonQuitar.UseVisualStyleBackColor = true;
            this.buttonQuitar.Click += new System.EventHandler(this.buttonQuitar_Click);
            // 
            // buttonSubir
            // 
            this.buttonSubir.Location = new System.Drawing.Point(919, 143);
            this.buttonSubir.Name = "buttonSubir";
            this.buttonSubir.Size = new System.Drawing.Size(75, 23);
            this.buttonSubir.TabIndex = 9;
            this.buttonSubir.Text = "Subir";
            this.buttonSubir.UseVisualStyleBackColor = true;
            this.buttonSubir.Click += new System.EventHandler(this.buttonSubir_Click);
            // 
            // buttonBajar
            // 
            this.buttonBajar.Location = new System.Drawing.Point(919, 172);
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
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Configuracion de Pre-procesado";
            // 
            // buttonBuscarListStopWords
            // 
            this.buttonBuscarListStopWords.Location = new System.Drawing.Point(552, 19);
            this.buttonBuscarListStopWords.Name = "buttonBuscarListStopWords";
            this.buttonBuscarListStopWords.Size = new System.Drawing.Size(94, 23);
            this.buttonBuscarListStopWords.TabIndex = 4;
            this.buttonBuscarListStopWords.Text = "Buscar Lista";
            this.buttonBuscarListStopWords.UseVisualStyleBackColor = true;
            this.buttonBuscarListStopWords.Click += new System.EventHandler(this.buttonBuscarListStopWords_Click);
            // 
            // textBoxDireccionStopWords
            // 
            this.textBoxDireccionStopWords.Location = new System.Drawing.Point(201, 21);
            this.textBoxDireccionStopWords.Name = "textBoxDireccionStopWords";
            this.textBoxDireccionStopWords.Size = new System.Drawing.Size(345, 20);
            this.textBoxDireccionStopWords.TabIndex = 3;
            // 
            // checkBoxListaStopWordsPorDefecto
            // 
            this.checkBoxListaStopWordsPorDefecto.AutoSize = true;
            this.checkBoxListaStopWordsPorDefecto.Checked = true;
            this.checkBoxListaStopWordsPorDefecto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxListaStopWordsPorDefecto.Location = new System.Drawing.Point(129, 52);
            this.checkBoxListaStopWordsPorDefecto.Name = "checkBoxListaStopWordsPorDefecto";
            this.checkBoxListaStopWordsPorDefecto.Size = new System.Drawing.Size(15, 14);
            this.checkBoxListaStopWordsPorDefecto.TabIndex = 2;
            this.checkBoxListaStopWordsPorDefecto.UseVisualStyleBackColor = true;
            this.checkBoxListaStopWordsPorDefecto.CheckedChanged += new System.EventHandler(this.checkBoxListaStopWordsDefecto_CheckedChanged);
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
            this.label5.Location = new System.Drawing.Point(19, 24);
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
            this.label4.Size = new System.Drawing.Size(289, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Este pre-proceso no necesita una configuración específica.";
            // 
            // tabControlConfiguraciones
            // 
            this.tabControlConfiguraciones.Controls.Add(this.tabPage1);
            this.tabControlConfiguraciones.Controls.Add(this.tabPage2);
            this.tabControlConfiguraciones.Controls.Add(this.tabPage3);
            this.tabControlConfiguraciones.Controls.Add(this.tabPage4);
            this.tabControlConfiguraciones.Controls.Add(this.tabPage5);
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
            this.tabPage2.Controls.Add(this.labelListaAplicadaStopWords);
            this.tabPage2.Controls.Add(this.buttonAplicarListaStopWords);
            this.tabPage2.Controls.Add(this.labelArchivosTxtStopWords);
            this.tabPage2.Controls.Add(this.buttonBuscarListStopWords);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxDireccionStopWords);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.checkBoxListaStopWordsPorDefecto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stop Words";
            // 
            // labelListaAplicadaStopWords
            // 
            this.labelListaAplicadaStopWords.AutoSize = true;
            this.labelListaAplicadaStopWords.ForeColor = System.Drawing.Color.Green;
            this.labelListaAplicadaStopWords.Location = new System.Drawing.Point(533, 173);
            this.labelListaAplicadaStopWords.Name = "labelListaAplicadaStopWords";
            this.labelListaAplicadaStopWords.Size = new System.Drawing.Size(73, 13);
            this.labelListaAplicadaStopWords.TabIndex = 7;
            this.labelListaAplicadaStopWords.Text = "Lista Aplicada";
            this.labelListaAplicadaStopWords.Visible = false;
            // 
            // buttonAplicarListaStopWords
            // 
            this.buttonAplicarListaStopWords.Location = new System.Drawing.Point(492, 144);
            this.buttonAplicarListaStopWords.Name = "buttonAplicarListaStopWords";
            this.buttonAplicarListaStopWords.Size = new System.Drawing.Size(154, 23);
            this.buttonAplicarListaStopWords.TabIndex = 6;
            this.buttonAplicarListaStopWords.Text = "Aplicar Lista";
            this.buttonAplicarListaStopWords.UseVisualStyleBackColor = true;
            this.buttonAplicarListaStopWords.Click += new System.EventHandler(this.buttonAplicarListaStopWords_Click);
            // 
            // labelArchivosTxtStopWords
            // 
            this.labelArchivosTxtStopWords.AutoSize = true;
            this.labelArchivosTxtStopWords.ForeColor = System.Drawing.Color.Gray;
            this.labelArchivosTxtStopWords.Location = new System.Drawing.Point(558, 51);
            this.labelArchivosTxtStopWords.Name = "labelArchivosTxtStopWords";
            this.labelArchivosTxtStopWords.Size = new System.Drawing.Size(85, 13);
            this.labelArchivosTxtStopWords.TabIndex = 5;
            this.labelArchivosTxtStopWords.Text = "Solo archivos txt";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.checkBoxERPorDefecto);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.labelExpresionRegularAplicada);
            this.tabPage3.Controls.Add(this.buttonAplicarExpresionRegular);
            this.tabPage3.Controls.Add(this.textBoxExpresionRegular);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(656, 198);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tokenization";
            // 
            // checkBoxERPorDefecto
            // 
            this.checkBoxERPorDefecto.AutoSize = true;
            this.checkBoxERPorDefecto.Checked = true;
            this.checkBoxERPorDefecto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxERPorDefecto.Location = new System.Drawing.Point(191, 52);
            this.checkBoxERPorDefecto.Name = "checkBoxERPorDefecto";
            this.checkBoxERPorDefecto.Size = new System.Drawing.Size(15, 14);
            this.checkBoxERPorDefecto.TabIndex = 5;
            this.checkBoxERPorDefecto.UseVisualStyleBackColor = true;
            this.checkBoxERPorDefecto.CheckedChanged += new System.EventHandler(this.checkBoxERPorDefecto_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Usar expresión regular por defecto ";
            // 
            // labelExpresionRegularAplicada
            // 
            this.labelExpresionRegularAplicada.AutoSize = true;
            this.labelExpresionRegularAplicada.ForeColor = System.Drawing.Color.Green;
            this.labelExpresionRegularAplicada.Location = new System.Drawing.Point(500, 173);
            this.labelExpresionRegularAplicada.Name = "labelExpresionRegularAplicada";
            this.labelExpresionRegularAplicada.Size = new System.Drawing.Size(137, 13);
            this.labelExpresionRegularAplicada.TabIndex = 3;
            this.labelExpresionRegularAplicada.Text = "Expresión Regular Aplicada";
            this.labelExpresionRegularAplicada.Visible = false;
            // 
            // buttonAplicarExpresionRegular
            // 
            this.buttonAplicarExpresionRegular.Location = new System.Drawing.Point(492, 144);
            this.buttonAplicarExpresionRegular.Name = "buttonAplicarExpresionRegular";
            this.buttonAplicarExpresionRegular.Size = new System.Drawing.Size(154, 23);
            this.buttonAplicarExpresionRegular.TabIndex = 2;
            this.buttonAplicarExpresionRegular.Text = "Aplicar Expresión Regular";
            this.buttonAplicarExpresionRegular.UseVisualStyleBackColor = true;
            this.buttonAplicarExpresionRegular.Click += new System.EventHandler(this.buttonAplicarExpresionRegular_Click);
            // 
            // textBoxExpresionRegular
            // 
            this.textBoxExpresionRegular.Location = new System.Drawing.Point(269, 20);
            this.textBoxExpresionRegular.Name = "textBoxExpresionRegular";
            this.textBoxExpresionRegular.Size = new System.Drawing.Size(377, 20);
            this.textBoxExpresionRegular.TabIndex = 1;
            this.textBoxExpresionRegular.TextChanged += new System.EventHandler(this.textBoxExpresionRegular_TextChanged);
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
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.checkBoxDescripcion);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.labelEnriquecimientoAplicado);
            this.tabPage4.Controls.Add(this.buttonAplicarEnriquecimiento);
            this.tabPage4.Controls.Add(this.checkBoxTitulo);
            this.tabPage4.Controls.Add(this.checkBoxKeywords);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(656, 198);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Enriquecimiento";
            // 
            // checkBoxDescripcion
            // 
            this.checkBoxDescripcion.AutoSize = true;
            this.checkBoxDescripcion.Checked = true;
            this.checkBoxDescripcion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescripcion.Location = new System.Drawing.Point(140, 68);
            this.checkBoxDescripcion.Name = "checkBoxDescripcion";
            this.checkBoxDescripcion.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDescripcion.TabIndex = 23;
            this.checkBoxDescripcion.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Descripción";
            // 
            // labelEnriquecimientoAplicado
            // 
            this.labelEnriquecimientoAplicado.AutoSize = true;
            this.labelEnriquecimientoAplicado.ForeColor = System.Drawing.Color.Green;
            this.labelEnriquecimientoAplicado.Location = new System.Drawing.Point(505, 173);
            this.labelEnriquecimientoAplicado.Name = "labelEnriquecimientoAplicado";
            this.labelEnriquecimientoAplicado.Size = new System.Drawing.Size(126, 13);
            this.labelEnriquecimientoAplicado.TabIndex = 21;
            this.labelEnriquecimientoAplicado.Text = "Enriquecimiento Aplicado";
            this.labelEnriquecimientoAplicado.Visible = false;
            // 
            // buttonAplicarEnriquecimiento
            // 
            this.buttonAplicarEnriquecimiento.Location = new System.Drawing.Point(492, 144);
            this.buttonAplicarEnriquecimiento.Name = "buttonAplicarEnriquecimiento";
            this.buttonAplicarEnriquecimiento.Size = new System.Drawing.Size(154, 23);
            this.buttonAplicarEnriquecimiento.TabIndex = 20;
            this.buttonAplicarEnriquecimiento.Text = "Aplicar Enriquecimiento";
            this.buttonAplicarEnriquecimiento.UseVisualStyleBackColor = true;
            this.buttonAplicarEnriquecimiento.Click += new System.EventHandler(this.buttonAplicarEnriquecimiento_Click);
            // 
            // checkBoxTitulo
            // 
            this.checkBoxTitulo.AutoSize = true;
            this.checkBoxTitulo.Checked = true;
            this.checkBoxTitulo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTitulo.Location = new System.Drawing.Point(140, 52);
            this.checkBoxTitulo.Name = "checkBoxTitulo";
            this.checkBoxTitulo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTitulo.TabIndex = 12;
            this.checkBoxTitulo.UseVisualStyleBackColor = true;
            // 
            // checkBoxKeywords
            // 
            this.checkBoxKeywords.AutoSize = true;
            this.checkBoxKeywords.Checked = true;
            this.checkBoxKeywords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxKeywords.Location = new System.Drawing.Point(140, 36);
            this.checkBoxKeywords.Name = "checkBoxKeywords";
            this.checkBoxKeywords.Size = new System.Drawing.Size(15, 14);
            this.checkBoxKeywords.TabIndex = 11;
            this.checkBoxKeywords.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(65, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Keywords";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Título";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Agregar:";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.labelTratamientoAplicado);
            this.tabPage5.Controls.Add(this.checkBoxEliminarLinks);
            this.tabPage5.Controls.Add(this.checkBoxListaAbreviaturasPorDefecto);
            this.tabPage5.Controls.Add(this.checkBoxReemplazarAbreviatura);
            this.tabPage5.Controls.Add(this.buttonAplicarTratamiento);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.labelArchivosTxtTratamiento);
            this.tabPage5.Controls.Add(this.buttonBuscarListaAbreviatura);
            this.tabPage5.Controls.Add(this.textBoxDireccionAbreviaturas);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(656, 198);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tratamiento en Texto";
            // 
            // labelTratamientoAplicado
            // 
            this.labelTratamientoAplicado.AutoSize = true;
            this.labelTratamientoAplicado.ForeColor = System.Drawing.Color.Green;
            this.labelTratamientoAplicado.Location = new System.Drawing.Point(515, 173);
            this.labelTratamientoAplicado.Name = "labelTratamientoAplicado";
            this.labelTratamientoAplicado.Size = new System.Drawing.Size(107, 13);
            this.labelTratamientoAplicado.TabIndex = 15;
            this.labelTratamientoAplicado.Text = "Tratamiento Aplicado";
            this.labelTratamientoAplicado.Visible = false;
            // 
            // checkBoxEliminarLinks
            // 
            this.checkBoxEliminarLinks.AutoSize = true;
            this.checkBoxEliminarLinks.Location = new System.Drawing.Point(149, 115);
            this.checkBoxEliminarLinks.Name = "checkBoxEliminarLinks";
            this.checkBoxEliminarLinks.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEliminarLinks.TabIndex = 12;
            this.checkBoxEliminarLinks.UseVisualStyleBackColor = true;
            // 
            // checkBoxListaAbreviaturasPorDefecto
            // 
            this.checkBoxListaAbreviaturasPorDefecto.AutoSize = true;
            this.checkBoxListaAbreviaturasPorDefecto.Checked = true;
            this.checkBoxListaAbreviaturasPorDefecto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxListaAbreviaturasPorDefecto.Location = new System.Drawing.Point(161, 74);
            this.checkBoxListaAbreviaturasPorDefecto.Name = "checkBoxListaAbreviaturasPorDefecto";
            this.checkBoxListaAbreviaturasPorDefecto.Size = new System.Drawing.Size(15, 14);
            this.checkBoxListaAbreviaturasPorDefecto.TabIndex = 11;
            this.checkBoxListaAbreviaturasPorDefecto.UseVisualStyleBackColor = true;
            this.checkBoxListaAbreviaturasPorDefecto.CheckedChanged += new System.EventHandler(this.checkBoxListaAbreviaturasDefecto_CheckedChanged);
            // 
            // checkBoxReemplazarAbreviatura
            // 
            this.checkBoxReemplazarAbreviatura.AutoSize = true;
            this.checkBoxReemplazarAbreviatura.Checked = true;
            this.checkBoxReemplazarAbreviatura.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxReemplazarAbreviatura.Location = new System.Drawing.Point(149, 24);
            this.checkBoxReemplazarAbreviatura.Name = "checkBoxReemplazarAbreviatura";
            this.checkBoxReemplazarAbreviatura.Size = new System.Drawing.Size(15, 14);
            this.checkBoxReemplazarAbreviatura.TabIndex = 10;
            this.checkBoxReemplazarAbreviatura.UseVisualStyleBackColor = true;
            this.checkBoxReemplazarAbreviatura.CheckedChanged += new System.EventHandler(this.checkBoxReemplazarAbreviatura_CheckedChanged);
            // 
            // buttonAplicarTratamiento
            // 
            this.buttonAplicarTratamiento.Location = new System.Drawing.Point(492, 144);
            this.buttonAplicarTratamiento.Name = "buttonAplicarTratamiento";
            this.buttonAplicarTratamiento.Size = new System.Drawing.Size(154, 23);
            this.buttonAplicarTratamiento.TabIndex = 9;
            this.buttonAplicarTratamiento.Text = "Aplicar Tratamiento";
            this.buttonAplicarTratamiento.UseVisualStyleBackColor = true;
            this.buttonAplicarTratamiento.Click += new System.EventHandler(this.buttonAplicarTratamiento_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 47);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(179, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Seleccione una lista de Abreviaturas";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(50, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(110, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Usar lista por defecto ";
            // 
            // labelArchivosTxtTratamiento
            // 
            this.labelArchivosTxtTratamiento.AutoSize = true;
            this.labelArchivosTxtTratamiento.ForeColor = System.Drawing.Color.Gray;
            this.labelArchivosTxtTratamiento.Location = new System.Drawing.Point(558, 74);
            this.labelArchivosTxtTratamiento.Name = "labelArchivosTxtTratamiento";
            this.labelArchivosTxtTratamiento.Size = new System.Drawing.Size(85, 13);
            this.labelArchivosTxtTratamiento.TabIndex = 6;
            this.labelArchivosTxtTratamiento.Text = "Solo archivos txt";
            // 
            // buttonBuscarListaAbreviatura
            // 
            this.buttonBuscarListaAbreviatura.Enabled = false;
            this.buttonBuscarListaAbreviatura.Location = new System.Drawing.Point(552, 42);
            this.buttonBuscarListaAbreviatura.Name = "buttonBuscarListaAbreviatura";
            this.buttonBuscarListaAbreviatura.Size = new System.Drawing.Size(94, 23);
            this.buttonBuscarListaAbreviatura.TabIndex = 5;
            this.buttonBuscarListaAbreviatura.Text = "Buscar Lista";
            this.buttonBuscarListaAbreviatura.UseVisualStyleBackColor = true;
            this.buttonBuscarListaAbreviatura.Click += new System.EventHandler(this.buttonBuscarListaAbreviatura_Click);
            // 
            // textBoxDireccionAbreviaturas
            // 
            this.textBoxDireccionAbreviaturas.Enabled = false;
            this.textBoxDireccionAbreviaturas.Location = new System.Drawing.Point(231, 44);
            this.textBoxDireccionAbreviaturas.Name = "textBoxDireccionAbreviaturas";
            this.textBoxDireccionAbreviaturas.Size = new System.Drawing.Size(315, 20);
            this.textBoxDireccionAbreviaturas.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Reemplazar abreviaturas";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Eliminar links";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(650, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 52);
            this.label10.TabIndex = 15;
            this.label10.Text = "Seleccione de la\r\nsiguiente lista para\r\nacceder a su\r\nconfiguración.";
            // 
            // labelPreprocesadoAplicado
            // 
            this.labelPreprocesadoAplicado.AutoSize = true;
            this.labelPreprocesadoAplicado.ForeColor = System.Drawing.Color.Green;
            this.labelPreprocesadoAplicado.Location = new System.Drawing.Point(877, 396);
            this.labelPreprocesadoAplicado.Name = "labelPreprocesadoAplicado";
            this.labelPreprocesadoAplicado.Size = new System.Drawing.Size(120, 13);
            this.labelPreprocesadoAplicado.TabIndex = 16;
            this.labelPreprocesadoAplicado.Text = "Pre-procesado Aplicado";
            this.labelPreprocesadoAplicado.Visible = false;
            // 
            // FormPreprocesamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.labelPreprocesadoAplicado);
            this.Controls.Add(this.label10);
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBoxListaStopWordsPorDefecto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBuscarListStopWords;
        private System.Windows.Forms.TextBox textBoxDireccionStopWords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControlConfiguraciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelArchivosTxtStopWords;
        private System.Windows.Forms.TextBox textBoxExpresionRegular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAplicarListaStopWords;
        private System.Windows.Forms.Button buttonAplicarExpresionRegular;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBoxKeywords;
        private System.Windows.Forms.Button buttonAplicarEnriquecimiento;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonBuscarListaAbreviatura;
        private System.Windows.Forms.TextBox textBoxDireccionAbreviaturas;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelArchivosTxtTratamiento;
        private System.Windows.Forms.CheckBox checkBoxReemplazarAbreviatura;
        private System.Windows.Forms.Button buttonAplicarTratamiento;
        private System.Windows.Forms.CheckBox checkBoxListaAbreviaturasPorDefecto;
        private System.Windows.Forms.CheckBox checkBoxEliminarLinks;
        private System.Windows.Forms.CheckBox checkBoxTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelListaAplicadaStopWords;
        private System.Windows.Forms.Label labelExpresionRegularAplicada;
        private System.Windows.Forms.Label labelEnriquecimientoAplicado;
        private System.Windows.Forms.Label labelTratamientoAplicado;
        private System.Windows.Forms.CheckBox checkBoxERPorDefecto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelPreprocesadoAplicado;
        private System.Windows.Forms.CheckBox checkBoxDescripcion;
        private System.Windows.Forms.Label label12;

    }
}