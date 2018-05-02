namespace Arhiva
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tipovi
            // 
            this.Tipovi.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipovi.FormattingEnabled = true;
            this.Tipovi.Location = new System.Drawing.Point(21, 81);
            this.Tipovi.Name = "Tipovi";
            this.Tipovi.Size = new System.Drawing.Size(121, 29);
            this.Tipovi.TabIndex = 0;
            // 
            // TIpFajla
            // 
            this.TIpFajla.AutoSize = true;
            this.TIpFajla.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIpFajla.Location = new System.Drawing.Point(12, 32);
            this.TIpFajla.Name = "TIpFajla";
            this.TIpFajla.Size = new System.Drawing.Size(130, 21);
            this.TIpFajla.TabIndex = 1;
            this.TIpFajla.Text = "Izaberite tip fajla";
            this.TIpFajla.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Sacuvaj
            // 
            this.Sacuvaj.BackgroundImage = global::Arhiva.Properties.Resources.icons8_save_50;
            this.Sacuvaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sacuvaj.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sacuvaj.Location = new System.Drawing.Point(211, 146);
            this.Sacuvaj.Name = "Sacuvaj";
            this.Sacuvaj.Size = new System.Drawing.Size(55, 50);
            this.Sacuvaj.TabIndex = 2;
            this.Sacuvaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Sacuvaj.UseVisualStyleBackColor = true;
            this.Sacuvaj.Click += new System.EventHandler(this.Sacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sacuvaj";
            // 
            // Imenovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 245);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}