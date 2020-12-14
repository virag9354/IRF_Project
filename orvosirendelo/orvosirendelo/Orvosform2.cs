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
        public Orvosform2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrvosJelenlet oj = new OrvosJelenlet();
            oj.Show();
            this.Hide();

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
    }
}
