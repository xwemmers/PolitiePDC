using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorksDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdventureWorksEntities db = new AdventureWorksEntities();

            var query = from p in db.Products
                        where p.Name.Contains("bike")
                        || p.ProductCategory.Name.Contains("bike")
                        select p;

            // Laat de SQL zien
            MessageBox.Show(query.ToString());

            dataGridView1.DataSource = query.ToList();
        }
    }
}
