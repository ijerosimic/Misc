using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class fibonacci
    {
        static void Main(string[] args)
        {
            var sekvenca = new List<int> { 0, 1, 1 };

            Console.WriteLine("Unesite broj do kojeg zelite kreirati fibonaccijev niz");
            var broj = Convert.ToInt32(Console.ReadLine());

            if (broj < 1 || broj > 14)
            {
                broj = 14;
            }

            else if (broj <= 3)
            {
                var ispis = sekvenca.Take(broj);

                foreach (var znamenka in ispis)
                    Console.Write(znamenka + " ");
                Console.WriteLine();
            }

            else
            {
                for (var i = 3; i < broj; i++)
                {
                    var prviZaZbroj = sekvenca[i - 2];   // sekvenca[3]
                    var drugiZaZbroj = sekvenca[i - 1];   // sekvenca[2]

                  sekvenca.Add(prviZaZbroj + drugiZaZbroj);
                }

                var ispis = sekvenca.Take(broj);

                foreach (var znamenka in ispis)
                    Console.Write(znamenka + " ");
                Console.WriteLine();
            }
        }
    }
}
