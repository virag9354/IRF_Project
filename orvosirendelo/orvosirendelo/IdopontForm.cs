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
    public partial class IdopontForm : Form
    {
        public IdopontForm()
        {
            InitializeComponent();

            panel1.Controls.Clear();

            NogyogyaszUserControl nuc = new NogyogyaszUserControl();

            panel1.Controls.Add(nuc);

            nuc.Dock = DockStyle.Fill;
        }
    }
}
