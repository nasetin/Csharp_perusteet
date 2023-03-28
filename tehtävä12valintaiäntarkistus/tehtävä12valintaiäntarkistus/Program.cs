using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä12valintaiäntarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma joka kysyy käyttäjältä
            //ikää ja tarkistaa, että se on
            //järkevä (vähintään 0 ja korkeintaan 120).

            bool ageCorrect = false;

            while (!ageCorrect)
            {

                Console.Write("Syötä ikä: ");
                int age = int.Parse(Console.ReadLine());
                int minAge = 0;
                int maxAge = 120;

                // Tarkistetaan, että ikä on sopiva
                if (age >= minAge && age <= maxAge)
                {
                    ageCorrect = true;
                    Console.WriteLine("Tallennus onnistui");
                }
                else
                {
                    Console.WriteLine("Arvo ei ole " +
                        "hyväksyttävällä välillä" +
                        $" ({minAge}-{maxAge})");

                }

            }

            Console.ReadKey();


        }
    }
} 
