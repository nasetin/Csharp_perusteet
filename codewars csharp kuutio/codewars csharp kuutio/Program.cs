using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars_csharp_kuutio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsCube(125, 5));



            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static bool IsCube(double volume, double side)
        {
            // Tarkistetaan, että parametrit ovat suurempia kuin nolla.
            if (volume <= 0 && side <= 0)
            {
                return false;
            }
            // Kokeillaan mikä olisi tilavuus, jos side on kuution sivu.
            // Tässä lasketaan kuution tilavuus
            double testedVolume = side * side * side; // Math.Pow(side, 3); <-- toinen vaihtoehto

            // Testataan täsmääkö parametrin volume muuttujan arvo
            // Metodissa lasketaan kuution arvoa.
            if (volume == testedVolume)
            {
                return true; // Palautetaan true ja metodi päättyy.
            }

            return false;
        }
    }
}
