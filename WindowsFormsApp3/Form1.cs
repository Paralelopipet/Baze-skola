﻿using System;
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
        string sortBy = "Ime";
        string sortWay = "ASC";
        string sql = "SELECT Ime, Prezime, Generacija, Odeljenje.Naziv AS Odeljenje  FROM Ucenici INNER JOIN Odeljenje ON Odeljenje.ID = Ucenici.IDOdeljenja";

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
                ime = " Ime='"+Ime.Text+"' ";
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
            sql = "SELECT Ime, Prezime, Generacija, Odeljenje.Naziv AS Odeljenje  FROM Ucenici INNER JOIN Odeljenje ON Odeljenje.ID = Ucenici.IDOdeljenja WHERE ";
            sql += ime+ "AND" + prezime + "AND" + generacija + "AND" + odeljenje;
            
            Trazi();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  

            //ovo bi trebalo da kada stisnes na celiju gde pise necije ime ili prezime da ti otvori novu formu koja te vodi da vidis njegove slike
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Shown(object sender, EventArgs e)
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

            Form2 Form2 = new Form2();
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

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrikazTabele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<String> row = new List<String>();
            int s = e.RowIndex;
            if (s != null)
            { 
            for (int i = 0; i < 4; i++)
            {
                row.Add(myTable.Rows[s][i].ToString().Replace("  ", ""));
            }
            }
            MessageBox.Show(row[0] + " " + row[1]);
            
        }

        
    }
}
