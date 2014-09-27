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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Enriquecimiento");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Stemmer");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Stop Words");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Tokenizacion");
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
            this.buttonAplicarListaStopWords = new System.Windows.Forms.Button();
            this.labelArchivosTxt = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonAplicarExpresionRegular = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBoxMetaTagsComunes = new System.Windows.Forms.CheckBox();
            this.checkBoxMetaTagsOpenGraph = new System.Windows.Forms.CheckBox();
            this.checkBoxSiteMaps = new System.Windows.Forms.CheckBox();
            this.checkBoxAreaLabels = new System.Windows.Forms.CheckBox();
            this.checkBoxMicroformats = new System.Windows.Forms.CheckBox();
            this.checkBoxFamiliaHs = new System.Windows.Forms.CheckBox();
            this.checkBoxNegrita = new System.Windows.Forms.CheckBox();
            this.checkBoxCursiva = new System.Windows.Forms.CheckBox();
            this.checkBoxOrden = new System.Windows.Forms.CheckBox();
            this.buttonAplicarEnriquecimiento = new System.Windows.Forms.Button();
            this.tabControlConfiguraciones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            listViewItem3,
            listViewItem4});
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
            this.tabControlConfiguraciones.Controls.Add(this.tabPage4);
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
            // buttonAplicarListaStopWords
            // 
            this.buttonAplicarListaStopWords.Location = new System.Drawing.Point(492, 159);
            this.buttonAplicarListaStopWords.Name = "buttonAplicarListaStopWords";
            this.buttonAplicarListaStopWords.Size = new System.Drawing.Size(154, 23);
            this.buttonAplicarListaStopWords.TabIndex = 6;
            this.buttonAplicarListaStopWords.Text = "Aplicar Lista";
            this.buttonAplicarListaStopWords.UseVisualStyleBackColor = true;
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
            // buttonAplicarExpresionRegular
            // 
            this.buttonAplicarExpresionRegular.Location = new System.Drawing.Point(492, 159);
            this.buttonAplicarExpresionRegular.Name = "buttonAplicarExpresionRegular";
            this.buttonAplicarExpresionRegular.Size = new System.Drawing.Size(154, 23);
            this.buttonAplicarExpresionRegular.TabIndex = 2;
            this.buttonAplicarExpresionRegular.Text = "Aplicar Expresión Regular";
            this.buttonAplicarExpresionRegular.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 20);
            this.textBox1.TabIndex = 1;
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
            this.tabPage4.Controls.Add(this.buttonAplicarEnriquecimiento);
            this.tabPage4.Controls.Add(this.checkBoxOrden);
            this.tabPage4.Controls.Add(this.checkBoxCursiva);
            this.tabPage4.Controls.Add(this.checkBoxNegrita);
            this.tabPage4.Controls.Add(this.checkBoxFamiliaHs);
            this.tabPage4.Controls.Add(this.checkBoxMicroformats);
            this.tabPage4.Controls.Add(this.checkBoxAreaLabels);
            this.tabPage4.Controls.Add(this.checkBoxSiteMaps);
            this.tabPage4.Controls.Add(this.checkBoxMetaTagsOpenGraph);
            this.tabPage4.Controls.Add(this.checkBoxMetaTagsComunes);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(656, 198);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Enriquecimiento";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "META-TAGS OPEN GRAPH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "SITE MAPS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "AREA LABELS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "MICROFORMATS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Palabras en Negrita";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(394, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Palabras en Cursiva";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(65, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Familia de H\'s (H1-H2-H3)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(65, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "META-TAGS comunes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(333, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Contemplar:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(394, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Orden de Aparición";
            // 
            // checkBoxMetaTagsComunes
            // 
            this.checkBoxMetaTagsComunes.AutoSize = true;
            this.checkBoxMetaTagsComunes.Location = new System.Drawing.Point(220, 36);
            this.checkBoxMetaTagsComunes.Name = "checkBoxMetaTagsComunes";
            this.checkBoxMetaTagsComunes.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMetaTagsComunes.TabIndex = 11;
            this.checkBoxMetaTagsComunes.UseVisualStyleBackColor = true;
            // 
            // checkBoxMetaTagsOpenGraph
            // 
            this.checkBoxMetaTagsOpenGraph.AutoSize = true;
            this.checkBoxMetaTagsOpenGraph.Location = new System.Drawing.Point(220, 52);
            this.checkBoxMetaTagsOpenGraph.Name = "checkBoxMetaTagsOpenGraph";
            this.checkBoxMetaTagsOpenGraph.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMetaTagsOpenGraph.TabIndex = 12;
            this.checkBoxMetaTagsOpenGraph.UseVisualStyleBackColor = true;
            // 
            // checkBoxSiteMaps
            // 
            this.checkBoxSiteMaps.AutoSize = true;
            this.checkBoxSiteMaps.Location = new System.Drawing.Point(220, 68);
            this.checkBoxSiteMaps.Name = "checkBoxSiteMaps";
            this.checkBoxSiteMaps.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSiteMaps.TabIndex = 13;
            this.checkBoxSiteMaps.UseVisualStyleBackColor = true;
            // 
            // checkBoxAreaLabels
            // 
            this.checkBoxAreaLabels.AutoSize = true;
            this.checkBoxAreaLabels.Location = new System.Drawing.Point(220, 84);
            this.checkBoxAreaLabels.Name = "checkBoxAreaLabels";
            this.checkBoxAreaLabels.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAreaLabels.TabIndex = 14;
            this.checkBoxAreaLabels.UseVisualStyleBackColor = true;
            // 
            // checkBoxMicroformats
            // 
            this.checkBoxMicroformats.AutoSize = true;
            this.checkBoxMicroformats.Location = new System.Drawing.Point(220, 100);
            this.checkBoxMicroformats.Name = "checkBoxMicroformats";
            this.checkBoxMicroformats.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMicroformats.TabIndex = 15;
            this.checkBoxMicroformats.UseVisualStyleBackColor = true;
            // 
            // checkBoxFamiliaHs
            // 
            this.checkBoxFamiliaHs.AutoSize = true;
            this.checkBoxFamiliaHs.Location = new System.Drawing.Point(220, 116);
            this.checkBoxFamiliaHs.Name = "checkBoxFamiliaHs";
            this.checkBoxFamiliaHs.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFamiliaHs.TabIndex = 16;
            this.checkBoxFamiliaHs.UseVisualStyleBackColor = true;
            // 
            // checkBoxNegrita
            // 
            this.checkBoxNegrita.AutoSize = true;
            this.checkBoxNegrita.Location = new System.Drawing.Point(509, 36);
            this.checkBoxNegrita.Name = "checkBoxNegrita";
            this.checkBoxNegrita.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNegrita.TabIndex = 17;
            this.checkBoxNegrita.UseVisualStyleBackColor = true;
            // 
            // checkBoxCursiva
            // 
            this.checkBoxCursiva.AutoSize = true;
            this.checkBoxCursiva.Location = new System.Drawing.Point(509, 52);
            this.checkBoxCursiva.Name = "checkBoxCursiva";
            this.checkBoxCursiva.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCursiva.TabIndex = 18;
            this.checkBoxCursiva.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrden
            // 
            this.checkBoxOrden.AutoSize = true;
            this.checkBoxOrden.Location = new System.Drawing.Point(509, 68);
            this.checkBoxOrden.Name = "checkBoxOrden";
            this.checkBoxOrden.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOrden.TabIndex = 19;
            this.checkBoxOrden.UseVisualStyleBackColor = true;
            // 
            // buttonAplicarEnriquecimiento
            // 
            this.buttonAplicarEnriquecimiento.Location = new System.Drawing.Point(492, 159);
            this.buttonAplicarEnriquecimiento.Name = "buttonAplicarEnriquecimiento";
            this.buttonAplicarEnriquecimiento.Size = new System.Drawing.Size(154, 23);
            this.buttonAplicarEnriquecimiento.TabIndex = 20;
            this.buttonAplicarEnriquecimiento.Text = "Aplicar Enriquecimiento";
            this.buttonAplicarEnriquecimiento.UseVisualStyleBackColor = true;
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxOrden;
        private System.Windows.Forms.CheckBox checkBoxCursiva;
        private System.Windows.Forms.CheckBox checkBoxNegrita;
        private System.Windows.Forms.CheckBox checkBoxFamiliaHs;
        private System.Windows.Forms.CheckBox checkBoxMicroformats;
        private System.Windows.Forms.CheckBox checkBoxAreaLabels;
        private System.Windows.Forms.CheckBox checkBoxSiteMaps;
        private System.Windows.Forms.CheckBox checkBoxMetaTagsOpenGraph;
        private System.Windows.Forms.CheckBox checkBoxMetaTagsComunes;
        private System.Windows.Forms.Button buttonAplicarEnriquecimiento;

    }
}