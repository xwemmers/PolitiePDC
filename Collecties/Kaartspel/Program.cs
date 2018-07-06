using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaartspel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Speelkaart> spel = new List<Speelkaart>();

            foreach (Kaartsoort soort in Enum.GetValues(typeof(Kaartsoort)))
            {
                foreach (Kaartwaarde waarde in Enum.GetValues(typeof(Kaartwaarde)))
                {
                    Speelkaart kaart = new Speelkaart();
                    kaart.waarde = waarde;
                    kaart.soort = soort;
                    spel.Add(kaart);
                }
            }

            Random r = new Random();

            Kaartsoort troef = (Kaartsoort)r.Next(0, 4);

            Console.WriteLine("De troef is {0}!", troef);

            List<Speelkaart> noordhand = new List<Speelkaart>();

            for (int i = 0; i < 13; i++)
            {
                int index = r.Next(0, spel.Count);
                Speelkaart randomkaart = spel[index];
                noordhand.Add(randomkaart);

                // Haal de kaart ook uit het spel
                spel.RemoveAt(index);
            }

            // Kies random 13 kaarten voor de noordhand
            // Toon de 13 kaarten van de noordhand
            foreach (Speelkaart k in noordhand)
            {
                Console.WriteLine("{0} {1}", k.soort, k.waarde);
            }

        }

    }

    struct Speelkaart
    {
        // Een struct is een combinatie van een aantal eigenschappen
        public Kaartsoort soort;
        public Kaartwaarde waarde;
    }

    enum Kaartsoort
    {
        Klaveren, Ruiten, Harten, Schoppen
    }

    enum Kaartwaarde
    {
        Twee, Drie, Vier, Vijf, Zes, Zeven, Acht, Negen, Tien, Boer, Vrouw, Heer, Aas
    }
}
