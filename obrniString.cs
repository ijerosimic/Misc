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
            Console.WriteLine("Upisite string koji zelite reversati");
            var input = Console.ReadLine();

            var arr = input.ToCharArray();
            var obrnutiArr = new List<char>();

            for (var i = arr.Length - 1; i >= 0; i--)
            {
                obrnutiArr.Add(arr[i]);
            }

            foreach (var rijec in obrnutiArr)
                Console.WriteLine(rijec);
        }
    }
}
