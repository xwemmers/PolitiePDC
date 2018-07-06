using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonenBeheer
{
    class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public GeslachtEnum Geslacht { get; set; }
        public string Land { get; set; }

        // VolledigeNaam is een afgeleide property op basis van Voornam en Achternaam
        // Deze property heeft dan ook geen set!
        public string VolledigeNaam
        {
            get
            {
                return Voornaam + " " + Achternaam;
            }
        }

        public int Leeftijd
        {
            get
            {
                int leeftijd = DateTime.Now.Year - Geboortedatum.Year;

                // Check of je al jarig bent geweest dit jaar. Zo niet, dan een --
                if (Geboortedatum.AddYears(leeftijd) > DateTime.Now)
                    leeftijd--;

                return leeftijd;
            }
        }
    }

    enum GeslachtEnum
    {
        Man, Vrouw, Onbekend
    }
}
