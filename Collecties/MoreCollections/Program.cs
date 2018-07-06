using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> lijst = new SortedSet<string>();

            lijst.Add("Xander");
            lijst.Add("Simone");
            lijst.Add("Yannick");
            lijst.Add("Mirjam");
            lijst.Add("Jasper");
            lijst.Add("Simone");
            lijst.Add("Jasper");

            foreach (string naam in lijst)
            {
                Console.WriteLine(naam);
            }

            SortedList<int, string> lijst2 = new SortedList<int, string>();
            lijst2.Add(1, "Xander");
            lijst2.Add(3, "Erik");
            lijst2.Add(2, "Eric");
            lijst2.Add(4, "Maureen");

            foreach(int id in lijst2.Keys)
            {
                Console.WriteLine("ID {0} is {1}", id, lijst2[id]);
            }

            Dictionary<string, int> steden = new Dictionary<string, int>();
            steden["Utrecht"] = 350000;
            steden["Amsterdam"] = 850000;
            steden["Zwolle"] = 200000;

            foreach(string key in steden.Keys)
            {
                Console.WriteLine("De stad {0} heeft {1} inwoners.", key, steden[key]);
            }

            // QUEUE is een FIFO (First In First Out)
            Queue<string> rij = new Queue<string>();

            rij.Enqueue("Stofzuigen");
            rij.Enqueue("Boodschappen doen");
            rij.Enqueue("Koken");
            rij.Enqueue("Afwassen");

            Console.WriteLine(rij.Dequeue());
            Console.WriteLine(rij.Dequeue());
            Console.WriteLine(rij.Dequeue());
            Console.WriteLine(rij.Dequeue());

            Stack<string> stapel = new Stack<string>();
            stapel.Push("Stofzuigen");
            stapel.Push("Boodschappen doen");
            stapel.Push("Koken");
            stapel.Push("Afwassen");

            Console.WriteLine(stapel.Pop());
            Console.WriteLine(stapel.Pop());
            Console.WriteLine(stapel.Pop());
            Console.WriteLine(stapel.Pop());
        }
    }
}
