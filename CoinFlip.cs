using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            var heads = 0;
            var tails = 0;

            Console.WriteLine("Enter za bacanje. Esc za prekid.");
            Console.WriteLine();

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Random random = new Random();
                int coinFlip = random.Next(0, 2);

                if (coinFlip == 0)
                    heads++;
                else tails++;

                Console.WriteLine("Heads: " + heads);
                Console.WriteLine("Tails: " + tails);
                Console.WriteLine();

                continue;
            }
        }
    }
}
