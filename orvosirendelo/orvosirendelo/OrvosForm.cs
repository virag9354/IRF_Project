using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orvosirendelo
{
    public partial class OrvosForm : Form
    {
        Database2Entities context = new Database2Entities();
        public OrvosForm()
        {
            InitializeComponent();
            context.Orvosoks.Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var orvosa = from o in context.Orvosoks
                        where o.OrvosNev == textBoxNev.Text
                        select new { oaz=o.OrvosSK};
            var jelszoa = from j in context.Orvosoks
                          where j.Jelszo == textBoxJelszo.Text
                          select new { jaz=j.OrvosSK};
            MessageBox.Show(orvosa.ToString());
            if (orvosa==jelszoa)
            {
                MessageBox.Show("1");
            }

            






  
        }
    }
}
