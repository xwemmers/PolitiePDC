using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Wat is je voornaam?");
            //string voornaam = Console.ReadLine();

            //Console.WriteLine("Wat is je achternaam?");
            //string achternaam = Console.ReadLine();

            ////Console.WriteLine("Goedemiddag " + voornaam + " " + achternaam + ".");

            //Console.WriteLine("Goedemiddag {0} {1}.", voornaam, achternaam);

            ////Console.WriteLine($"Goedemiddag {voornaam} {achternaam}.");

            //// Vraag de invoer en dat is van het type string
            //Console.WriteLine("Voer twee getallen in:");
            //string invoer1 = Console.ReadLine();

            //// Dan parse de invoer (converteren) van string naar int
            //int getal1 = int.Parse(invoer1);

            //// en dan de tweede invoer etc...
            //string invoer2 = Console.ReadLine();
            //int getal2 = int.Parse(invoer2);

            //int som = getal1 + getal2;
            //int verschil = getal1 - getal2;
            //int product = getal1 * getal2;

            //Console.WriteLine("De som van {0} en {1} is {2}", getal1, getal2, som);
            //Console.WriteLine("Het verschil tussen {0} en {1} is {2}", getal1, getal2, verschil);
            //Console.WriteLine("Het product van {0} en {1} is {2}", getal1, getal2, product);

            //if (getal2 != 0)
            //{
            //    int quotient = getal1 / getal2;
            //    Console.WriteLine("Het quotient van {0} en {1} is {2}", getal1, getal2, quotient);
            //}
            //else
            //{
            //    Console.WriteLine("Delen door nul is helaas niet mogelijk.");
            //}

            //// Bereken de wortel van beide getallen (indien positief)

            //// a) Vraag om je geboortejaar en bereken je leeftijd

            //Console.Write("Geef je geboortejaar: ");
            //string invoerJaar = Console.ReadLine();
            //int jaar = int.Parse(invoerJaar);

            //// And then?



            //// b) Let ook op maand en dag :-)
            //Console.Write("Geef je geboortemaand: ");
            //string invoerMaand = Console.ReadLine();
            //int maand = int.Parse(invoerMaand);

            //Console.Write("Geef je geboortedag: ");
            //string invoerDag = Console.ReadLine();
            //int dag = int.Parse(invoerDag);

            //// Deze leeftijd kan er eentje naast zitten:
            //int leeftijd = DateTime.Now.Year - jaar;

            //// Als je dit jaar nog niet jarig bent geweest, dan leeftijd--
            //if (maand > DateTime.Now.Month)
            //    leeftijd--;

            //if (maand == DateTime.Now.Month && dag > DateTime.Now.Day)
            //    leeftijd--;

            //Console.WriteLine("Je leeftijd is {0}.", leeftijd);

            //  07-02-1974

            Console.WriteLine("Wat is je geboortedatum?");

            string invoer = Console.ReadLine();

            string[] delen = invoer.Split('-');

            int dag = int.Parse(delen[0]);
            int maand = int.Parse(delen[1]);
            int jaar = int.Parse(delen[2]);

            DateTime gebdat = new DateTime(jaar, maand, dag);

            Console.WriteLine(DateTime.Now - gebdat);

            TimeSpan verschil = DateTime.Now - gebdat;


            Console.WriteLine("Je bent {0} ms oud!", verschil.TotalMilliseconds);



            DateTime eenWeekLater = gebdat.AddDays(7);

            DateTime vakantiedag = gebdat.AddMonths(-9);

            Console.WriteLine("Je bent geconcipieerd op {0:dd-MM-yyyy}!", vakantiedag);
        }
    }
}
