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
using System.Data.SqlClient;
using System.IO;

namespace Arhiva
{
    public partial class Slike : Form
    {
        static string lokacija = @"lokacija/";
        string connectionString = Konekcija.konekcionistring;
        List<String> row;
        string ime;
        string prezime;
        string generacija;
        string odeljenje;
        string sifra;
        int nextIdFajla;
        public Slike(List<String> row)
        {
            this.row = row;
            sifra = row[0];
            ime = row[1];
            prezime = row[2];
            generacija = row[3];
            odeljenje = row[4];
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
            Ime.Text = ime;
            Prezime.Text = prezime;
            Generacija.Text = generacija;
            Odeljenje.Text = odeljenje;
            if (Ime.Text != "" && Prezime.Text != "")
            {
                imepanel = Ime.Text + " " + Prezime.Text;
                ImePanel.Text = imepanel;
            }
            string sql = "SELECT Top 1 ID From Fajlovi ORDER BY Fajlovi.ID DESC";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                nextIdFajla=int.Parse(myTable.Rows[0][0].ToString()) + 1;
                connection.Close();

            }
            DopremiFajlove();
            
        }

        OpenFileDialog file = new OpenFileDialog();
        int index = 0;
        bool selectedImage = false;
        Imenovanje imenovanje = new Imenovanje();
        Dictionary<string, Image> sveSlike = new Dictionary<string, Image>();
        Dictionary<string, string> dodatiFajlovi= new Dictionary<string, string>();
               
        private void button1_Click(object sender, EventArgs e)
        {

            //file.Filter = "Images (*.jpg)|*.jpg";
            //file.Multiselect = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                string tip;
                imenovanje.ShowDialog();
                tip = imenovanje.Get();
                dodatiFajlovi.Add(tip, file.FileName);
                SviFajlovi.Items.Add(tip);
                sveSlike.Add(file.FileName,Image.FromFile(file.FileName));
                //selectedImage = true;
                //Image image1 = Image.FromFile(file.FileName, true);
                PrikaziSliku(sveSlike.Count-1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SledSlika();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProslaSlika();

        }
       

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath+"\\"+sveSlike.Keys.ElementAt(index));
            
        }

        public void DopremiFajlove()
        {
            
            string sql = "SELECT Fajlovi.Vrsta,Fajlovi.Ime FROM Ucenici INNER JOIN (VezeUc INNER JOIN Fajlovi on VezeUC.IDFajl=Fajlovi.ID) ON Ucenici.Sifra=VezeUc.SifraUc WHERE Ucenici.Sifra='"+sifra+"'";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    string s = lokacija + myTable.Rows[i][1].ToString().Replace(" ", "") + ".jpg";
                    sveSlike.Add(s,Image.FromFile(s));
                    SviFajlovi.Items.Add(myTable.Rows[i][0]);
                }
                SledSlika();
                connection.Close();

            }
           
        }
        public void SledSlika()
        {
            if (--index < 0)
                index = sveSlike.Count - 1;
            if (sveSlike.Count == 0) return;
            pictureBox1.Image=(sveSlike.Values.ElementAt(index));
            
        }
    public void ProslaSlika()
    {
            if (++index > sveSlike.Count - 1)
                index = 0;
            if (sveSlike.Count == 0) return;
        pictureBox1.Image=(sveSlike.Values.ElementAt(index));
            
    }
    public void PrikaziSliku(int i)
        {
            
            pictureBox1.Image = (sveSlike.Values.ElementAt(i));
            index = i;
        }
        

        private void SviFajlovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziSliku(SviFajlovi.SelectedIndex);
        }

        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            
            foreach (var item in dodatiFajlovi)
            {
            File.Copy(item.Value, lokacija+nextIdFajla.ToString() + "_"+ item.Key+".jpg");
            string sql = "INSERT INTO Skola.dbo.Fajlovi (Ime,Vrsta) VALUES ('" + nextIdFajla.ToString()+"_"+item.Key + "','" + item.Key + "')";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            sql = "INSERT INTO Skola.dbo.VezeUc (SifraUc,IDFajl) VALUES ('" + sifra + "','" + nextIdFajla + "')";
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                nextIdFajla++;
            }
            this.Close();

        }

        
    }
}
