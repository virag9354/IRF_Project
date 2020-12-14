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
        public DateTime datum { get; set; }

        public int idopont { get; set; }

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
