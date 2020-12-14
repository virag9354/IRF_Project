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

            Orvosform2 of2= new Orvosform2();
            of2.Show();


            /*var orvosa = from o in context.Orvosoks
                        where o.OrvosNev == textBoxNev.Text
                        select o;

            foreach (var item in orvosa)
            {
                // ha a felhasználónév nem jó
                MessageBox.Show(item.OrvosNev);
                if (item.OrvosNev!= null)
                {
                
                    if (item.Jelszo==textBoxJelszo.Text)
                    {
                        MessageBox.Show("jó");
                    }
                    else
                    {
                        MessageBox.Show("hibás");
                    }
                }
                else
                {
                    MessageBox.Show("nincs");
                }*/

        }












        
    }
}
