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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(237, 244, 247);
            button1.BackColor = Color.FromArgb(237, 244, 247);
            button2.BackColor = Color.FromArgb(237, 244, 247);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrvosForm of = new OrvosForm();
            of.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BetegForm bf1 = new BetegForm();
            bf1.Show();
            this.Hide();
        }
        

    }
}
