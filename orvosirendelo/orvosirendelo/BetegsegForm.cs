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
    public partial class BetegsegForm : Form
    {
        public int orvosszam;
        public BetegsegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // beolvasás
            
        }

        private void BetegsegForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new KeyValuePair<string, string>("Válasszon", "0"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Háziorvos", "1"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Bőrgyógyász", "2"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Nőgyógyász", "3"));

            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";

            comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Farkas Viola", "1"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Cserepes Etelka", "2"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Csömöri Márta", "3"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Újházi Klára", "4"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Pataki Gábor", "5"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Rajkóczi Zita", "6"));

            comboBox2.DisplayMember = "key";
            comboBox2.ValueMember = "value";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add(new KeyValuePair<string, string>("Nincs preferenciám", "0"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Farkas Viola", "1"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Cserepes Etelka", "2"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Csömöri Márta", "3"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Újházi Klára", "4"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Pataki Gábor", "5"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Rajkóczi Zita", "6"));

            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add(new KeyValuePair<string, string>("Nincs preferenciám", "0"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Farkas Viola", "1"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Cserepes Etelka", "2"));
                panel1.Controls.Clear();
                HaziorvosUserControl huc = new HaziorvosUserControl();
                panel1.Controls.Add(huc);
                huc.Dock = DockStyle.Fill;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add(new KeyValuePair<string, string>("Nincs preferenciám", "0"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Csömöri Márta", "3"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Újházi Klára", "4"));
                panel1.Controls.Clear();
                BorgyogyaszUserControl buc = new BorgyogyaszUserControl();
                panel1.Controls.Add(buc);
                buc.Dock = DockStyle.Fill;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Add(new KeyValuePair<string, string>("Nincs preferenciám", "0"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Pataki Gábor", "5"));
                comboBox2.Items.Add(new KeyValuePair<string, string>("Dr. Rajkóczi Zita", "6"));
                panel1.Controls.Clear();
                NogyogyaszUserControl nuc = new NogyogyaszUserControl();
                panel1.Controls.Add(nuc);
                nuc.Dock = DockStyle.Fill;
            }

            comboBox2.DisplayMember = "key";
            comboBox2.ValueMember = "value";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                orvosszam = 0;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                orvosszam = 1;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                orvosszam = 2;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                orvosszam = 3;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                orvosszam = 4;
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                orvosszam = 5;
            }
            else if (comboBox2.SelectedIndex == 6)
            {
                orvosszam = 6;
            }

            comboBox2.DisplayMember = "key";
            comboBox2.ValueMember = "value";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BetegForm bf = new BetegForm();
            bf.Show();
            this.Hide();
        }
    }
}
