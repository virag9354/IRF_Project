﻿using System;
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
    public partial class OJelenletUserControl : UserControl
    {
        Database2Entities2 context = new Database2Entities2();
        DateTime moment = DateTime.Now;
        string kezdet;
        public OJelenletUserControl(string felhasznalonev)
        {
            InitializeComponent();
            Idokiiras();
            label12.Text = felhasznalonev;


            //Labelek kirakása

            for (int i = 1; i < 12; i++)
            {
                Cimke label = new Cimke();
                Cimke labell = new Cimke();

                if (i == 1)
                {

                    label.Text = Convert.ToString(0) + Convert.ToString(i + 7) + ":00 - 0" + Convert.ToString(i + 7) + ":30";

                    labell.Text = Convert.ToString(0) + Convert.ToString(i + 7) + ":30 - 0" + Convert.ToString(i + 8) + ":00";

                }
                else if (i == 2)
                {

                    label.Text = Convert.ToString(0) + Convert.ToString(i + 7) + ":00 - 0" + Convert.ToString(i + 7) + ":30";

                    labell.Text = Convert.ToString(0) + Convert.ToString(i + 7) + ":30 - " + Convert.ToString(i + 8) + ":00";

                }
                else if (i > 2)
                {

                    label.Text = Convert.ToString(i + 7) + ":00 - " + Convert.ToString(i + 7) + ":30";

                    labell.Text = Convert.ToString(i + 7) + ":30 - " + Convert.ToString(i + 8) + ":00";

                }

                label.Left = 3;
                label.Top = 6 + (i - 1) * 62;
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
                for (int j = 0; j < 22; j++)
                {
                    Gomb btn = new Gomb();

                    btn.Top = 4 + j * 31;
                    btn.Left = 80 + i * 83;
                    btn.Kivalasztva = false;
                    btn.datum = moment.Date;


                    panel1.Controls.Add(btn);


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


        private void button1_Click_1(object sender, EventArgs e)
        {
            moment = moment.AddDays(7);
            Idokiiras();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            moment = moment.AddDays(-7);
            Idokiiras();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Gomb item in panel1.Controls.OfType<Gomb>())
            {
                if (item.Kivalasztva)
                {
                    string felhasznalonev = label12.Text;
                    Orvosjelenlet oj = new Orvosjelenlet();
                    if (felhasznalonev== "Dr.Farkas Viola")
                    {
                        oj.OrvosFK = 1;
                        MessageBox.Show(felhasznalonev);
                        MessageBox.Show(item.datum.ToString());
                    }
                    else if (felhasznalonev=="Dr. Cserepes Etelka")
                    {
                        oj.OrvosFK = 2;
                        MessageBox.Show(felhasznalonev);
                    }
                    else if (felhasznalonev=="Dr. Csömöri Márta")
                    {
                        oj.OrvosFK = 3;
                    }
                    else if (felhasznalonev == "Dr. Újházy Klára")
                    {
                        oj.OrvosFK = 4;
                    }
                    else if (felhasznalonev == "Dr. Pataki Gábor")
                    {
                        oj.OrvosFK = 5;
                    }
                    else if (felhasznalonev == "Dr. Rajkóczi Zita")
                    {
                        oj.OrvosFK = 6;
                    }

                    
                    oj.Datum = item.datum;
                    //oj.IdoFK = item.idopont;
                    oj.szabad = "szabad";

                    context.Orvosjelenlets.Add(oj);

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
    }
}
