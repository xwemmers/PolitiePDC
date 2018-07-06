using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Voorbeelden met Functies ====");

            // Code snippets: cw  for   if

            Console.WriteLine(Optellen(2,3));
            Console.WriteLine(Optellen(2,3, 10));

            List<int> lijst = new List<int>();
            lijst.Add(10);
            lijst.Add(20);
            lijst.Add(40);
            lijst.Add(25);

            Console.WriteLine("De som van de getallen is: {0}", Optellen(lijst));
            Console.WriteLine("Het aantal getallen: {0}", lijst.Count());
            Console.WriteLine("Het gemiddelde van deze getallen: {0}", Gemiddelde(lijst));
            Console.WriteLine("De C# variant Average: {0}", lijst.Average());

            Console.WriteLine("Faculteit van -5 is: {0}", Faculteit(-5));
            Console.WriteLine("Faculteit van 0 is: {0}", Faculteit(0));
            Console.WriteLine("Faculteit van 5 is: {0}", Faculteit(5));
            Console.WriteLine("Faculteit van 10 is: {0}", Faculteit(10));
            Console.WriteLine("Faculteit van 25 is: {0}", Faculteit(25));
            Console.WriteLine("Faculteit van 30 is: {0}", Faculteit(30));
            Console.WriteLine("Faculteit van 31 is: {0}", Faculteit(31));
            Console.WriteLine("Faculteit van 32 is: {0}", Faculteit(32));
            Console.WriteLine("Faculteit van 33 is: {0}", Faculteit(33));
            Console.WriteLine("Faculteit van 34 is: {0}", Faculteit(34));
            Console.WriteLine("Faculteit van 35 is: {0}", Faculteit(35));
            Console.WriteLine("Faculteit van 50 is: {0}", Faculteit(50));
            Console.WriteLine("Faculteit van 100 is: {0}", Faculteit(100));
            Console.WriteLine("Faculteit van 250 is: {0}", Faculteit(250));
            Console.WriteLine("Faculteit van 1000 is: {0}", Faculteit(1000));
        }

        static int Optellen(int a, int b = 0, int c = 0)
        {
            return a + b + c;
        }





        static int Optellen(List<int> getallen)
        {
            

            int som = 0;

            foreach (int getal in getallen)
            {
                som = som + getal;
            }

            return som;
        }
        


        // Functie Gemiddelde van een lijst integers

        static double Gemiddelde(List<int> getallen)
        {
            // bereken de som
            double som = Optellen(getallen);

            // deel door het aantal getallen
            double gemiddelde = som / getallen.Count;

            // return die waarde
            return gemiddelde;
        }

        // Functie die het grootste getal teruggeeft:
        static int Maximum(List<int> getallen)
        {

            // Test ook of de lijst leeg is!
            if (getallen.Count == 0)
                return 0;

            int max = getallen[0];
            //int max = int.MinValue;

            foreach (int getal in getallen)
            {
                // check of getal groter is dan wat je tot nu toe gevonden hebt
                if (getal > max)
                    max = getal;
            }

            return max;
        }

        // De functie Faculteit(5) ???      5 * Faculteit(4)

        static double Faculteit(int getal)
        {
            if (getal < 0)
                return -Faculteit(-getal);

            if (getal == 0)
                return 1;

            return getal * Faculteit(getal - 1);
        }

        
    }
}
