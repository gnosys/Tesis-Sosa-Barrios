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
            this.dataGridViewTuplas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tweet_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entity_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonMostrarTuplas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectCantTuplas = new System.Windows.Forms.TextBox();
            this.buttonMostrarCategorias = new System.Windows.Forms.Button();
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectCantDatos = new System.Windows.Forms.TextBox();
            this.panelDataBase = new System.Windows.Forms.Panel();
            this.panelSeleccionarCategoria = new System.Windows.Forms.Panel();
            this.dataGridViewCategoriasCreadas = new System.Windows.Forms.DataGridView();
            this.IdC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSeleccionandoNivel = new System.Windows.Forms.Label();
            this.labelCalculandoNiveles = new System.Windows.Forms.Label();
            this.labelNivelesCalculados = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonCalcularNiveles = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonCrearCategorias = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.labelCantidadNiveles = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listBoxCategoriasNivel = new System.Windows.Forms.ListBox();
            this.buttonSeleccionarNivel = new System.Windows.Forms.Button();
            this.textBoxSeleccionarNivel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMostrarTextos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelConeccionFallida = new System.Windows.Forms.Label();
            this.labelConeccionEstablecida = new System.Windows.Forms.Label();
            this.buttonComprobarConeccion = new System.Windows.Forms.Button();
            this.textBoxConeccionSQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDataBase = new System.Windows.Forms.Button();
            this.buttonStopWords = new System.Windows.Forms.Button();
            this.buttonStemmer = new System.Windows.Forms.Button();
            this.buttonSeleccionarCategoria = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonActualizarTweets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuplas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            this.panelDataBase.SuspendLayout();
            this.panelSeleccionarCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoriasCreadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTuplas
            // 
            this.dataGridViewTuplas.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dataGridViewTuplas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTuplas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tweet_Id,
            this.Author,
            this.Entity_Id,
            this.Category,
            this.Texto,
            this.Id_Category});
            this.dataGridViewTuplas.Location = new System.Drawing.Point(17, 91);
            this.dataGridViewTuplas.Name = "dataGridViewTuplas";
            this.dataGridViewTuplas.Size = new System.Drawing.Size(743, 204);
            this.dataGridViewTuplas.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Tweet_Id
            // 
            this.Tweet_Id.HeaderText = "Tweet_Id";
            this.Tweet_Id.Name = "Tweet_Id";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // Entity_Id
            // 
            this.Entity_Id.HeaderText = "Entity_Id";
            this.Entity_Id.Name = "Entity_Id";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Texto
            // 
            this.Texto.HeaderText = "Text";
            this.Texto.Name = "Texto";
            // 
            // Id_Category
            // 
            this.Id_Category.HeaderText = "Id_Category";
            this.Id_Category.Name = "Id_Category";
            // 
            // buttonMostrarTuplas
            // 
            this.buttonMostrarTuplas.Enabled = false;
            this.buttonMostrarTuplas.Location = new System.Drawing.Point(357, 60);
            this.buttonMostrarTuplas.Name = "buttonMostrarTuplas";
            this.buttonMostrarTuplas.Size = new System.Drawing.Size(103, 23);
            this.buttonMostrarTuplas.TabIndex = 1;
            this.buttonMostrarTuplas.Text = "Mostrar Tuplas";
            this.buttonMostrarTuplas.UseVisualStyleBackColor = true;
            this.buttonMostrarTuplas.Click += new System.EventHandler(this.buttonMostrarTuplas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese cantidad de tuplas a mostrar";
            // 
            // SelectCantTuplas
            // 
            this.SelectCantTuplas.Enabled = false;
            this.SelectCantTuplas.Location = new System.Drawing.Point(200, 62);
            this.SelectCantTuplas.Name = "SelectCantTuplas";
            this.SelectCantTuplas.Size = new System.Drawing.Size(36, 20);
            this.SelectCantTuplas.TabIndex = 3;
            // 
            // buttonMostrarCategorias
            // 
            this.buttonMostrarCategorias.Enabled = false;
            this.buttonMostrarCategorias.Location = new System.Drawing.Point(357, 312);
            this.buttonMostrarCategorias.Name = "buttonMostrarCategorias";
            this.buttonMostrarCategorias.Size = new System.Drawing.Size(103, 23);
            this.buttonMostrarCategorias.TabIndex = 4;
            this.buttonMostrarCategorias.Text = "Mostrar Categorias";
            this.buttonMostrarCategorias.UseVisualStyleBackColor = true;
            this.buttonMostrarCategorias.Click += new System.EventHandler(this.buttonMostrarCategorias_Click);
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.Location = new System.Drawing.Point(17, 343);
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.Size = new System.Drawing.Size(743, 204);
            this.dataGridViewDatos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese cantidad de datos en tuplas a mostrar";
            // 
            // SelectCantDatos
            // 
            this.SelectCantDatos.Enabled = false;
            this.SelectCantDatos.Location = new System.Drawing.Point(244, 314);
            this.SelectCantDatos.Name = "SelectCantDatos";
            this.SelectCantDatos.Size = new System.Drawing.Size(36, 20);
            this.SelectCantDatos.TabIndex = 7;
            // 
            // panelDataBase
            // 
            this.panelDataBase.Controls.Add(this.panelSeleccionarCategoria);
            this.panelDataBase.Controls.Add(this.label6);
            this.panelDataBase.Controls.Add(this.label5);
            this.panelDataBase.Controls.Add(this.buttonMostrarTextos);
            this.panelDataBase.Controls.Add(this.label4);
            this.panelDataBase.Controls.Add(this.labelConeccionFallida);
            this.panelDataBase.Controls.Add(this.labelConeccionEstablecida);
            this.panelDataBase.Controls.Add(this.buttonComprobarConeccion);
            this.panelDataBase.Controls.Add(this.textBoxConeccionSQL);
            this.panelDataBase.Controls.Add(this.label3);
            this.panelDataBase.Controls.Add(this.label1);
            this.panelDataBase.Controls.Add(this.dataGridViewDatos);
            this.panelDataBase.Controls.Add(this.SelectCantDatos);
            this.panelDataBase.Controls.Add(this.buttonMostrarCategorias);
            this.panelDataBase.Controls.Add(this.SelectCantTuplas);
            this.panelDataBase.Controls.Add(this.label2);
            this.panelDataBase.Controls.Add(this.buttonMostrarTuplas);
            this.panelDataBase.Controls.Add(this.dataGridViewTuplas);
            this.panelDataBase.Location = new System.Drawing.Point(162, 5);
            this.panelDataBase.Name = "panelDataBase";
            this.panelDataBase.Size = new System.Drawing.Size(836, 552);
            this.panelDataBase.TabIndex = 8;
            this.panelDataBase.Visible = false;
            // 
            // panelSeleccionarCategoria
            // 
            this.panelSeleccionarCategoria.Controls.Add(this.buttonActualizarTweets);
            this.panelSeleccionarCategoria.Controls.Add(this.dataGridViewCategoriasCreadas);
            this.panelSeleccionarCategoria.Controls.Add(this.labelSeleccionandoNivel);
            this.panelSeleccionarCategoria.Controls.Add(this.labelCalculandoNiveles);
            this.panelSeleccionarCategoria.Controls.Add(this.labelNivelesCalculados);
            this.panelSeleccionarCategoria.Controls.Add(this.label16);
            this.panelSeleccionarCategoria.Controls.Add(this.buttonCalcularNiveles);
            this.panelSeleccionarCategoria.Controls.Add(this.label18);
            this.panelSeleccionarCategoria.Controls.Add(this.buttonCrearCategorias);
            this.panelSeleccionarCategoria.Controls.Add(this.label17);
            this.panelSeleccionarCategoria.Controls.Add(this.labelCantidadNiveles);
            this.panelSeleccionarCategoria.Controls.Add(this.label15);
            this.panelSeleccionarCategoria.Controls.Add(this.label14);
            this.panelSeleccionarCategoria.Controls.Add(this.listBoxCategoriasNivel);
            this.panelSeleccionarCategoria.Controls.Add(this.buttonSeleccionarNivel);
            this.panelSeleccionarCategoria.Controls.Add(this.textBoxSeleccionarNivel);
            this.panelSeleccionarCategoria.Controls.Add(this.label13);
            this.panelSeleccionarCategoria.Controls.Add(this.label12);
            this.panelSeleccionarCategoria.Controls.Add(this.label11);
            this.panelSeleccionarCategoria.Controls.Add(this.label10);
            this.panelSeleccionarCategoria.Location = new System.Drawing.Point(0, 0);
            this.panelSeleccionarCategoria.Name = "panelSeleccionarCategoria";
            this.panelSeleccionarCategoria.Size = new System.Drawing.Size(836, 306);
            this.panelSeleccionarCategoria.TabIndex = 17;
            this.panelSeleccionarCategoria.Visible = false;
            // 
            // dataGridViewCategoriasCreadas
            // 
            this.dataGridViewCategoriasCreadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoriasCreadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdC,
            this.Categorias});
            this.dataGridViewCategoriasCreadas.Location = new System.Drawing.Point(658, 136);
            this.dataGridViewCategoriasCreadas.Name = "dataGridViewCategoriasCreadas";
            this.dataGridViewCategoriasCreadas.Size = new System.Drawing.Size(174, 147);
            this.dataGridViewCategoriasCreadas.TabIndex = 21;
            // 
            // IdC
            // 
            this.IdC.HeaderText = "Id";
            this.IdC.Name = "IdC";
            this.IdC.Width = 30;
            // 
            // Categorias
            // 
            this.Categorias.HeaderText = "Categorias";
            this.Categorias.Name = "Categorias";
            this.Categorias.Width = 82;
            // 
            // labelSeleccionandoNivel
            // 
            this.labelSeleccionandoNivel.AutoSize = true;
            this.labelSeleccionandoNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelSeleccionandoNivel.Location = new System.Drawing.Point(259, 236);
            this.labelSeleccionandoNivel.Name = "labelSeleccionandoNivel";
            this.labelSeleccionandoNivel.Size = new System.Drawing.Size(114, 13);
            this.labelSeleccionandoNivel.TabIndex = 20;
            this.labelSeleccionandoNivel.Text = "Seleccionando Nivel...";
            this.labelSeleccionandoNivel.Visible = false;
            // 
            // labelCalculandoNiveles
            // 
            this.labelCalculandoNiveles.AutoSize = true;
            this.labelCalculandoNiveles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelCalculandoNiveles.Location = new System.Drawing.Point(259, 171);
            this.labelCalculandoNiveles.Name = "labelCalculandoNiveles";
            this.labelCalculandoNiveles.Size = new System.Drawing.Size(107, 13);
            this.labelCalculandoNiveles.TabIndex = 19;
            this.labelCalculandoNiveles.Text = "Calculando Niveles...";
            this.labelCalculandoNiveles.Visible = false;
            // 
            // labelNivelesCalculados
            // 
            this.labelNivelesCalculados.AutoSize = true;
            this.labelNivelesCalculados.ForeColor = System.Drawing.Color.Green;
            this.labelNivelesCalculados.Location = new System.Drawing.Point(158, 171);
            this.labelNivelesCalculados.Name = "labelNivelesCalculados";
            this.labelNivelesCalculados.Size = new System.Drawing.Size(97, 13);
            this.labelNivelesCalculados.TabIndex = 18;
            this.labelNivelesCalculados.Text = "Niveles Calculados";
            this.labelNivelesCalculados.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "La cantidad de niveles es";
            // 
            // buttonCalcularNiveles
            // 
            this.buttonCalcularNiveles.Enabled = false;
            this.buttonCalcularNiveles.Location = new System.Drawing.Point(259, 143);
            this.buttonCalcularNiveles.Name = "buttonCalcularNiveles";
            this.buttonCalcularNiveles.Size = new System.Drawing.Size(101, 23);
            this.buttonCalcularNiveles.TabIndex = 16;
            this.buttonCalcularNiveles.Text = "Calcular Niveles";
            this.buttonCalcularNiveles.UseVisualStyleBackColor = true;
            this.buttonCalcularNiveles.Click += new System.EventHandler(this.buttonCalcularNiveles_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 206);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(186, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Seleccionar numero de nivel existente";
            // 
            // buttonCrearCategorias
            // 
            this.buttonCrearCategorias.Enabled = false;
            this.buttonCrearCategorias.Location = new System.Drawing.Point(542, 143);
            this.buttonCrearCategorias.Name = "buttonCrearCategorias";
            this.buttonCrearCategorias.Size = new System.Drawing.Size(101, 23);
            this.buttonCrearCategorias.TabIndex = 13;
            this.buttonCrearCategorias.Text = "Crear Categorias";
            this.buttonCrearCategorias.UseVisualStyleBackColor = true;
            this.buttonCrearCategorias.Click += new System.EventHandler(this.buttonCrearCategorias_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(373, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(180, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Categorias segun nivel seleccionado";
            // 
            // labelCantidadNiveles
            // 
            this.labelCantidadNiveles.AutoSize = true;
            this.labelCantidadNiveles.Location = new System.Drawing.Point(142, 171);
            this.labelCantidadNiveles.Name = "labelCantidadNiveles";
            this.labelCantidadNiveles.Size = new System.Drawing.Size(13, 13);
            this.labelCantidadNiveles.TabIndex = 11;
            this.labelCantidadNiveles.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(241, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Calcular la cantidad de Niveles en Base de Datos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(655, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Categorias creadas";
            // 
            // listBoxCategoriasNivel
            // 
            this.listBoxCategoriasNivel.FormattingEnabled = true;
            this.listBoxCategoriasNivel.Location = new System.Drawing.Point(376, 136);
            this.listBoxCategoriasNivel.Name = "listBoxCategoriasNivel";
            this.listBoxCategoriasNivel.Size = new System.Drawing.Size(143, 147);
            this.listBoxCategoriasNivel.TabIndex = 8;
            // 
            // buttonSeleccionarNivel
            // 
            this.buttonSeleccionarNivel.Enabled = false;
            this.buttonSeleccionarNivel.Location = new System.Drawing.Point(259, 201);
            this.buttonSeleccionarNivel.Name = "buttonSeleccionarNivel";
            this.buttonSeleccionarNivel.Size = new System.Drawing.Size(101, 23);
            this.buttonSeleccionarNivel.TabIndex = 7;
            this.buttonSeleccionarNivel.Text = "Seleccionar Nivel";
            this.buttonSeleccionarNivel.UseVisualStyleBackColor = true;
            this.buttonSeleccionarNivel.Click += new System.EventHandler(this.buttonSeleccionarNivel_Click);
            // 
            // textBoxSeleccionarNivel
            // 
            this.textBoxSeleccionarNivel.Enabled = false;
            this.textBoxSeleccionarNivel.Location = new System.Drawing.Point(206, 203);
            this.textBoxSeleccionarNivel.Name = "textBoxSeleccionarNivel";
            this.textBoxSeleccionarNivel.Size = new System.Drawing.Size(36, 20);
            this.textBoxSeleccionarNivel.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label13.Location = new System.Drawing.Point(59, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(427, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Nivel 1  Nivel 2     Nivel 3       Nivel 4                 Nivel 5               " +
    "       Nivel 6          Nivel 7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(71, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(406, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "↑         ↑            ↑              ↑                        ↑                 " +
    "            ↑                 ↑";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(20, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(468, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ejemplo : Top/Computers/Internet/On_the_Web/Online_Communities/Social_Networking/" +
    "Twitter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(436, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Seleccionar nivel de categorias de acuerdo a la informacion de las tuplas en base" +
    " de datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Max 10000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Max 10000";
            // 
            // buttonMostrarTextos
            // 
            this.buttonMostrarTextos.Enabled = false;
            this.buttonMostrarTextos.Location = new System.Drawing.Point(466, 312);
            this.buttonMostrarTextos.Name = "buttonMostrarTextos";
            this.buttonMostrarTextos.Size = new System.Drawing.Size(103, 23);
            this.buttonMostrarTextos.TabIndex = 14;
            this.buttonMostrarTextos.Text = "Mostrar Textos";
            this.buttonMostrarTextos.UseVisualStyleBackColor = true;
            this.buttonMostrarTextos.Click += new System.EventHandler(this.buttonMostrarTextos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(234, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ejemplo : Data Source=NAME-PC\\SQLEXPRESS;Initial Catalog=Tweets;Integrated Securi" +
    "ty=True";
            // 
            // labelConeccionFallida
            // 
            this.labelConeccionFallida.AutoSize = true;
            this.labelConeccionFallida.ForeColor = System.Drawing.Color.Red;
            this.labelConeccionFallida.Location = new System.Drawing.Point(727, 45);
            this.labelConeccionFallida.Name = "labelConeccionFallida";
            this.labelConeccionFallida.Size = new System.Drawing.Size(91, 13);
            this.labelConeccionFallida.TabIndex = 12;
            this.labelConeccionFallida.Text = "Coneccion Fallida";
            this.labelConeccionFallida.Visible = false;
            // 
            // labelConeccionEstablecida
            // 
            this.labelConeccionEstablecida.AutoSize = true;
            this.labelConeccionEstablecida.ForeColor = System.Drawing.Color.Green;
            this.labelConeccionEstablecida.Location = new System.Drawing.Point(716, 45);
            this.labelConeccionEstablecida.Name = "labelConeccionEstablecida";
            this.labelConeccionEstablecida.Size = new System.Drawing.Size(116, 13);
            this.labelConeccionEstablecida.TabIndex = 11;
            this.labelConeccionEstablecida.Text = "Coneccion Establecida";
            this.labelConeccionEstablecida.Visible = false;
            // 
            // buttonComprobarConeccion
            // 
            this.buttonComprobarConeccion.Location = new System.Drawing.Point(713, 13);
            this.buttonComprobarConeccion.Name = "buttonComprobarConeccion";
            this.buttonComprobarConeccion.Size = new System.Drawing.Size(120, 23);
            this.buttonComprobarConeccion.TabIndex = 10;
            this.buttonComprobarConeccion.Text = "Comprobar Coneccion";
            this.buttonComprobarConeccion.UseVisualStyleBackColor = true;
            this.buttonComprobarConeccion.Click += new System.EventHandler(this.buttonComprobarConeccion_Click);
            // 
            // textBoxConeccionSQL
            // 
            this.textBoxConeccionSQL.Location = new System.Drawing.Point(281, 15);
            this.textBoxConeccionSQL.Name = "textBoxConeccionSQL";
            this.textBoxConeccionSQL.Size = new System.Drawing.Size(422, 20);
            this.textBoxConeccionSQL.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese ruta de coneccion con su base de datos SQL";
            // 
            // buttonDataBase
            // 
            this.buttonDataBase.Location = new System.Drawing.Point(14, 40);
            this.buttonDataBase.Name = "buttonDataBase";
            this.buttonDataBase.Size = new System.Drawing.Size(130, 23);
            this.buttonDataBase.TabIndex = 9;
            this.buttonDataBase.Text = "DataBase";
            this.buttonDataBase.UseVisualStyleBackColor = true;
            this.buttonDataBase.Click += new System.EventHandler(this.buttonDataBase_Click);
            // 
            // buttonStopWords
            // 
            this.buttonStopWords.Location = new System.Drawing.Point(14, 141);
            this.buttonStopWords.Name = "buttonStopWords";
            this.buttonStopWords.Size = new System.Drawing.Size(130, 23);
            this.buttonStopWords.TabIndex = 10;
            this.buttonStopWords.Text = "Stop Words";
            this.buttonStopWords.UseVisualStyleBackColor = true;
            this.buttonStopWords.Click += new System.EventHandler(this.buttonStopWords_Click);
            // 
            // buttonStemmer
            // 
            this.buttonStemmer.Location = new System.Drawing.Point(14, 170);
            this.buttonStemmer.Name = "buttonStemmer";
            this.buttonStemmer.Size = new System.Drawing.Size(130, 23);
            this.buttonStemmer.TabIndex = 11;
            this.buttonStemmer.Text = "Stemmer";
            this.buttonStemmer.UseVisualStyleBackColor = true;
            this.buttonStemmer.Click += new System.EventHandler(this.buttonStemmer_Click);
            // 
            // buttonSeleccionarCategoria
            // 
            this.buttonSeleccionarCategoria.Location = new System.Drawing.Point(14, 69);
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
            this.label7.Location = new System.Drawing.Point(14, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tratamiento de Datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Preprocesamientos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Aplicacion y Resultado";
            // 
            // buttonActualizarTweets
            // 
            this.buttonActualizarTweets.Enabled = false;
            this.buttonActualizarTweets.Location = new System.Drawing.Point(542, 201);
            this.buttonActualizarTweets.Name = "buttonActualizarTweets";
            this.buttonActualizarTweets.Size = new System.Drawing.Size(101, 23);
            this.buttonActualizarTweets.TabIndex = 22;
            this.buttonActualizarTweets.Text = "Actualizar Tweets";
            this.buttonActualizarTweets.UseVisualStyleBackColor = true;
            this.buttonActualizarTweets.Click += new System.EventHandler(this.buttonActualizarTweets_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 564);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSeleccionarCategoria);
            this.Controls.Add(this.buttonStemmer);
            this.Controls.Add(this.buttonStopWords);
            this.Controls.Add(this.buttonDataBase);
            this.Controls.Add(this.panelDataBase);
            this.Name = "App";
            this.Text = "Preprocesamiento de Tweets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuplas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            this.panelDataBase.ResumeLayout(false);
            this.panelDataBase.PerformLayout();
            this.panelSeleccionarCategoria.ResumeLayout(false);
            this.panelSeleccionarCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoriasCreadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTuplas;
        private System.Windows.Forms.Button buttonMostrarTuplas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectCantTuplas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tweet_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entity_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Category;
        private System.Windows.Forms.Button buttonMostrarCategorias;
        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SelectCantDatos;
        private System.Windows.Forms.Panel panelDataBase;
        private System.Windows.Forms.Button buttonDataBase;
        private System.Windows.Forms.TextBox textBoxConeccionSQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonComprobarConeccion;
        private System.Windows.Forms.Label labelConeccionEstablecida;
        private System.Windows.Forms.Label labelConeccionFallida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMostrarTextos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonStopWords;
        private System.Windows.Forms.Button buttonStemmer;
        private System.Windows.Forms.Button buttonSeleccionarCategoria;
        private System.Windows.Forms.Panel panelSeleccionarCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSeleccionarNivel;
        private System.Windows.Forms.TextBox textBoxSeleccionarNivel;
        private System.Windows.Forms.Button buttonCrearCategorias;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelCantidadNiveles;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBoxCategoriasNivel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonCalcularNiveles;
        private System.Windows.Forms.Label labelNivelesCalculados;
        private System.Windows.Forms.Label labelCalculandoNiveles;
        private System.Windows.Forms.Label labelSeleccionandoNivel;
        private System.Windows.Forms.DataGridView dataGridViewCategoriasCreadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorias;
        private System.Windows.Forms.Button buttonActualizarTweets;
    }
}

