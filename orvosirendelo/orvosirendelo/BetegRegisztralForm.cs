using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orvosirendelo
{
    public partial class BetegRegisztralForm : Form
    {
        Database2Entities1 context = new Database2Entities1();
        bool egyezik;
        public int hibas;
        public int hibas1=1;
        public int hibas2=1;
        public int hibas3=1;
        public int hibas4=1;
        public int hibas5=1;
        public int hibas6=1;
        public int hibas7=1;

        public BetegRegisztralForm()
        {
            InitializeComponent();
            context.Orvosfajtaks.Load();
            context.Orvosoks.Load();
            context.Idoes.Load();
            context.Idoponts.Load();
            context.Betegeks.Load();
            
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            hibas = hibas1 + hibas2 + hibas3 + hibas4 + hibas5 + hibas6 + hibas7;
            if (hibas != 0)
            {

                MessageBox.Show("Az adatok nem megfelelőek");
            }
            else
            {

                Betegek person = new Betegek();

                // Adatok feltöltése

                person.BetegNev = nevTextBox.Text;
                person.SZIG = textBoxSZIG.Text;
                person.TAJ = textBoxTAJ.Text;
                person.Email= emailTextBox.Text;
                person.Telefonszám= telefonTextBox.Text;
                person.Jelszo= textBoxJel2.Text;

                context.Betegeks.Add(person);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                


                // Rekord hozzáadása az adatforráshoz
                //.Add(person);

                BetegsegForm bf = new BetegsegForm();
                bf.Show();
            }
            
        }

        private void nevTextBox_Validating(object sender, CancelEventArgs e)
        {
            //  NÉZZE MEG VAN E ILYEN NÉV AZ ADATBÁZISBAN
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(nevTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(nevTextBox.Text))
                    nevTextBox.BackColor = Color.LightGreen;
                else
                    nevTextBox.BackColor = Color.White;
                hibas1 = 0;
            }
            else
            {
                e.Cancel = false;
                nevTextBox.BackColor = Color.MediumVioletRed;
                hibas1 = 1;
            }

        }

        private void textBoxSZIG_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(^[A-Z]{2}-?[0-9]{6}$)|(^[0-9]{6}-?[A-Z]{2}$)");

            if (regex.IsMatch(textBoxSZIG.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textBoxSZIG.Text))
                    textBoxSZIG.BackColor = Color.LightGreen;
                else
                    textBoxSZIG.BackColor = Color.White;
                hibas2 = 0;
            }
            else
            {
                e.Cancel = false;
                textBoxSZIG.BackColor = Color.MediumVioletRed;
                hibas2 = 1;

            }

        }

        private void textBoxTAJ_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{9}$");

            if (regex.IsMatch(textBoxTAJ.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textBoxTAJ.Text))
                    textBoxTAJ.BackColor = Color.LightGreen;
                else
                    textBoxTAJ.BackColor = Color.White;
                hibas3 = 0;
            }

            else
            {
                e.Cancel = false;
                textBoxTAJ.BackColor = Color.MediumVioletRed;
                hibas3 = 1;
            }

        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(^$)|(^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$)");

            if (regex.IsMatch(emailTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(emailTextBox.Text))
                    emailTextBox.BackColor = Color.LightGreen;
                else
                    emailTextBox.BackColor = Color.White;
                hibas4 = 0;
            }
            else
            {
                e.Cancel = false;
                emailTextBox.BackColor = Color.MediumVioletRed;
                hibas4 = 1;
            }

        }

        private void telefonTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{11}$");

            if (regex.IsMatch(telefonTextBox.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(telefonTextBox.Text))
                    telefonTextBox.BackColor = Color.LightGreen;
                else
                    telefonTextBox.BackColor = Color.White;
                hibas5 = 0;
            }
            else
            {
                e.Cancel = false;
                telefonTextBox.BackColor = Color.MediumVioletRed;
                hibas5 = 1;
            }
        }

        private void textBoxJel1_Validating(object sender, CancelEventArgs e)
        {

            JelszoKetto(e);
            JelszoEgy(e);
        }

        private void JelszoEgy(CancelEventArgs e)
        {
            if (egyezik == true)
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textBoxJel1.Text))
                    textBoxJel1.BackColor = Color.LightGreen;
                else
                    textBoxJel1.BackColor = Color.White;
                hibas6 = 0;
            }

            else
            {
                e.Cancel = false;
                textBoxJel1.BackColor = Color.MediumVioletRed;
                hibas6 = 1;
            }
        }

        private void textBoxJel2_Validating(object sender, CancelEventArgs e)
        {
            JelszoKetto(e);
            JelszoEgy(e);
        }

        private void JelszoKetto(CancelEventArgs e)
        {
            if (textBoxJel1.Text == textBoxJel2.Text)
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textBoxJel2.Text))
                    textBoxJel2.BackColor = Color.LightGreen;

                else
                    textBoxJel2.BackColor = Color.White;
                egyezik = true;
                hibas7 = 0;
            }

            else
            {
                e.Cancel = false;
                textBoxJel2.BackColor = Color.MediumVioletRed;
                egyezik = false;
                hibas7 = 1;
                //  HA EZ NEM JÓ, AZ ELŐZŐ SE LEGYEN JÓ?
            }
        }

        private void textBoxJel2_TextChanged(object sender, EventArgs e)
        {
            this.Validate();



        }

        private void nevTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void textBoxSZIG_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void textBoxTAJ_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void telefonTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void textBoxJel1_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BetegForm bf = new BetegForm();
            bf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
