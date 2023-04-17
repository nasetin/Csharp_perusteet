using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Csharp_String_Lämpötilan_seuranta
{
    class Program
    {
        static void Main(string[] args)
        {
            // 37 C# String: Lämpötilan seuranta
            // Tee ohjelma, johon syötetään päivän lämpötilat. Lämpötilat mitataan kello 6, 12, 18 ja 24.
            // Kun arvot on syötetty ohjelma laskee päivän suurimman, pienimmän ja keskilämpötilan.
            // Tee sovellus samaan aikaan käyttämällä taulukkoa ja listaa.

            // 1. Luo taulukko ja lista arvoille.

            string[] measurementTimes = { "6:00", "12:00", "18:00", "24:00" };

            double[] temperaturesArray = new double[measurementTimes.Length]; // Taulukko
            List<double> temperaturesList = new List<double>(); // Lista

            // 2.Lue silmukka, jossa käyttäjän arvot luetaan ja tallennetaan taulukkoon
            // ja listaan. (Arvo luetaan vain kerran per kierros ja se tallennetaan sekä taulukkoon ja listaan)

            for (int i = 0; i < measurementTimes.Length; i++)
            {
                Console.Write($"Syötä kello {measurementTimes[i]} lämpötila: ");
                double input = double.Parse(Console.ReadLine());
                temperaturesArray[i] = input; // Taulukko
                temperaturesList.Add(input); // Lista
            }

            // 3a.Ilmoita suurin, pienin ja keskilämpötila käyttämällä valmiita metodeja.
            // 4.Tulosta suurin, pienin ja keskilämpötila käyttäjälle.
            Console.WriteLine($"Taulukon suurin lämpötila on: {temperaturesArray.Max()}");
            Console.WriteLine($"Taulukon pienin lämpötila on: {temperaturesArray.Min()}");
            Console.WriteLine($"Taulukon keskilämpötila on: {temperaturesArray.Average()}");

            Console.WriteLine($"Listan suurin lämpötila on: {temperaturesList.Max()}");
            Console.WriteLine($"Listan pienin lämpötila on: {temperaturesList.Min()}");
            Console.WriteLine($"Listan keskilämpötila on: {temperaturesList.Average()}");

            // 3b.Suorita arvojen etsiminen omalla koodilla.
            // (Kysy esim ChatGPT: How to find the smallest value in an array using for loop)

            // Algoritmi, termi koodille, joka suorittaa jonkin asian
            // Tässä algoritmi, joka laskee keskiarvon.
            int count = 0;
            double sum = 0;

            foreach (double temp in temperaturesArray)
            {
                sum += temp;
                count++;
            }

            Console.WriteLine($"Taulukon keskiarvo on: {sum/count}");

            // tässä algoritmi, joka hakee listasta suurimman arvon.

            double value = 0; // Tästä arvosta lähdetään liikkeelle ja tallennetaan suurin arvo.

            for (int i = 0; i < temperaturesList.Count; i++)
            {
                // Korvataan oletusarvo 0, ensimmäisellä kierroksella
                if (i == 0)
                {
                    value = temperaturesList[i];
                }
                // Onko uusi arvo suurempi kuin vanha arvo
                if (temperaturesList[i] > value)
                {
                    value = temperaturesList[i]; // Otetaan talteen isompi arvo
                }
            }

            Console.WriteLine($"Listan suurin arvo on: {value}");

            // Tee algoritmi, joka hakee listan pienimmäin arvon

            double value1 = 0;

            for (int i = 0; i < temperaturesList.Count; i++)
            {
                if (i == 0)
                {
                    value1 = temperaturesList[i];
                }
                if (temperaturesList[i] < value1)
                {
                    value1 = temperaturesList[i];
                }
            }
            Console.WriteLine($"Listan pienin arvo on: {value1}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
