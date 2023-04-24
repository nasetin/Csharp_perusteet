using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Funktiot_Bensankulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Bensankulutus

            Console.Write("Syötä ajettu matka(km): ");
            decimal distance =  decimal.Parse(Console.ReadLine());

            Console.Write("Syötä ajoneuvon keskikulutus(1/100km): ");
            decimal averageConsumtion = decimal.Parse(Console.ReadLine());


            Console.Write("Syötä polttoaineen hinta(€/1): ");
            decimal fuelPrice = decimal.Parse(Console.ReadLine());

            decimal tripCost = carTripCostCalculator(distance, averageConsumtion, fuelPrice);

            Console.WriteLine();
            Console.WriteLine($"Ajetun matkan hinta on:  {tripCost} euroa");


            Console.WriteLine("Press any key to exit: ");
            Console.ReadKey();
        }
        // Parametrien yksiköt joko kommentoidaan tai lisätään parametrien nimiin.
        private static decimal carTripCostCalculator(decimal distanceInKilometers, decimal averageConsimption, decimal fuelcost)
        {
            decimal result = 0;

            result = distanceInKilometers * averageConsimption * fuelcost / 100;


            return result;
        }

    }
}
