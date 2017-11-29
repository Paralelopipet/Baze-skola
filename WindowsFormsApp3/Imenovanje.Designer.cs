namespace WindowsFormsApp3
{
    partial class Imenovanje
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
            this.Tipovi = new System.Windows.Forms.ComboBox();
            this.TIpFajla = new System.Windows.Forms.Label();
            this.Sacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tipovi
            // 
            this.Tipovi.FormattingEnabled = true;
            this.Tipovi.Location = new System.Drawing.Point(89, 108);
            this.Tipovi.Name = "Tipovi";
            this.Tipovi.Size = new System.Drawing.Size(121, 21);
            this.Tipovi.TabIndex = 0;
            // 
            // TIpFajla
            // 
            this.TIpFajla.AutoSize = true;
            this.TIpFajla.Location = new System.Drawing.Point(127, 82);
            this.TIpFajla.Name = "TIpFajla";
            this.TIpFajla.Size = new System.Drawing.Size(44, 13);
            this.TIpFajla.TabIndex = 1;
            this.TIpFajla.Text = "Tip fajla";
            this.TIpFajla.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Sacuvaj
            // 
            this.Sacuvaj.Location = new System.Drawing.Point(111, 154);
            this.Sacuvaj.Name = "Sacuvaj";
            this.Sacuvaj.Size = new System.Drawing.Size(75, 23);
            this.Sacuvaj.TabIndex = 2;
            this.Sacuvaj.Text = "Sacuvaj";
            this.Sacuvaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Sacuvaj.UseVisualStyleBackColor = true;
            this.Sacuvaj.Click += new System.EventHandler(this.Sacuvaj_Click);
            // 
            // Imenovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 275);
            this.Controls.Add(this.Sacuvaj);
            this.Controls.Add(this.TIpFajla);
            this.Controls.Add(this.Tipovi);
            this.Name = "Imenovanje";
            this.Text = "Imenovanje";
            this.Load += new System.EventHandler(this.Imenovanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Tipovi;
        private System.Windows.Forms.Label TIpFajla;
        private System.Windows.Forms.Button Sacuvaj;
    }
}