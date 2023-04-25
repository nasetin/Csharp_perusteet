using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Päivän11HarjoitusBensankulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //
            // Pyydetään arvot käyttäjältä

            List<Trip> trips = new List<Trip>();

            bool userEndsLoop = false;

            while (userEndsLoop == false)
            {
                Console.Write("Syötä matkan nimi: ");
                string name = Console.ReadLine();

                Console.Write("Syötä matka(km): ");
                double distance = double.Parse(Console.ReadLine());

                Console.Write("Syötä keskikulutus(1/100km): ");
                double averageConsumtion = double.Parse(Console.ReadLine());

                Console.Write("Syötä polttoaineenhinta(€/1): ");
                double fuelPrice = double.Parse(Console.ReadLine());

                trips.Add(new Trip(name, distance, averageConsumtion, fuelPrice));

                Console.Write("Syötetään uusi matka(y): ");
                string input = Console.ReadLine();

                if (input != "y")
                {
                    userEndsLoop = true;
                }
            }

            foreach (Trip t in trips)
            {
                // Lasku toimituksen voisi toteuttaa täällä käyttämällä objektien arvoja
                // Mutta yleensä luokan dataan liittyvät toiminnallisuudet
                // ovat osana luokkaa.
                // double test = t.AverageConsumption * t.FuelPrice * t.FuelPrice;
                Console.WriteLine($"Matkan {t.Name} hinta on: {t.CalculateCost()}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }

    }
}
