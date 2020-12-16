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
        Database2Entities2 context =new Database2Entities2();
        public int orvosszam;
        public BetegsegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Idopont ip = new Idopont();
            
            
        }

        private void BetegsegForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new KeyValuePair<string, string>("Válasszon", "0"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Háziorvos", "1"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Bőrgyógyász", "2"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Nőgyógyász", "3"));

            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (comboBox1.SelectedIndex == 1)
            {
                
                panel1.Controls.Clear();
                HaziorvosUserControl huc = new HaziorvosUserControl();
                panel1.Controls.Add(huc);
                huc.Dock = DockStyle.Fill;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                
                panel1.Controls.Clear();
                BorgyogyaszUserControl buc = new BorgyogyaszUserControl();
                panel1.Controls.Add(buc);
                buc.Dock = DockStyle.Fill;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                
                panel1.Controls.Clear();
                NogyogyaszUserControl nuc = new NogyogyaszUserControl();
                panel1.Controls.Add(nuc);
                nuc.Dock = DockStyle.Fill;
                
                
            }


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
