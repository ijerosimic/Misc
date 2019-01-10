using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite iznos računa");
            var racun = Console.ReadLine();

            Console.WriteLine("Unesite iznos danog novca");
            var novac = Console.ReadLine();

            var podijeliRacun = racun.Split('.');
            var podijeliNovac = novac.Split('.');

            decimal racunKune;
            decimal racunLipe;

            decimal novacKune;
            decimal novacLipe;

            if (podijeliRacun.Length > 1)
            {
                racunKune = decimal.Parse(podijeliRacun[0]);
                racunLipe = decimal.Parse(podijeliRacun[1]);
            }
            else
            {
                racunKune = decimal.Parse(podijeliRacun[0]);
                racunLipe = 0;
            }


            if (podijeliNovac.Length > 1)
            {
                novacKune = decimal.Parse(podijeliNovac[0]);
                novacLipe = decimal.Parse(podijeliNovac[1]);
            }
            else
            {
                novacKune = decimal.Parse(podijeliNovac[0]);
                novacLipe = 0;
            }

            decimal kuneZaIzvratiti = 0;
            decimal lipeZaIzvratiti = 0;

            if (racunKune > novacKune)
            {
                Console.WriteLine("Iznos danog novca je manji od iznosa računa!");
            }


            else if (novacKune > racunKune && novacLipe > racunLipe)
            {
                kuneZaIzvratiti = novacKune - racunKune;
                lipeZaIzvratiti = novacLipe - racunLipe;
            }

            else if (novacKune > racunKune && novacLipe < racunLipe)
            {
                kuneZaIzvratiti = novacKune - racunKune;
                lipeZaIzvratiti = racunLipe - novacLipe;
            }

            Console.WriteLine("Ukupno za izvratiti: {0} kuna, {1} lipa.", kuneZaIzvratiti, lipeZaIzvratiti);
        }
    }
}
