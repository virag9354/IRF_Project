using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orvosirendelo
{
    public partial class Orvosform2 : Form
    {
        Database2Entities2 context = new Database2Entities2();
        DateTime moment = DateTime.Now;
        public Orvosform2(string felhasznalonev)
        {
            InitializeComponent();
            label1.Text = felhasznalonev;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string felhasznalonev = label1.Text;
            panel1.Controls.Clear();
            OJelenletUserControl ouc = new OJelenletUserControl(felhasznalonev);
            panel1.Controls.Add(ouc);
            ouc.Dock = DockStyle.Fill;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrvosForm of = new OrvosForm();
            of.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Orvosform2_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add(new KeyValuePair<string, string>("2020.12.14", "1"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("2020.12.15", "2"));

            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string combodate= comboBox1.SelectedItem.ToString();

            var alkalom = from a in context.Idoponts
                          where a.Datum.ToString() == combodate

                          select new
                          {
                              
                              Idopont=a.Ido.Idotartam,
                              Páciens=a.Betegek.BetegNev,


                          };
            dataGridView1.DataSource = alkalom.ToList();

        }
    }
}
