using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arhiva
{
    public partial class UnosKonekcionogStringa : Form
    {
        public UnosKonekcionogStringa()
        {
            InitializeComponent();
            var cm = ConfigurationManager.ConnectionStrings["ArhivaConnectionString"];
            if (cm == null) { textBox1.Text = ""; return; }
            var proveriConnString = cm.ConnectionString;
            if (!String.IsNullOrWhiteSpace(proveriConnString))
            {
                textBox1.Text = proveriConnString;
            }
            else textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Konekcija.konekcionistring = textBox1.Text;
            if (Konekcija.testConnection())
            {
                var cm = ConfigurationManager.ConnectionStrings["ArhivaConnectionString"];
                if (cm == null || String.IsNullOrWhiteSpace(cm.ConnectionString)) 
                {
                    Konekcija.AddConnectionStrings("ArhivaConnectionString", Konekcija.konekcionistring);
                }
                else
                {
                    Konekcija.UpdateConnectionStrings("ArhivaConnectionString", Konekcija.konekcionistring);
                }



                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Unet je neispravan konekcioni string");
                textBox1.Focus();
            }
        }
    }
}
