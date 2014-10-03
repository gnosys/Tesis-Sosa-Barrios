namespace AppPrincipal.FormsPreprocesamientos
{
    partial class FormTratamientoEnTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTratamientoEnTexto));
            this.labelDescripcionStopWords = new System.Windows.Forms.Label();
            this.labelTituloStopWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDescripcionStopWords
            // 
            this.labelDescripcionStopWords.AutoSize = true;
            this.labelDescripcionStopWords.Location = new System.Drawing.Point(193, 70);
            this.labelDescripcionStopWords.Name = "labelDescripcionStopWords";
            this.labelDescripcionStopWords.Size = new System.Drawing.Size(686, 65);
            this.labelDescripcionStopWords.TabIndex = 5;
            this.labelDescripcionStopWords.Text = resources.GetString("labelDescripcionStopWords.Text");
            // 
            // labelTituloStopWords
            // 
            this.labelTituloStopWords.AutoSize = true;
            this.labelTituloStopWords.Location = new System.Drawing.Point(190, 29);
            this.labelTituloStopWords.Name = "labelTituloStopWords";
            this.labelTituloStopWords.Size = new System.Drawing.Size(142, 13);
            this.labelTituloStopWords.TabIndex = 4;
            this.labelTituloStopWords.Text = "TRATAMIENTO EN TEXTO";
            // 
            // FormTratamientoEnTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.labelDescripcionStopWords);
            this.Controls.Add(this.labelTituloStopWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTratamientoEnTexto";
            this.Text = "FormTratamientoEnTexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcionStopWords;
        private System.Windows.Forms.Label labelTituloStopWords;
    }
}