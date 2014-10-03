namespace AppPrincipal
{
    partial class FormStemmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStemmer));
            this.labelDescripcionStemmer = new System.Windows.Forms.Label();
            this.labelTituloStemmer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDescripcionStemmer
            // 
            this.labelDescripcionStemmer.AutoSize = true;
            this.labelDescripcionStemmer.Location = new System.Drawing.Point(190, 70);
            this.labelDescripcionStemmer.Name = "labelDescripcionStemmer";
            this.labelDescripcionStemmer.Size = new System.Drawing.Size(769, 117);
            this.labelDescripcionStemmer.TabIndex = 5;
            this.labelDescripcionStemmer.Text = resources.GetString("labelDescripcionStemmer.Text");
            // 
            // labelTituloStemmer
            // 
            this.labelTituloStemmer.AutoSize = true;
            this.labelTituloStemmer.Location = new System.Drawing.Point(190, 29);
            this.labelTituloStemmer.Name = "labelTituloStemmer";
            this.labelTituloStemmer.Size = new System.Drawing.Size(61, 13);
            this.labelTituloStemmer.TabIndex = 4;
            this.labelTituloStemmer.Text = "STEMMER";
            // 
            // FormStemmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.labelDescripcionStemmer);
            this.Controls.Add(this.labelTituloStemmer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStemmer";
            this.Text = "FormStemmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcionStemmer;
        private System.Windows.Forms.Label labelTituloStemmer;
    }
}