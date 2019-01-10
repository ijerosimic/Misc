using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllText(@"C:\Users\ijerosimic\Documents\kajIma.txt");
            Console.WriteLine(input);

            var rijeci = input.Split(' ');

            Console.Write("Upisite broj rijeci za summary: ");
            var brojRijeciZaSummary = rijeci.Take(Convert.ToInt16(Console.ReadLine()));

            var summary = string.Join(" ", brojRijeciZaSummary);

            Console.WriteLine(summary + "...");

            //var rijeci = input.Replace(" ", "");
            //rijeci.ToCharArray();

            //var suma = 0;

            //foreach (var rijec in rijeci)
            //    suma++;

            //Console.WriteLine("Broj rijeci u tekstu je: " + suma);
        }
    }
}
