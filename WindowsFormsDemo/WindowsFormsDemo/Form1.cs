using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEersteKnop_Click(object sender, EventArgs e)
        {
            string naam = txtFirstname.Text;
            string achternaam = txtAchternaam.Text;

            //MessageBox.Show("Goedemiddag " + naam + " " + achternaam);

            label3.Text = "Goedemiddag " + naam + " " + achternaam + 
                " " + dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }

        private void btnTweedeKnop_Click(object sender, EventArgs e)
        {

        }
    }
}
