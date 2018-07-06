using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// We hebben deze namespace nodig voor de File class
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace PersonenBeheer
{
    public partial class Form1 : Form
    {
        // Bij het formulier hoort deze lijst van personen:
        List<Persoon> familie = new List<Persoon>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Persoon p = new Persoon();

            p.Voornaam = txtVoornaam.Text;
            p.Achternaam = txtAchternaam.Text;
            p.Geboortedatum = dtpGeboortedatum.Value.Date; // Neem alleen de Date, zonder Time. Time = 0:0:0
            p.Land = cmbLand.Text;

            if (rbMan.Checked)
                p.Geslacht = GeslachtEnum.Man;

            if (rbVrouw.Checked)
                p.Geslacht = GeslachtEnum.Vrouw;

            if (rbOnbekend.Checked)
                p.Geslacht = GeslachtEnum.Onbekend;


            familie.Add(p);

            // Om de ListBox goed te refreshen moet de Datasource
            // eerst op null (leeg) worden gezet.
            lbxPersonen.DataSource = null;
            lbxPersonen.DataSource = familie;
            lbxPersonen.DisplayMember = "VolledigeNaam";

            // Ook de DataGridView even tijdelijk op null zetten
            dgvPersonen.DataSource = null;
            dgvPersonen.DataSource = familie;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            string contents = "";
            
            foreach(Persoon p in familie)
            {
                // Als je scheidingsteken een komma is, dan weet Excel daar mee om te gaan
                contents += string.Join(",", p.Voornaam, p.Achternaam, p.Geboortedatum, p.Geslacht, p.Land);
                contents += Environment.NewLine;
            }

            // Laat de gebruiker een folder en bestand kiezen met de SaveFileDialog:
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            File.WriteAllText(sfd.FileName, contents);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Inlezen van de CSV file

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.ShowDialog();

            string[] alleRegels = File.ReadAllLines(ofd.FileName);

            // Begin met een nieuwe verzameling:
            familie = new List<Persoon>();

            foreach(string regel in alleRegels)
            {
                // Yannick;Wemmers;5-Jun-08 00:00:00;Male;Nederland

                Persoon p = new Persoon();

                string[] velden = regel.Split(',');

                p.Voornaam = velden[0];
                p.Achternaam = velden[1];
                p.Geboortedatum = DateTime.Parse(velden[2]);

                // ook Enum kan worden geparsed, maar ingewikkelder dan DateTime.Parse
                // Het alternatief is om drie if-jes te schrijven
                // Of de switch statement (met cases)
                p.Geslacht = (GeslachtEnum)Enum.Parse(typeof(GeslachtEnum), velden[3]);

                p.Land = velden[4];

                familie.Add(p);
            }

            lbxPersonen.DataSource = familie;
            dgvPersonen.DataSource = familie;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Geef me alle mannen:
            
            // SQL in C# = LINQ!

            var query = from p in familie
                        where p.Geslacht == GeslachtEnum.Man
                        select p;

            List<Persoon> resultaat = query.ToList();

            lbxPersonen.DataSource = resultaat;
            dgvPersonen.DataSource = resultaat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var query = from p in familie
                        where p.Geslacht == GeslachtEnum.Vrouw
                        select p;

            List<Persoon> resultaat = query.ToList();

            lbxPersonen.DataSource = resultaat;
            dgvPersonen.DataSource = resultaat;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var query = from p in familie
                        where p.Leeftijd > 40
                        select p;

            List<Persoon> resultaat = query.ToList();

            lbxPersonen.DataSource = resultaat;
            dgvPersonen.DataSource = resultaat;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var query = from p in familie
                        orderby p.Geboortedatum
                        select p;

            List<Persoon> resultaat = query.ToList();

            lbxPersonen.DataSource = resultaat;
            dgvPersonen.DataSource = resultaat;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Zoek op voornaam en op achternaam

            string zoekterm = txtZoekveld.Text.ToLower();

            var query = from p in familie
                        where p.Voornaam.ToLower().Contains(zoekterm)
                        || p.Achternaam.ToLower().Contains(zoekterm)
                        select p;

            List<Persoon> resultaat = query.ToList();

            lbxPersonen.DataSource = resultaat;
            dgvPersonen.DataSource = resultaat;
        }

        private void txtZoekveld_TextChanged(object sender, EventArgs e)
        {
            string zoekterm = txtZoekveld.Text.ToLower();

            //if (zoekterm.Length < 2)
            //    return;

            var query = from p in familie
                        where p.Voornaam.ToLower().Contains(zoekterm)
                        || p.Achternaam.ToLower().Contains(zoekterm)
                        select p;

            List<Persoon> resultaat = query.ToList();

            lbxPersonen.DataSource = resultaat;
            dgvPersonen.DataSource = resultaat;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //string[] namen = new[] { "Erik", "Jantinus", "Eric", "Maureen", "Sandy", "Henk" };

            //var query = from naam in namen
            //            where naam.Length == 4
            //            select naam;

            //lbxPersonen.DataSource = query.ToList();



            int[] getallen = new[] { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            var query2 = from getal in getallen
                         where getal % 3 == 0
                         orderby getal descending
                         select getal;

            lbxPersonen.DataSource = query2.ToList();



        }


        /// <summary>
        /// Deze functie telt twee getallen op
        /// </summary>
        /// <param name="getal1">Dit is het eerste getal</param>
        /// <param name="getal2">Dit is het tweede getal</param>
        /// <returns>Ook een getal</returns>
        int Optellen(int getal1, int getal2)
        {
            return getal1 + getal2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XElement root = new XElement("personen");

            int teller = 1;

            foreach(Persoon p in familie)
            {
                XElement eltPersoon = new XElement("persoon");
                root.Add(eltPersoon);

                XAttribute attrID = new XAttribute("id", teller);
                teller++;
                eltPersoon.Add(attrID);

                XElement eltVoornaam = new XElement("voornaam", p.Voornaam);
                eltPersoon.Add(eltVoornaam);

                XElement eltAchternaam = new XElement("achternaam", p.Achternaam);
                eltPersoon.Add(eltAchternaam);

                XElement eltGeboortedatum = new XElement("geboortedatum", p.Geboortedatum);
                eltPersoon.Add(eltGeboortedatum);

                XElement eltGeslacht = new XElement("geslacht", p.Geslacht);
                eltPersoon.Add(eltGeslacht);

                XElement eltLand = new XElement("land", p.Land);
                eltPersoon.Add(eltLand);
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files|*.xml";
            sfd.ShowDialog();


            root.Save(sfd.FileName);
            //root.Save(@"c:\tmp\familie.xml");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files|*.xml";
            ofd.ShowDialog();

            XElement root = XElement.Load(ofd.FileName);

            // Gebruik LINQ 2 XML om te zoeken in de XML

            var query = from elt in root.Elements("persoon")
                        where elt.Element("achternaam").Value.Contains("Wemm")
                        select new
                        {
                            Voornaam = elt.Element("voornaam").Value,
                            Achternaam = elt.Element("achternaam").Value
                        };

            dgvPersonen.DataSource = query.ToList();

            lbxPersonen.DataSource = query.ToList();

            // Geef het eerste element dat aan de where voldoet:
            //XElement resultaat = query.First();
            //List<XElement> resultaten = query.ToList();

            //MessageBox.Show(resultaten.Count.ToString());

            //MessageBox.Show(resultaat.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            XmlElement root = doc.CreateElement("Personen");
            doc.AppendChild(root);

            XmlElement eltPersoon = doc.CreateElement("Persoon");
            root.AppendChild(eltPersoon);

            XmlElement eltVoornaam = doc.CreateElement("Voornaam");
            eltVoornaam.InnerText = "Xander";
            eltPersoon.AppendChild(eltVoornaam);

            XmlElement eltAchternaam = doc.CreateElement("Achternaam");
            eltAchternaam.InnerText = "Wemmers";
            eltPersoon.AppendChild(eltAchternaam);

            MessageBox.Show(doc.OuterXml);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("c:\\tmp\\egypte.xml");

            writer.WriteStartElement("Land");

            writer.WriteString("Egypte");

            writer.WriteEndElement();

            writer.Close();
        }
    }
}
