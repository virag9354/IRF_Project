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
        Database2Entities2 context = new Database2Entities2();


        public NogyogyaszUserControl()
        {
            InitializeComponent();

            Idokiiras();

            //Labelek kirakása

            for (int i = 1; i < 10; i++)
            {
                Cimke label = new Cimke();
                Cimke labell = new Cimke();

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

                label.Left = 3;
                label.Top = 6+(i-1)*62;
                label.Font = new Font("Times New Roman", 8);
                labell.Left = 3;
                labell.Top = 36 + (i - 1) * 62;
                labell.Font = new Font("Times New Roman", 8);
                panel1.Controls.Add(label);
                panel1.Controls.Add(labell);



            }

            // button kirakás

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    Gomb btn = new Gomb();

                    btn.Top = 4 + j * 31;
                    btn.Left = 80 + i * 83;
                    if (i<4)
                    {
                        btn.BackColor = Color.Tan;
                        btn.orvosszam = 6;
                    }
                    else if (i>3)
                    {
                        btn.BackColor = Color.LightBlue;
                        btn.orvosszam = 5;
                    }
                    if (j == 8)
                    {
                        btn.BackColor = Color.Gray;
                        btn.Enabled = true;
                    }
                    else if (j==9)
                    {
                        btn.BackColor = Color.Gray;
                        btn.Enabled = true;
                    }

                    panel1.Controls.Add(btn);

                    int naph = int.Parse(moment.DayOfWeek.ToString("d"));
                    DateTime hetfo = moment.AddDays(-naph + 1);

                    btn.datum = hetfo.AddDays(i);
                    btn.ido = j + 1;

                    





                }
            }


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

        private void button3_Click(object sender, EventArgs e)
        {
            Idopont ip = new Idopont();
        //    ip.IdoFK = btn.ido;
        //    ip.Datum = btn.datum;
        //    ip.OrvosFK = btn.orvosszam;

            context.Idoponts.Add(ip);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }



    }

