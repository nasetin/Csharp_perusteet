using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Luvunarvaus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tallenna ohjelmaan luku ja pyydä käyttäjää arvaamaan se luku.
            // Jos käyttäjä arvasi oikein, tulosta teksti arvasit oikein.
            // Jos käyttäjä ei arvannut oikein, kerro oliko arvaus liian suuri vai pieni

            int target = 11;
            bool correctGuess = false;

            while (correctGuess == false)
            {


                Console.Write("Arvaa luku(0-20): ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == target) // Oikea arvaus
                {
                    correctGuess = true;
                    Console.WriteLine("Oikea arvaus");
                }

                else if (guess < target) // Liian pieni
                {
                    Console.WriteLine("Liian pieni");
                }
                else // Liian suuri
                {
                    Console.WriteLine("Liian suuri");
                }

            }




            Console.ReadKey();
        }
    }
}
