using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite broj kreditne kartice (16 znamenaka)");

            var brojKartice = Console.ReadLine();

            var brojeviIntArray = brojKartice.Select(znamenka => Convert.ToInt32(znamenka.ToString())).ToArray();

            var svakiDrugiZaMnozenje = new List<int>();

            for (var i = 0; i < brojeviIntArray.Length - 1; i++)
            {
                if (i == 0 || i % 2 == 0)
                    svakiDrugiZaMnozenje.Add(brojeviIntArray[i] * 2);
                else svakiDrugiZaMnozenje.Add(brojeviIntArray[i]);
            }

            var brojeviStringArray = svakiDrugiZaMnozenje.Select(znamenka => znamenka.ToString()).ToArray();
            var brojeviString = string.Join("", brojeviStringArray);

            var brojeviIntArray2 = brojeviString.Select(znamenka => Convert.ToInt32(znamenka.ToString())).ToArray();

            var sum = 0;
            foreach (var broj in brojeviIntArray2)
            {
                sum += broj;
            }

            var brojZaValidaciju = sum + brojeviIntArray[brojeviIntArray.Length - 1];

            if (brojZaValidaciju % 10 == 0)
                Console.WriteLine("Broj kartice je ispravan");
            else Console.WriteLine("Broj kartice nije ispravan");
        }
    }
}
