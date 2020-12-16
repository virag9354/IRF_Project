using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orvosirendelo
{
    public class Gomb: Button
    {
        Database2Entities2 context = new Database2Entities2();
        public DateTime datum { get; set; }

        public int ido { get; set; }
        public int orvosszam { get; set; }

        private bool _kivalasztva;

        public bool Kivalasztva
        {
            get { return _kivalasztva; }
            set { _kivalasztva = value;
                if (_kivalasztva)
                {
                    BackColor = Color.Yellow;
                }
                else
                {
                    BackColor = Color.Gray;
                }
            }
        }


        public Gomb()
        {
            Width = 82;
            Height = 25;



            MouseDown += Gomb_MouseDown;
            
        }

        private void Gomb_MouseDown(object sender, MouseEventArgs e)
        {
            Kivalasztva = true;
       

        }
    }
}
