using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursisten
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays in C#

            Console.WriteLine("Hoeveel mensen zijn er?");

            string invoer = Console.ReadLine();
            int aantal = int.Parse(invoer);

            // Dit kan ook in 1 regel code:
            //int aantal2 = int.Parse(Console.ReadLine());

            string[] namen = new string[aantal];

            for (int i=0; i < aantal; i++)
            {
                Console.Write("Geef naam {0:D3} op:", i + 1);
                namen[i] = Console.ReadLine();
            }

            Console.WriteLine("De volgende namen zijn ingevoerd:");

            // een nieuwe for!

            int nummer = 1;

            Console.WriteLine("Er zijn {0} namen ingevoerd:", namen.Length);

            foreach(string naam in namen)
            {
                Console.WriteLine("{0}. {1}", nummer, naam);
                nummer++;
            }

            // 1) WriteLine alle getallen van 10 tot en met 100

            for(int i=10; i<=100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("============");

            // 2) Idem maar toon nu 10, 12, 14 etc.... 100
            for (int i = 0; i <= 100; i += 2)
            {
                // D3 betekent drie cijfers, eventueel met voorloopnullen
                // Dus 000, 001, 002 etc t/m 100
                Console.WriteLine("{0:D3}", i);
            }

            Console.WriteLine("============");

            // 3) Idem en toon nu 1000, 900, 800 ...... 0
            for (int i = 1000; i >= 0; i -= 100)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("============");

            // 4) Idem en toon nu 10, 9, 8, .... 0 en dan zijn we klaar!
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }


            string steden = "Zwolle,Groningen,Leeuwarden,Utrecht";

            string[] parts = steden.Split(',');

            for (int i=0; i< parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }

        }
    }
}
