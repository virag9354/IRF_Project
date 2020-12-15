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
        DateTime moment = DateTime.Now;
        public Orvosform2(string felhasznalonev)
        {
            InitializeComponent();
            label1.Text = felhasznalonev;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            OJelenletUserControl ouc = new OJelenletUserControl();
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

        }
    }
}
