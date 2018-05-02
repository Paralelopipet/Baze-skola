namespace Arhiva
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DodajUcenikaB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrikazTabele = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazTabele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(20, 202);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 17);
            label1.TabIndex = 10;
            label1.Text = "Odaberi generaciju";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Menu;
            this.Search.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(106, 293);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(87, 38);
            this.Search.TabIndex = 0;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBGeneracija
            // 
            this.CBGeneracija.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGeneracija.FormattingEnabled = true;
            this.CBGeneracija.Location = new System.Drawing.Point(13, 234);
            this.CBGeneracija.Name = "CBGeneracija";
            this.CBGeneracija.Size = new System.Drawing.Size(121, 25);
            this.CBGeneracija.TabIndex = 2;
            this.CBGeneracija.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Ime
            // 
            this.Ime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ime.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime.Location = new System.Drawing.Point(13, 157);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(124, 22);
            this.Ime.TabIndex = 3;
            this.Ime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CBOdeljenje
            // 
            this.CBOdeljenje.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOdeljenje.FormattingEnabled = true;
            this.CBOdeljenje.Location = new System.Drawing.Point(140, 234);
            this.CBOdeljenje.Name = "CBOdeljenje";
            this.CBOdeljenje.Size = new System.Drawing.Size(121, 25);
            this.CBOdeljenje.TabIndex = 4;
            this.CBOdeljenje.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // SortPrezime
            // 
            this.SortPrezime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortPrezime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.SortPrezime.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortPrezime.Location = new System.Drawing.Point(13, 70);
            this.SortPrezime.Name = "SortPrezime";
            this.SortPrezime.Size = new System.Drawing.Size(87, 23);
            this.SortPrezime.TabIndex = 5;
            this.SortPrezime.Text = "Prezimenu";
            this.SortPrezime.UseVisualStyleBackColor = true;
            this.SortPrezime.Click += new System.EventHandler(this.SortPrezime_Click);
            // 
            // SortIme
            // 
            this.SortIme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortIme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.SortIme.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortIme.Location = new System.Drawing.Point(106, 70);
            this.SortIme.Name = "SortIme";
            this.SortIme.Size = new System.Drawing.Size(87, 23);
            this.SortIme.TabIndex = 6;
            this.SortIme.Text = "Imenu";
            this.SortIme.UseVisualStyleBackColor = true;
            this.SortIme.Click += new System.EventHandler(this.button3_Click);
            // 
            // OpadajuceRastuce
            // 
            this.OpadajuceRastuce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpadajuceRastuce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.OpadajuceRastuce.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpadajuceRastuce.Location = new System.Drawing.Point(199, 70);
            this.OpadajuceRastuce.Name = "OpadajuceRastuce";
            this.OpadajuceRastuce.Size = new System.Drawing.Size(80, 23);
            this.OpadajuceRastuce.TabIndex = 7;
            this.OpadajuceRastuce.Text = "Opadajuce";
            this.OpadajuceRastuce.UseVisualStyleBackColor = true;
            this.OpadajuceRastuce.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Odaberi odeljenje";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SidePanel.Controls.Add(this.label7);
            this.SidePanel.Controls.Add(this.label5);
            this.SidePanel.Controls.Add(this.Prezime);
            this.SidePanel.Controls.Add(this.label4);
            this.SidePanel.Controls.Add(this.DodajUcenikaB);
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
            this.SidePanel.Size = new System.Drawing.Size(289, 547);
            this.SidePanel.TabIndex = 12;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(91, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sortiraj po:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dodaj novog ucenika";
            // 
            // Prezime
            // 
            this.Prezime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prezime.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prezime.Location = new System.Drawing.Point(143, 157);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(121, 22);
            this.Prezime.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prezime";
            // 
            // DodajUcenikaB
            // 
            this.DodajUcenikaB.BackgroundImage = global::Arhiva.Properties.Resources.user_add_icon;
            this.DodajUcenikaB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DodajUcenikaB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DodajUcenikaB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.DodajUcenikaB.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodajUcenikaB.Location = new System.Drawing.Point(106, 392);
            this.DodajUcenikaB.Name = "DodajUcenikaB";
            this.DodajUcenikaB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DodajUcenikaB.Size = new System.Drawing.Size(87, 87);
            this.DodajUcenikaB.TabIndex = 8;
            this.DodajUcenikaB.UseVisualStyleBackColor = true;
            this.DodajUcenikaB.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ime";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TopPanel.Controls.Add(this.panel2);
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1032, 137);
            this.TopPanel.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Arhiva.Properties.Resources.slika;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(287, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 139);
            this.panel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vladimir Script", 38F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(84, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(569, 62);
            this.label6.TabIndex = 0;
            this.label6.Text = "Matematicka gimnazija - Arhiv";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Arhiva.Properties.Resources.images1;
            this.panel1.Location = new System.Drawing.Point(-19, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 142);
            this.panel1.TabIndex = 0;
            // 
            // PrikazTabele
            // 
            this.PrikazTabele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PrikazTabele.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.PrikazTabele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrikazTabele.Location = new System.Drawing.Point(305, 159);
            this.PrikazTabele.Name = "PrikazTabele";
            this.PrikazTabele.Size = new System.Drawing.Size(696, 470);
            this.PrikazTabele.TabIndex = 14;
            this.PrikazTabele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrikazTabele_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(489, 632);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(445, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Program realizovali: Damjan Denic, Djordje Dimitrijevic, Ivan Pop-Jovanov, Andrij" +
    "a Jelenkovic";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 684);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PrikazTabele);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "Form1";
            this.Text = "Korisnicki interfejs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazTabele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

