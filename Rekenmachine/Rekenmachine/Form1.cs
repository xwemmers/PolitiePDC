using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // De namen van de TextBoxen kunnen verschillen!

                int getal1 = int.Parse(txtFirstNumber.Text);
                int getal2 = int.Parse(txtSecondNumber.Text);

                if (rbAdd.Checked)
                {
                    int antwoord = getal1 + getal2;
                    lblAnswer.Text = string.Format("{0} + {1} = {2}", getal1, getal2, antwoord);
                }

                if (rbSubtract.Checked)
                {
                    int antwoord = getal1 - getal2;
                    lblAnswer.Text = string.Format("{0} - {1} = {2}", getal1, getal2, antwoord);
                }

                if (rbMultiply.Checked)
                {
                    int antwoord = getal1 * getal2;
                    lblAnswer.Text = string.Format("{0} * {1} = {2}", getal1, getal2, antwoord);
                }

                if (rbDivide.Checked)
                {
                    double antwoord = (double)getal1 / getal2;
                    lblAnswer.Text = string.Format("{0} / {1} = {2}", getal1, getal2, antwoord);
                }

                // Voeg de tekst onderaan toe:
                //lbxHistory.Items.Add(lblAnswer.Text);

                // Of: voeg de tekst bovenaan toe:
                lbxHistory.Items.Insert(0, lblAnswer.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Dit is helemaal geen getal!");
                MessageBox.Show("Dit is de foutboodschap: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Dit getal is te groot!");
                MessageBox.Show("Dit is de foutboodschap: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Een newline is een speciaal teken: \n
                MessageBox.Show("Bel met 06-1234567 de systeembeheerder Maureen.\nGeef dan dit gelijk even door: " + ex.Message);
            }


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Text += "2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form1_Load is geschikt voor initialisatie code
            MessageBox.Show("Welkom!");
            Initialize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        void Initialize()
        {
            txtFirstNumber.Text = "10";
            txtSecondNumber.Text = "10";

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Tot ziens!");
        }

        private void btnCalculate_MouseHover(object sender, EventArgs e)
        {
            //btnCalculate.Enabled = false;
        }

        private void btnCalculate_MouseLeave(object sender, EventArgs e)
        {
            //btnCalculate.Enabled = true;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblAnswer.Text = string.Format(" X = {0} en Y = {1}", e.X, e.Y);
        }
    }
}
