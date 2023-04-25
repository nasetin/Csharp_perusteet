using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Funktiot_Lämpötilan_muunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Lämpötilan muunnin
            // C = (5/9) * (F-32)
            // F = C * 9 / 5 + 32

            
            bool userIsDone = false;
            while (userIsDone == false)
            {
                // DOTO:
                // kaatuu jos syöttää kirjaimia
            Console.Write("Syötä Lämpötila: ");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Muuta antamasi lämpötila Fahrenheit asteiksi valitsemalla f.");
            Console.WriteLine("Muuta antamasi lämpötila celcius asteiksi valitsemalla: c.");
            string choice = Console.ReadLine();

            if (choice == "f") // fahrenheit!!!!!!!!!!
            {

                Console.WriteLine($"Lämpötila on {celsiusToFahrenheit(temperature)} F");
                    userIsDone = true;
            }

            else if (choice == "c") // celsius!!!!!!
            {
                Console.WriteLine($"Lämpötila on {fahrenheitToCelsius(temperature)} C");
                    userIsDone = true;
            }

            else
            {
                Console.WriteLine("Väärä syöte kokeile uudestaan");
                Console.WriteLine("f = Fahrenheit");
                Console.WriteLine("c = Celsius");

                Console.WriteLine();
            }

            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }

        private static double fahrenheitToCelsius(double temperature)
        {

            double celsius = (5 / 9d) * (temperature - 32);
            return celsius;
        }

        private static double celsiusToFahrenheit(double temperature)
        {
            double fahrenheit = temperature * 9 / 5 + 32;

            return fahrenheit;
        }
    }
}
