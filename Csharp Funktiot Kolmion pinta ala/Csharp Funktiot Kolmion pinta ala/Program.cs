using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Funktiot_Kolmion_pinta_ala
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Kolmion pinta ala (Yhdessä päivä 9)
            // Kolmion ala lasketaan kaavasta A=ah/2 missä a on kanta ja h on korkeus.
            // Laadi ohjelma, joka saa syöttötietoina kannan ja korkeuden la laskee kolmion pinta-alan.
            // Toteuta laskeminen käyttämällä aliohjelmaa. (Funktio/Metodi)

            


            Console.Write("Syötä kolmion kanta: ");
            double baseTriangle = double.Parse(Console.ReadLine());

            Console.Write("Syötä kolmion korkeus: ");
            double heigthTriangle = double.Parse(Console.ReadLine());

            double area = triangleArea(heigthTriangle, baseTriangle);

            Console.WriteLine($"Kolmion pinta-ala: {area}");


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }

        private static double triangleArea(double heigthTriangle, double baseTriangle)
        {
            return heigthTriangle * baseTriangle / 2;
        }



    }
}
