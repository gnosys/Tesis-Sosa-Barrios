namespace AppPrincipal
{
    partial class FormTokenization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTokenization));
            this.labelTituloTokenization = new System.Windows.Forms.Label();
            this.labelDescripcionTokenization = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelTituloTokenization
            // 
            this.labelTituloTokenization.AutoSize = true;
            this.labelTituloTokenization.Location = new System.Drawing.Point(190, 29);
            this.labelTituloTokenization.Name = "labelTituloTokenization";
            this.labelTituloTokenization.Size = new System.Drawing.Size(87, 13);
            this.labelTituloTokenization.TabIndex = 0;
            this.labelTituloTokenization.Text = "TOKENIZACION";
            // 
            // labelDescripcionTokenization
            // 
            this.labelDescripcionTokenization.AutoSize = true;
            this.labelDescripcionTokenization.Location = new System.Drawing.Point(193, 70);
            this.labelDescripcionTokenization.Name = "labelDescripcionTokenization";
            this.labelDescripcionTokenization.Size = new System.Drawing.Size(776, 338);
            this.labelDescripcionTokenization.TabIndex = 1;
            this.labelDescripcionTokenization.Text = resources.GetString("labelDescripcionTokenization.Text");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppPrincipal.Properties.Resources.er;
            this.panel1.Location = new System.Drawing.Point(279, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 103);
            this.panel1.TabIndex = 2;
            // 
            // FormTokenization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDescripcionTokenization);
            this.Controls.Add(this.labelTituloTokenization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTokenization";
            this.Text = "FormTokenization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloTokenization;
        private System.Windows.Forms.Label labelDescripcionTokenization;
        private System.Windows.Forms.Panel panel1;
    }
}