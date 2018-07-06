using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collecties
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namen = new List<string>();

            // Voer namen in totdat de gebruiker 'stop' zegt

            string invoer = "";

            while(true)
            {
                Console.Write("Voer een naam in: ");
                invoer = Console.ReadLine();

                // Beeindig de while met het break keyword
                if (invoer.ToLower() == "stop")
                    break;

                namen.Add(invoer);
            }

            // Roep de functie NamenTonen aan en geef als argument (parameter)
            // de lijst van namen mee:
            NamenTonen(namen, "personen");

            List<string> steden = new List<string>();
            steden.Add("Zwolle");
            steden.Add("Drachten");
            steden.Add("Utrecht");
            steden.Add("Meppel");

            NamenTonen(steden, "steden");
        }


        static void NamenTonen(List<string> dingen, string soort)
        {
            Console.WriteLine("Er zijn nu {0} {1}.", dingen.Count(), soort);

            int nummer = 1;

            foreach (string naam in dingen)
            {
                Console.WriteLine("{0}. {1}", nummer, naam);
                nummer++;
            }
        }


    }
}
