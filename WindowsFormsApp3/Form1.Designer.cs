﻿namespace WindowsFormsApp3
{
    partial class Form1
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
            System.Windows.Forms.Label label1;
            this.Search = new System.Windows.Forms.Button();
            this.CBGeneracija = new System.Windows.Forms.ComboBox();
            this.Ime = new System.Windows.Forms.TextBox();
            this.CBOdeljenje = new System.Windows.Forms.ComboBox();
            this.SortPrezime = new System.Windows.Forms.Button();
            this.SortIme = new System.Windows.Forms.Button();
            this.OpadajuceRastuce = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DodajUcenikaB = new System.Windows.Forms.Button();
            this.PrikazTabele = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazTabele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(20, 193);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 17);
            label1.TabIndex = 10;
            label1.Text = "Sort po generaciji";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Menu;
            this.Search.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(95, 252);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(81, 35);
            this.Search.TabIndex = 0;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBGeneracija
            // 
            this.CBGeneracija.FormattingEnabled = true;
            this.CBGeneracija.Location = new System.Drawing.Point(13, 225);
            this.CBGeneracija.Name = "CBGeneracija";
            this.CBGeneracija.Size = new System.Drawing.Size(121, 21);
            this.CBGeneracija.TabIndex = 2;
            this.CBGeneracija.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Ime
            // 
            this.Ime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime.Location = new System.Drawing.Point(13, 148);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(121, 29);
            this.Ime.TabIndex = 3;
            this.Ime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CBOdeljenje
            // 
            this.CBOdeljenje.FormattingEnabled = true;
            this.CBOdeljenje.Location = new System.Drawing.Point(140, 225);
            this.CBOdeljenje.Name = "CBOdeljenje";
            this.CBOdeljenje.Size = new System.Drawing.Size(121, 21);
            this.CBOdeljenje.TabIndex = 4;
            this.CBOdeljenje.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // SortPrezime
            // 
            this.SortPrezime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortPrezime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.SortPrezime.Location = new System.Drawing.Point(14, 41);
            this.SortPrezime.Name = "SortPrezime";
            this.SortPrezime.Size = new System.Drawing.Size(75, 23);
            this.SortPrezime.TabIndex = 5;
            this.SortPrezime.Text = "Prezime";
            this.SortPrezime.UseVisualStyleBackColor = true;
            this.SortPrezime.Click += new System.EventHandler(this.SortPrezime_Click);
            // 
            // SortIme
            // 
            this.SortIme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortIme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.SortIme.Location = new System.Drawing.Point(95, 41);
            this.SortIme.Name = "SortIme";
            this.SortIme.Size = new System.Drawing.Size(75, 23);
            this.SortIme.TabIndex = 6;
            this.SortIme.Text = "Ime";
            this.SortIme.UseVisualStyleBackColor = true;
            this.SortIme.Click += new System.EventHandler(this.button3_Click);
            // 
            // OpadajuceRastuce
            // 
            this.OpadajuceRastuce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpadajuceRastuce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.OpadajuceRastuce.Location = new System.Drawing.Point(176, 41);
            this.OpadajuceRastuce.Name = "OpadajuceRastuce";
            this.OpadajuceRastuce.Size = new System.Drawing.Size(75, 23);
            this.OpadajuceRastuce.TabIndex = 7;
            this.OpadajuceRastuce.Text = "Opadajuce";
            this.OpadajuceRastuce.UseVisualStyleBackColor = true;
            this.OpadajuceRastuce.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sort po odeljenju";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SidePanel.Controls.Add(this.Prezime);
            this.SidePanel.Controls.Add(this.label4);
            this.SidePanel.Controls.Add(this.label3);
            this.SidePanel.Controls.Add(this.SortPrezime);
            this.SidePanel.Controls.Add(this.label2);
            this.SidePanel.Controls.Add(this.Search);
            this.SidePanel.Controls.Add(this.CBGeneracija);
            this.SidePanel.Controls.Add(this.Ime);
            this.SidePanel.Controls.Add(label1);
            this.SidePanel.Controls.Add(this.CBOdeljenje);
            this.SidePanel.Controls.Add(this.SortIme);
            this.SidePanel.Controls.Add(this.OpadajuceRastuce);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 137);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(281, 547);
            this.SidePanel.TabIndex = 12;
            // 
            // Prezime
            // 
            this.Prezime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prezime.Location = new System.Drawing.Point(140, 148);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(121, 29);
            this.Prezime.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ime";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TopPanel.Controls.Add(this.label6);
            this.TopPanel.Controls.Add(this.label5);
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Controls.Add(this.DodajUcenikaB);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1032, 137);
            this.TopPanel.TabIndex = 13;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dodaj novog ucenika";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.images1;
            this.panel1.Location = new System.Drawing.Point(-19, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 142);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DodajUcenikaB
            // 
            this.DodajUcenikaB.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._50;
            this.DodajUcenikaB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DodajUcenikaB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DodajUcenikaB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.DodajUcenikaB.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodajUcenikaB.Location = new System.Drawing.Point(358, 57);
            this.DodajUcenikaB.Name = "DodajUcenikaB";
            this.DodajUcenikaB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DodajUcenikaB.Size = new System.Drawing.Size(56, 55);
            this.DodajUcenikaB.TabIndex = 8;
            this.DodajUcenikaB.UseVisualStyleBackColor = true;
            this.DodajUcenikaB.Click += new System.EventHandler(this.button5_Click);
            // 
            // PrikazTabele
            // 
            this.PrikazTabele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrikazTabele.Location = new System.Drawing.Point(305, 159);
            this.PrikazTabele.Name = "PrikazTabele";
            this.PrikazTabele.Size = new System.Drawing.Size(696, 470);
            this.PrikazTabele.TabIndex = 14;
            this.PrikazTabele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrikazTabele_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 684);
            this.Controls.Add(this.PrikazTabele);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "Form1";
            this.Text = "Korisnicki interfejs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazTabele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox CBGeneracija;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.ComboBox CBOdeljenje;
        private System.Windows.Forms.Button SortPrezime;
        private System.Windows.Forms.Button SortIme;
        private System.Windows.Forms.Button OpadajuceRastuce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button DodajUcenikaB;
        private System.Windows.Forms.DataGridView PrikazTabele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Prezime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
