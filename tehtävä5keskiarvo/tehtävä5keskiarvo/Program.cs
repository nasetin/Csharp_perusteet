using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä5keskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Muuttujat

            double luku1;

            double luku2;

            double luku3;

            double keskiArvo;

            Console.Write("Anna ensimmäinen luku: ");
            luku1 = double.Parse(Console.ReadLine());

            Console.Write("Anna toinen luku: ");
            luku2 = double.Parse(Console.ReadLine());

            Console.Write("Anna kolmas luku: ");
            luku3 = double.Parse(Console.ReadLine());

            // sitte pitäs laskee...

            // sulut laskutoimitukseen. ekana lasketaan plussat ja sitten vasta jaetaan
            keskiArvo = (luku1 + luku2 + luku3) / 3;
            Console.WriteLine($"Antamiesi lukujen keskiarvo on: {keskiArvo}");

            Console.ReadKey();




        }
    }
}
