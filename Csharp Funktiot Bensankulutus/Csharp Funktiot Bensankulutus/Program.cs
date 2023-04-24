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
            bool userEndsLoop = false;

            // List<(decimal, decimal, decimal)> test = new List<(decimal, decimal, decimal)>(); // Tuple
            List<decimal> userDistance = new List<decimal>();
            List<decimal> userAverageConsumption = new List<decimal>();
            List<decimal> userFuelPrice = new List<decimal>();
            // Kun käytetään useaa eri listaa tai taulua, täytyy hallita indeksien käyttö oikein eri listojen välillä

            decimal[] test = new decimal[1];
            (decimal, decimal, decimal)[] trips = new (decimal, decimal, decimal)[1];

            while (userEndsLoop == false)
            {

                Console.Write("Syötä ajettu matka(km): ");
                decimal distance = decimal.Parse(Console.ReadLine());
                userDistance.Add(distance);

                Console.Write("Syötä ajoneuvon keskikulutus(1/100km): ");
                decimal averageConsumtion = decimal.Parse(Console.ReadLine());
                userAverageConsumption.Add(averageConsumtion);


                Console.Write("Syötä polttoaineen hinta(€/1): ");
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                userFuelPrice.Add(fuelPrice);

                trips[trips.Length - 1] = (distance, averageConsumtion, fuelPrice);
                    

                // decimal tripCost = carTripCostCalculator(distance, averageConsumtion, fuelPrice);

                // Console.WriteLine();
                // Console.WriteLine($"Ajetun matkan hinta on:  {tripCost} euroa");
                // Console.WriteLine();

                Console.Write("Calculate another trip? (y/n): ");
                string input = Console.ReadLine();

                if (input == "n") // Käyttäjä lopettaa sovelluksen
                {
                    userEndsLoop = true; // Kun tämä muuttuja on true, silmukka päättyy
                }
                else
                {
                    trips = expandArray(trips); // expandArray palauttaa uuden taulukon, joka on yhtä suurempi kuin alkuperäinen
                }
            }

            // Käydään listat läpi ja tulostetaan matkojen hinnat
            for (int i = 0; i < userDistance.Count; i++)
            {
                Console.WriteLine($"Matkan {i+1} hinta on: {carTripCostCalculator(userDistance[i], userAverageConsumption[i], userFuelPrice[i])}");
            }
            Console.ReadKey();
        }
        // Parametrien yksiköt joko kommentoidaan tai lisätään parametrien nimiin.
        private static decimal carTripCostCalculator(decimal distanceInKilometers, decimal averageConsimption, decimal fuelcost)
        {
            decimal result = 0;

            result = distanceInKilometers * averageConsimption * fuelcost / 100;


            return result;
        }
        private static (decimal, decimal, decimal)[] expandArray((decimal, decimal, decimal)[] originalArray)
        {
            // Luodaan uusi taulukko, joka on yhtä suurempi kuin alkuperäinen taulukko
            (decimal, decimal, decimal)[] newArray = new (decimal, decimal, decimal)[originalArray.Length + 1];

            // Kopioidaan arvot vanhasta taulukosta uuteen taulukkoon
            for (int i = 0; i < originalArray.Length; i++)
            {
                newArray[i] = originalArray[i];
            }

            return newArray;
        }

    }
}
