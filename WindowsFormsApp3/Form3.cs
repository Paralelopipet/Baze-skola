using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {

            InitializeComponent();
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            //treba da prikazuje ime i prezime kako bi lakse spazio ako imas vise otvorenih formi sta znam
            string imepanel;
            ImePanel.Text = "Ime Prezime";
            if (Ime.Text != "" && Prezime.Text != "")
            {
                imepanel = Ime.Text + " " + Prezime.Text;
                ImePanel.Text = imepanel;
            }
        
         
        }

        OpenFileDialog file = new OpenFileDialog();
        int index = 0;
        bool selectedImage = false;

        private void button1_Click(object sender, EventArgs e)
        {

            //file.Filter = "Images (*.jpg)|*.jpg";
            file.Multiselect = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                selectedImage = true;
                Image image1 = Image.FromFile(file.FileName, true);

                pictureBox1.Image = image1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!selectedImage) return;
            index++;
            if (index >= file.FileNames.Length) index = 0;

            Image image1 = Image.FromFile(file.FileNames[index], true);

            pictureBox1.Image = image1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!selectedImage) return;
            index--;
            if (index < 0 ) index = file.FileNames.Length - 1;

            Image image1 = Image.FromFile(file.FileNames[index], true);

            pictureBox1.Image = image1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (!selectedImage) return;
            Process.Start(file.FileNames[index]);

        }







    }
}
