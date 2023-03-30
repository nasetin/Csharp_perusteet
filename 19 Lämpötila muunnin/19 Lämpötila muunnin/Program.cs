using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Lämpötila_muunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tee ohjelma, joka kysyy käyttäjältä lämpötilan
            // Fahrenheit-asteet ja muuntaa sen Celsius-asteiksi ja
            // tulostaa näyttöön. Celcius -> Fahrenheit muunnoskaava on
            // C = (5 / 9) * (F - 32)
            // jossa C on Celsius-asteet ja F on Fahrenheit-asteet.
            // Muokkaa ohjelma siten, että ensin kysytään lämpötila
            // ja seuraavaksi kysytään mihin muotoon lämpötila muunnetaan.
            // Lisäksi Fahrenheit -> Celcius muunnoskaava:
            // F = C * 9 / 5 + 32


            /*              F -> C
            Console.Write("Syötä lämpötila Fahrenheit asteina: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (5 / 9d) * (fahrenheit - 32);

            Console.WriteLine("Antamasi lämpötila celcius asteina: " + celsius);
            */



            /*              C -> F
             Console.Write("Syötä lämpötila Celcius asteina: ");
             double celcius = double.Parse(Console.ReadLine());

             double fahrenheit = celcius * 9 / 5 + 32;

             Console.WriteLine("Antamasi lämpötila fahrenheit asteina: " + fahrenheit);
            */


            while (true)
            {

                // Luetaan käyttäjän antama lämpötila ja tallennetaan se double muodossa "input"iin
                Console.Write("Syötä lämpötila: ");
                double input = double.Parse(Console.ReadLine());

                // Numeroilla 1 tai 2 valitaan kumpaanko muontoon lämpötila muutetaan
                Console.WriteLine("Muuta antamasi lämpötila Fahrenheit asteiksi valitsemalla numero 1.");
                Console.WriteLine("Muuta antamasi lämpötila celcius asteiksi valitsemalla numero 2.");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    double fahrenheit = input * 9 / 5 + 32;
                    Console.WriteLine("on " + fahrenheit + " Fahrenheitia!");
                    Console.WriteLine();

                }

                else if (choice == "2")
                {
                    double celcius = (5 / 9d) * (input - 32);
                    Console.WriteLine("on " + celcius + " Celsiusta!");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("Väärä syöte kokeile uudestaan");
                    Console.WriteLine("Numero 1 = Fahrenheit");
                    Console.WriteLine("Numero 2 = Celsius");
                    Console.WriteLine();
                }

            }
        }
    }
}
