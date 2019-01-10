using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreracunBrutoNeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vaša plaća je: ");
            if (!double.TryParse(Console.ReadLine(), out double placa))
            {
                Console.WriteLine("Greška");
            }

            Console.WriteLine("Odaberite preracun: ");
            Console.WriteLine("1) Bruto > Neto");
            Console.WriteLine("2) Neto > Bruto");

            var odabir = Convert.ToInt16(Console.ReadLine());

            if (odabir == 1)
            {
                foreach (var isplata in PreracunBrutoNeto(placa))
                    Console.WriteLine(isplata);
            }
            else
            {
                // neto > bruto
            }
        }

        public static Array PreracunBrutoNeto(double brutoIznos)
        {
            var isplatnaLista = new double[9];

            double poreznaStopa;
            double prirezStopa = 0.18;

            if (brutoIznos > 17500.00)
                poreznaStopa = 0.36;
            else poreznaStopa = 0.24;

            isplatnaLista[0] = brutoIznos * 0.15;
            isplatnaLista[1] = brutoIznos * 0.05;
            isplatnaLista[2] = isplatnaLista[0] + isplatnaLista[1];
            isplatnaLista[3] = 3800;
            isplatnaLista[4] = brutoIznos - (isplatnaLista[2] + isplatnaLista[3]);
            isplatnaLista[5] = isplatnaLista[4] * poreznaStopa;
            isplatnaLista[6] = isplatnaLista[5] * prirezStopa;
            isplatnaLista[7] = isplatnaLista[5] + isplatnaLista[6];
            isplatnaLista[8] = isplatnaLista[3] + (isplatnaLista[4] - isplatnaLista[7]);

            return isplatnaLista;
        }
    }
}
