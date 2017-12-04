using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        DataTable myTable;
        string connectionString = "Data Source=NAJKOMP\\DATA;Initial Catalog=Skola;Integrated Security=True";
        public static string defaultGen = "Generacija ";
        static string defaultOdl = "Odeljenje ";
        string sortBy = "Ucenici.Ime";
        string sortWay = "ASC";
        public string sql = "SELECT Sifra, Ucenici.Ime, Prezime, Generacija, Odeljenje.Naziv as Odeljenje, Count(Fajlovi.id) as Broj_Fajlova FROM Ucenici LEFT JOIN (VezeUc INNER JOIN Fajlovi on VezeUC.IDFajl=Fajlovi.ID) ON Ucenici.Sifra=VezeUc.SifraUc INNER JOIN Odeljenje ON Odeljenje.ID = Ucenici.IDOdeljenja GROUP BY Ucenici.Ime, Ucenici.Sifra, Prezime, Generacija, Odeljenje.Naziv";
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = " 1=1 ";
            string prezime = " 1=1 ";
            string generacija = " 1=1 ";
            string odeljenje = " 1=1 ";
            if(!(Ime.Text==""))
            {
                ime = " Ucenici.Ime='"+Ime.Text+"' ";
            }
            if (!(Prezime.Text == ""))
            {
                prezime = " Prezime='" + Prezime.Text + "' ";
            }
            if (!(CBGeneracija.SelectedItem.ToString() == defaultGen))
            {
                generacija = " Generacija=" + CBGeneracija.SelectedItem.ToString() + " ";
                if (!(CBOdeljenje.SelectedItem.ToString() == defaultOdl))
                {
                    odeljenje = " Naziv=" + "'" + CBOdeljenje.SelectedItem.ToString()[0] + "' ";

                }
            }
            sql = "SELECT Sifra, Ucenici.Ime, Prezime, Generacija, Odeljenje.Naziv as Odeljenje, Count(Fajlovi.id) AS Broj_Fajlova FROM Ucenici LEFT JOIN (VezeUc INNER JOIN Fajlovi on VezeUC.IDFajl=Fajlovi.ID) ON Ucenici.Sifra=VezeUc.SifraUc INNER JOIN Odeljenje ON Odeljenje.ID = Ucenici.IDOdeljenja GROUP BY Ucenici.Ime,Ucenici.Sifra,Prezime, Generacija, Odeljenje.Naziv having";
            sql += ime+ "AND" + prezime + "AND" + generacija + "AND" + odeljenje;
            
            Trazi();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  

            //ovo bi trebalo da kada stisnes na celiju gde pise necije ime ili prezime da ti otvori novu formu koja te vodi da vidis njegove slike
            DodajUcenika frm = new DodajUcenika();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
      
            CBGeneracija.Items.Add(defaultGen);
            CBGeneracija.SelectedIndex = 0;
            CBOdeljenje.Items.Add(defaultOdl);
            CBOdeljenje.SelectedIndex = 0;
            LoadCBGen();
            Trazi();
        }
        public void Trazi()
        {
            string sql =this.sql + " ORDER BY " + sortBy + " " + sortWay;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                myTable = new DataTable();
                adapter.Fill(myTable);
                PrikazTabele.DataSource = myTable;
                PrikazTabele.Columns["Sifra"].Visible = false;
                connection.Close();

            }
            
        }
        private void LoadCBGen()
        {
            CBGeneracija.Items.Clear();
            CBGeneracija.Items.Add(defaultGen);
            CBGeneracija.SelectedIndex = 0;
            string sql = "SELECT Generacija FROM Skola.dbo.Odeljenje GROUP BY Generacija ORDER BY Generacija ASC";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                for (int i=0; i< myTable.Rows.Count;i++)
                {
                    CBGeneracija.Items.Add(myTable.Rows[i][0].ToString());
                }
                //PrikazTabele.DataSource = myTable;
                //PrikazTabele.Columns["ID"].Visible = false;
                connection.Close();

            }
        }

        private void LoadCBOdl()
        {
            CBOdeljenje.Items.Clear();
            CBOdeljenje.Items.Add(defaultOdl);
            CBOdeljenje.SelectedIndex = 0;
            if (CBGeneracija.SelectedItem == null || CBGeneracija.SelectedItem.ToString() == defaultGen)
            {
                
            }
            else
            {
            string sql = "SELECT Naziv FROM Skola.dbo.Odeljenje WHERE Generacija=" + CBGeneracija.SelectedItem.ToString() + " GROUP BY Naziv ORDER BY Naziv ASC";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    CBOdeljenje.Items.Add(myTable.Rows[i][0].ToString());
                }
                //PrikazTabele.DataSource = myTable;
                //PrikazTabele.Columns["ID"].Visible = false;
                connection.Close();

            }
        }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DodajUcenika Form2 = new DodajUcenika();
            Form2.ShowDialog();
            this.OnLoad(e);
            //ovo se aps ne secam sta treba da radi, pitacemo grbica..
        }

        private void SortPrezime_Click(object sender, EventArgs e)
        {
            sortBy = "Prezime";
            Trazi();
            //sortira po prezimenu
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OpadajuceRastuce.Text == "Opadajuce")
            {
                sortWay = "DESC";
                OpadajuceRastuce.Text = "Rastuce";
            }
            else
            {
                sortWay = "ASC";
                OpadajuceRastuce.Text = "Opadajuce";
            }
            Trazi();
            //da li hoces da sortira opadajuce ili rastuce
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sortBy = "Ime";
            Trazi();
            //sortira po imenu
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //search box
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ovo ti kao daje mogucnost da ogranicis rezultate pretrage, po genearciji 
            LoadCBOdl();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ovo ti kao daje mogucnost da ogranicis rezultate pretrage, po odeljenjima
        }


        private void PrikazTabele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<String> row = new List<String>();
            int s = e.RowIndex;
            if (s != null)
            { 
            for (int i = 0; i < 5; i++)
            {
                row.Add(myTable.Rows[s][i].ToString().Replace(" ", ""));
            }
            }
            
            Slike form3 = new Slike(row);
            form3.ShowDialog();
            this.OnLoad(e);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
