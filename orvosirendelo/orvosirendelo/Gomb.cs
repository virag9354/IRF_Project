using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orvosirendelo
{
    public class Gomb: Button
    {
        Database2Entities1 context = new Database2Entities1();
        int orvose;
        bool szabad;

        public Gomb()
        {
            Width = 82;
            Height = 25;



            }
    }
}
