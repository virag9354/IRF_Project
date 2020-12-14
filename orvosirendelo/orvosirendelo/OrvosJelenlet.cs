﻿using System;
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
    public partial class OrvosJelenlet : Form
    {
        public OrvosJelenlet()
        {
            InitializeComponent();

            panel1.Controls.Clear();

            OJelenletUserControl ojuc = new OJelenletUserControl();

            panel1.Controls.Add(ojuc);

            ojuc.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orvosform2 of2 = new Orvosform2();
            of2.Show();
            this.Hide();
        }


    }
}