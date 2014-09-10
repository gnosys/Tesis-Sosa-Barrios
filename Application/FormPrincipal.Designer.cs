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
            this.dataGridViewCategorias = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectCantCategorias = new System.Windows.Forms.TextBox();
            this.Categorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuplas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
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
            this.dataGridViewTuplas.Location = new System.Drawing.Point(27, 78);
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
            this.buttonMostrarTuplas.Location = new System.Drawing.Point(294, 39);
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
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese cantidad de tuplas a mostrar";
            // 
            // SelectCantTuplas
            // 
            this.SelectCantTuplas.Location = new System.Drawing.Point(239, 41);
            this.SelectCantTuplas.Name = "SelectCantTuplas";
            this.SelectCantTuplas.Size = new System.Drawing.Size(36, 20);
            this.SelectCantTuplas.TabIndex = 3;
            // 
            // buttonMostrarCategorias
            // 
            this.buttonMostrarCategorias.Location = new System.Drawing.Point(294, 297);
            this.buttonMostrarCategorias.Name = "buttonMostrarCategorias";
            this.buttonMostrarCategorias.Size = new System.Drawing.Size(103, 23);
            this.buttonMostrarCategorias.TabIndex = 4;
            this.buttonMostrarCategorias.Text = "Mostrar Categorias";
            this.buttonMostrarCategorias.UseVisualStyleBackColor = true;
            this.buttonMostrarCategorias.Click += new System.EventHandler(this.buttonMostrarCategorias_Click);
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categorias});
            this.dataGridViewCategorias.Location = new System.Drawing.Point(27, 337);
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.Size = new System.Drawing.Size(743, 204);
            this.dataGridViewCategorias.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese cantidad de categorias a mostrar";
            // 
            // SelectCantCategorias
            // 
            this.SelectCantCategorias.Location = new System.Drawing.Point(239, 300);
            this.SelectCantCategorias.Name = "SelectCantCategorias";
            this.SelectCantCategorias.Size = new System.Drawing.Size(36, 20);
            this.SelectCantCategorias.TabIndex = 7;
            // 
            // Categorias
            // 
            this.Categorias.HeaderText = "Categorias";
            this.Categorias.Name = "Categorias";
            this.Categorias.Width = 700;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 553);
            this.Controls.Add(this.SelectCantCategorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCategorias);
            this.Controls.Add(this.buttonMostrarCategorias);
            this.Controls.Add(this.SelectCantTuplas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMostrarTuplas);
            this.Controls.Add(this.dataGridViewTuplas);
            this.Name = "App";
            this.Text = "Preprocesamiento de Tweets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuplas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewCategorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SelectCantCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorias;
    }
}

