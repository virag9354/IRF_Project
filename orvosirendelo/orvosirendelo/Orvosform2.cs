using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orvosirendelo
{
    public partial class Orvosform2 : Form
    {


        Database2Entities3 context = new Database2Entities3();

        BindingList<DgElemek> dge = new BindingList<DgElemek>();

        DateTime moment = DateTime.Now;
        public Orvosform2(string felhasznalonev)
        {
            InitializeComponent();
            label1.Text = felhasznalonev;
            dataGridView1.DataSource = dge;

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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK) return;
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    sw.Write("Időpont");
                    sw.Write(";");
                    sw.Write("Páciens");
                    sw.Write(";");
                    sw.Write("TAJ");
                    sw.WriteLine();
                    
                    foreach (var s in dge)
                    {
                        sw.Write(s.Idopont);
                        sw.Write(";");
                        sw.Write(s.Paciens);
                        sw.Write(";");
                        sw.Write(s.Taj);
                        sw.WriteLine();
                    }
                }
            }
        }

        private void Orvosform2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("2020.12.14.");
            comboBox1.Items.Add("2020.12.15.");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DateTime combodate= DateTime.Parse(comboBox1.SelectedItem.ToString());

            var alkalom = from a in context.Idoponts
                          where a.Datum == combodate

                          select new DgElemek
                          {
                              
                              Idopont=a.Ido.Idotartam,
                              Paciens=a.Betegek.BetegNev,
                              Taj=a.Betegek.TAJ,

                          };
            dge = new BindingList<DgElemek>(alkalom.ToList());
            dataGridView1.DataSource = dge;
        }
    }
}
