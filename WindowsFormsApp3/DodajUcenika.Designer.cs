namespace WindowsFormsApp3
{
    partial class DodajUcenika
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
            this.Prezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBGeneracija = new System.Windows.Forms.ComboBox();
            this.CBOdeljenje = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Prezime
            // 
            this.Prezime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Prezime.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prezime.Location = new System.Drawing.Point(221, 216);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(121, 26);
            this.Prezime.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ime";
            // 
            // Ime
            // 
            this.Ime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Ime.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime.Location = new System.Drawing.Point(55, 216);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(121, 26);
            this.Ime.TabIndex = 3;
            this.Ime.TextChanged += new System.EventHandler(this.Ime_TextChanged);
            // 
            // TopPanel
            // 
            this.TopPanel.AutoScroll = true;
            this.TopPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.panel2);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(518, 142);
            this.TopPanel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dodaj novog ucenika";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.images1;
            this.panel2.Location = new System.Drawing.Point(-19, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 142);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Odeljenje";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Generacija";
            // 
            // CBGeneracija
            // 
            this.CBGeneracija.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CBGeneracija.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGeneracija.FormattingEnabled = true;
            this.CBGeneracija.Location = new System.Drawing.Point(55, 323);
            this.CBGeneracija.Name = "CBGeneracija";
            this.CBGeneracija.Size = new System.Drawing.Size(121, 29);
            this.CBGeneracija.TabIndex = 19;
            this.CBGeneracija.TextUpdate += new System.EventHandler(this.CBGeneracija_TextUpdate);
            // 
            // CBOdeljenje
            // 
            this.CBOdeljenje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CBOdeljenje.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOdeljenje.FormattingEnabled = true;
            this.CBOdeljenje.Location = new System.Drawing.Point(221, 323);
            this.CBOdeljenje.Name = "CBOdeljenje";
            this.CBOdeljenje.Size = new System.Drawing.Size(121, 29);
            this.CBOdeljenje.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sacuvaj";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.Window;
            this.SaveButton.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_save_50;
            this.SaveButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveButton.Location = new System.Drawing.Point(388, 216);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(50, 49);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(6, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(512, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Program realizovali: Damjan Denic, Dimitrijevic Djordje, Ivan Pop-Jovanov, Andrij" +
    "a Jelenkovic, Mihailo Grbic";
            // 
            // DodajUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(518, 399);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CBOdeljenje);
            this.Controls.Add(this.CBGeneracija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.Ime);
            this.Name = "DodajUcenika";
            this.Text = "Dodaj novog ucenika";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Prezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBGeneracija;
        private System.Windows.Forms.ComboBox CBOdeljenje;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}