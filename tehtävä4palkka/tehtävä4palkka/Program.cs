using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä4palkka
{
    class Program
    {
        static void Main(string[] args)
        {

            string input; // Tallennetaan käyttäjän arvot
            
            // Muuttujat

            // Tuntipalkka
            double hourlySalary;

            // Tunnit, joista maksetaan 100%
            double normalHours;

            // Tunnit, joista maksetaan 150% palkka
            double plus50PercentHours;

            // Tunnit, joista maksetaan 200% palkka
            double plus100PercentHours;

            // Laskettu kuukausipalkka
            Double totalSalary;


            Console.Write("Anna tuntipalkka: ");
            input = Console.ReadLine();
            hourlySalary = double.Parse(input);

            // Käyttäjän arvon lukeminen ilman -input- muuttujan käyttämistä = sama juttu toinen tyyli
            Console.Write("Anna normaalit tunnit: ");
            normalHours = double.Parse(Console.ReadLine());

            Console.Write("Anna 50% korotetut tunnit: ");
            plus50PercentHours = double.Parse(Console.ReadLine());

            Console.Write("Anna 100% korotetut tunnit: ");
            input = Console.ReadLine();
            plus100PercentHours = double.Parse(input);

            // Laskuoperaatio
            // Laskuoperaation voi jakaa usealle riville
            // Laskukaavasta arvot 1.5 ja 2 käytetään termiä "Magic number"
            // Ratkaisu olisi tallentaa arvot sopivan nimisiin muuttujiin.
            // Erityisesti jos arvoa käytetään useaan kertaan.
            totalSalary = hourlySalary * normalHours +
                hourlySalary * 1.5 * plus50PercentHours +
                hourlySalary * 2 * plus100PercentHours;

            Console.WriteLine($"Kuukausi palkka on {totalSalary}");

            Console.ReadKey();

            



        }
    }
}
