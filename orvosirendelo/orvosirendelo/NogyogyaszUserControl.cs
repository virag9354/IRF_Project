using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orvosirendelo
{

    public partial class NogyogyaszUserControl : UserControl
    {
        DateTime moment = DateTime.Now;
        string kezdet;



        public NogyogyaszUserControl()
        {
            InitializeComponent();

            Idokiiras();

            for (int i = 1; i < 20; i++)
            {
                Label label = new Label();
                Label labell = new Label();

                if (i==1)
                {

                    label.Text = Convert.ToString(0) + Convert.ToString(i + 7) + ":00 - 0" + Convert.ToString(i + 7) + ":30";

                    labell.Text = Convert.ToString(0) + Convert.ToString(i + 7) + ":30 - 0" + Convert.ToString(i + 8) + ":00";

                }
                else if (i == 2)
                {

                        label.Text = Convert.ToString(0) + Convert.ToString(i + 7) + ":00 - 0" + Convert.ToString(i + 7) + ":30";

                        labell.Text = Convert.ToString(0) + Convert.ToString(i + 7) + ":30 - " + Convert.ToString(i + 8) + ":00";

                }
                else if (i>2)
                {

                        label.Text = Convert.ToString(i + 7) + ":00 - " + Convert.ToString(i + 7) + ":30";

                        labell.Text = Convert.ToString(i + 7) + ":30 - " + Convert.ToString(i + 8) + ":00";

                }

                label.AutoSize = false;
                label.Width = 80;
                label.Height = 24;
                label.Left = 3;
                label.Top = 6+(i-1)*62;
                label.Font = new Font("Times New Roman", 8);
                label.BorderStyle = BorderStyle.FixedSingle;
                labell.AutoSize = false;
                labell.Width = 80;
                labell.Height = 24;
                labell.Left = 3;
                labell.Top = 36 + (i - 1) * 62;
                labell.Font = new Font("Times New Roman", 8);
                labell.BorderStyle = BorderStyle.FixedSingle;


                panel1.Controls.Add(label);
                panel1.Controls.Add(labell);



            }

            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { panel1.VerticalScroll.Value = vScrollBar1.Value; };
            panel1.Controls.Add(vScrollBar1);







        }

        private void Idokiiras()
        {
            label1.Text = moment.ToString("yyyy/MMMM");
            int nap = moment.Day;
            int naph = int.Parse(moment.DayOfWeek.ToString("d"));

            kezdet = (nap - naph + 1).ToString();
            label2.Text = kezdet;
            label3.Text = " - ";
            label4.Text = (int.Parse(kezdet) + 6).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moment = moment.AddDays(-7);
            Idokiiras();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            moment = moment.AddDays(7);
            Idokiiras();

        }


    }



    }

