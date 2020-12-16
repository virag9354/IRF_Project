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


        Database2Entities3 context = new Database2Entities3();
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

                if (item.OrvosNev != null)
                {

                    if (item.Jelszo == textBoxJelszo.Text)
                    {
                        azonosito = item.OrvosSK;

                    }
                    else
                    {
                        
                    }
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


        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
