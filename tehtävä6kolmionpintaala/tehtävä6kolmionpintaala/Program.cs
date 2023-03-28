using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä6kolmionpintaala
{
    class Program
    {
        static void Main(string[] args)
        {
            // Muuttujat

            double kanta;

            double korkeus;

            double pintaAla;

            Console.Write("Syötä kolmion kanta: ");
            kanta = double.Parse(Console.ReadLine());

            Console.Write("Syötä kolmion korkeus: ");
            korkeus = double.Parse(Console.ReadLine());

            // laskuoperaatio

            pintaAla = kanta * korkeus / 2d;
            Console.WriteLine($"Kolmion pinta-ala on: {pintaAla}");

            // Pysäytetään sovellus
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}
