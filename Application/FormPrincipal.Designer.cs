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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuplas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            this.panelDataBase.SuspendLayout();
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
            this.buttonDataBase.Location = new System.Drawing.Point(13, 13);
            this.buttonDataBase.Name = "buttonDataBase";
            this.buttonDataBase.Size = new System.Drawing.Size(130, 23);
            this.buttonDataBase.TabIndex = 9;
            this.buttonDataBase.Text = "DataBase";
            this.buttonDataBase.UseVisualStyleBackColor = true;
            this.buttonDataBase.Click += new System.EventHandler(this.buttonDataBase_Click);
            // 
            // buttonStopWords
            // 
            this.buttonStopWords.Location = new System.Drawing.Point(13, 50);
            this.buttonStopWords.Name = "buttonStopWords";
            this.buttonStopWords.Size = new System.Drawing.Size(130, 23);
            this.buttonStopWords.TabIndex = 10;
            this.buttonStopWords.Text = "Stop Words";
            this.buttonStopWords.UseVisualStyleBackColor = true;
            this.buttonStopWords.Click += new System.EventHandler(this.buttonStopWords_Click);
            // 
            // buttonStemmer
            // 
            this.buttonStemmer.Location = new System.Drawing.Point(13, 86);
            this.buttonStemmer.Name = "buttonStemmer";
            this.buttonStemmer.Size = new System.Drawing.Size(130, 23);
            this.buttonStemmer.TabIndex = 11;
            this.buttonStemmer.Text = "Stemmer";
            this.buttonStemmer.UseVisualStyleBackColor = true;
            this.buttonStemmer.Click += new System.EventHandler(this.buttonStemmer_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 564);
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
            this.ResumeLayout(false);

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
    }
}

