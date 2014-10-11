namespace AppPrincipal.FormsAplicacionDePipe
{
    partial class FormSVMLigth
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
            this.buttonEjecutarSVMLigth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEjecutarSVMLigth
            // 
            this.buttonEjecutarSVMLigth.Location = new System.Drawing.Point(855, 376);
            this.buttonEjecutarSVMLigth.Name = "buttonEjecutarSVMLigth";
            this.buttonEjecutarSVMLigth.Size = new System.Drawing.Size(136, 23);
            this.buttonEjecutarSVMLigth.TabIndex = 0;
            this.buttonEjecutarSVMLigth.Text = "Ejecutar SVM-Ligth";
            this.buttonEjecutarSVMLigth.UseVisualStyleBackColor = true;
            this.buttonEjecutarSVMLigth.Click += new System.EventHandler(this.buttonEjecutarSVMLigth_Click);
            // 
            // FormSVMLigth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.buttonEjecutarSVMLigth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSVMLigth";
            this.Text = "FormSVMLigth";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEjecutarSVMLigth;
    }
}