﻿namespace Arhiva
{
    partial class Slike
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ImePanel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.TextBox();
            this.Odeljenje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Generacija = new System.Windows.Forms.TextBox();
            this.SviFajlovi = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Sacuvaj = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TopPanel.BackgroundImage = global::Arhiva.Properties.Resources.slika;
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanel.Controls.Add(this.ImePanel);
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(946, 137);
            this.TopPanel.TabIndex = 15;
            // 
            // ImePanel
            // 
            this.ImePanel.AutoSize = true;
            this.ImePanel.BackColor = System.Drawing.Color.Transparent;
            this.ImePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic);
            this.ImePanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImePanel.Location = new System.Drawing.Point(335, 43);
            this.ImePanel.Name = "ImePanel";
            this.ImePanel.Size = new System.Drawing.Size(0, 46);
            this.ImePanel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Arhiva.Properties.Resources.images1;
            this.panel1.Location = new System.Drawing.Point(-19, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 142);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 55);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ucitaj sliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prezime
            // 
            this.Prezime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prezime.Font = new System.Drawing.Font("Franklin Gothic Demi", 15F, System.Drawing.FontStyle.Italic);
            this.Prezime.Location = new System.Drawing.Point(547, 219);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(172, 30);
            this.Prezime.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 15F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(577, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 15F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(405, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ime";
            // 
            // Ime
            // 
            this.Ime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ime.Font = new System.Drawing.Font("Franklin Gothic Demi", 15F, System.Drawing.FontStyle.Italic);
            this.Ime.Location = new System.Drawing.Point(369, 219);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(172, 30);
            this.Ime.TabIndex = 21;
            // 
            // Odeljenje
            // 
            this.Odeljenje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Odeljenje.Font = new System.Drawing.Font("Franklin Gothic Demi", 15F, System.Drawing.FontStyle.Italic);
            this.Odeljenje.Location = new System.Drawing.Point(547, 381);
            this.Odeljenje.Name = "Odeljenje";
            this.Odeljenje.Size = new System.Drawing.Size(172, 30);
            this.Odeljenje.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 15F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(577, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Odeljenje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 15F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(386, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Generacija";
            // 
            // Generacija
            // 
            this.Generacija.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Generacija.Font = new System.Drawing.Font("Franklin Gothic Demi", 15F, System.Drawing.FontStyle.Italic);
            this.Generacija.Location = new System.Drawing.Point(369, 381);
            this.Generacija.Name = "Generacija";
            this.Generacija.Size = new System.Drawing.Size(172, 30);
            this.Generacija.TabIndex = 28;
            // 
            // SviFajlovi
            // 
            this.SviFajlovi.BackColor = System.Drawing.Color.MediumOrchid;
            this.SviFajlovi.Cursor = System.Windows.Forms.Cursors.Default;
            this.SviFajlovi.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SviFajlovi.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.SviFajlovi.FormattingEnabled = true;
            this.SviFajlovi.ItemHeight = 21;
            this.SviFajlovi.Location = new System.Drawing.Point(757, 252);
            this.SviFajlovi.Name = "SviFajlovi";
            this.SviFajlovi.Size = new System.Drawing.Size(173, 151);
            this.SviFajlovi.TabIndex = 32;
            this.SviFajlovi.SelectedIndexChanged += new System.EventHandler(this.SviFajlovi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Sacuvaj";
            // 
            // Sacuvaj
            // 
            this.Sacuvaj.BackgroundImage = global::Arhiva.Properties.Resources.icons8_save_50;
            this.Sacuvaj.Location = new System.Drawing.Point(522, 492);
            this.Sacuvaj.Name = "Sacuvaj";
            this.Sacuvaj.Size = new System.Drawing.Size(49, 49);
            this.Sacuvaj.TabIndex = 33;
            this.Sacuvaj.UseVisualStyleBackColor = true;
            this.Sacuvaj.Click += new System.EventHandler(this.Sacuvaj_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Arhiva.Properties.Resources.arrow_forward_icon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(7, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Arhiva.Properties.Resources.arrow_unazad;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(248, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(7, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(754, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tipovi slika koji postoje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(379, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(534, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Program realizovali: Damjan Denic, Djordje Dimitrijevic, Ivan Pop-Jovanov, Andrij" +
    "a Jelenkovic";
            // 
            // Slike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 577);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Sacuvaj);
            this.Controls.Add(this.SviFajlovi);
            this.Controls.Add(this.Odeljenje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Generacija);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Slike";
            this.Text = "Dodaj sliku";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ImePanel;
        private System.Windows.Forms.TextBox Prezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.TextBox Odeljenje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Generacija;
        private System.Windows.Forms.ListBox SviFajlovi;
        private System.Windows.Forms.Button Sacuvaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}