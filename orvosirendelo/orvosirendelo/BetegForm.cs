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
    public partial class BetegForm : Form
    {
        Database2Entities3 context = new Database2Entities3();
        public BetegForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BetegRegisztralForm brf = new BetegRegisztralForm();
            brf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           /* var betega = from o in context.Betegeks
                        where o.BetegNev == textBox1.Text
                        select o;

            foreach (var item in betega)
            {
                // ha a felhasználónév nem jó
                if (item.BetegNev != null)
                {

                    if (item.Jelszo == textBox2.Text)
                    {
                        MessageBox.Show("jó");*/

                        BetegsegForm bf = new BetegsegForm();
                        bf.Show();
                        this.Hide();
                    /*}
                    else
                    {
                        MessageBox.Show("hibás");
                    }
                }
                else
                {
                    MessageBox.Show("nincs");
                }

            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
