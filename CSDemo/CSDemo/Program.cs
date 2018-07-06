using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Goedemorgen!");
            Console.WriteLine("Mijn naam is Xander");

            Console.WriteLine("Wat is je naam?");

            string voornaam = Console.ReadLine();

            Console.WriteLine("Wat is je achternaam?");

            string achternaam = Console.ReadLine();

            Console.Write("Goedemorgen, jouw naam is: ");
            Console.WriteLine(voornaam + " " + achternaam);

            Console.WriteLine("Goedemorgen, jouw naam is: " + voornaam + " " + achternaam);

            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy hh:mm"));

            decimal getal = 20;

            getal += 10;
            getal *= 2;
            getal /= 3;

            getal /= 3;

            Console.WriteLine(getal);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            uint grootgetal = uint.MaxValue;
            Console.WriteLine(grootgetal);
            grootgetal++;
            Console.WriteLine(grootgetal);

        }
    }
}
