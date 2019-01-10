using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class PalindromeChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite rijec za koju zelite provjeriti da li je palindrom.");
            var rijec = Console.ReadLine();
            var palindrom = false;

            if (rijec.Length % 2 == 0)
            {
                palindrom = false;
            }
            else
            {

                var sredinaRijeci = rijec.Length / 2;
                var slova = rijec.ToCharArray();

                for (var i = 0; i < sredinaRijeci; i++)
                {
                    for (var y = slova.Length - 1; y > sredinaRijeci; y--)
                    {
                        if (slova[i] == slova[y])
                            palindrom = true;
                    }
                }
            }

            if (palindrom)
                Console.WriteLine("Rijec je palindrom.");
            else Console.WriteLine("Rijec nije palindrom.");
        }
    }
}
