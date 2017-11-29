using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Imenovanje : Form
    {
        string vrednost;
        public Imenovanje()
        {
            
            InitializeComponent();
        }

        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            vrednost = Tipovi.SelectedItem.ToString();
            this.Close();
        }
        public String Get()
        {
            return vrednost;

        }
        private void Imenovanje_Load(object sender, EventArgs e)
        {
            Tipovi.Items.Clear();
            Tipovi.Items.Add("Svedocanstvo");
            Tipovi.Items.Add("MaticnaKnjiga1");
            Tipovi.Items.Add("MaticnaKnjiga2");
            Tipovi.Items.Add("Ostalo");
            Tipovi.SelectedItem = Tipovi.Items[0];
            Tipovi.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
