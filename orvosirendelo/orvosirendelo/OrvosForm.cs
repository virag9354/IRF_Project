using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orvosirendelo
{
    
    public partial class OrvosForm : Form
    {


        Database2Entities1 context = new Database2Entities1();
        public OrvosForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string felhasznalonev = textBoxNev.Text;
            int azonosito;
            


            var orvosa = from o in context.Orvosoks
                        where o.OrvosNev == textBoxNev.Text
                        select o;



           
            foreach (var item in orvosa)
            {
                // ha a felhasználónév nem jó
                MessageBox.Show(item.OrvosNev);
                if (item.OrvosNev != null)
                {

                    if (item.Jelszo == textBoxJelszo.Text)
                    {
                        MessageBox.Show("jó");
                        azonosito = item.OrvosSK;

                    }
                    else
                    {
                        MessageBox.Show("hibás");
                    }
                }
                else
                {
                    MessageBox.Show("nincs");
                }
                Orvosform2 of2 = new Orvosform2(felhasznalonev);
                of2.Show();
                this.Hide();


            }
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
