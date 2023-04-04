using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toisto.Lukujen_summa_ja_keskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            //31B C# Toisto: Lukujen summa ja keskiarvo (Yhdessä päivä 5)

            //Kirjoita ohjelma, joka kysyy käyttäjältä laskettavien lukujen määrän. Ohjelma pyytää lukuja annetun luvun verran.
            //Lopussa sovellus näyttää lukujen summan ja keskiarvon.


            Console.Write("Syötä laskettavien lukujen määrä: ");
            int number = int.Parse(Console.ReadLine());
            int i = 0;
            double avg;
            int sum = 0; // Luodaan summa muuttuja silmukan ulkopuolella, muuten muuttuja aina resetoituu.


            for (i = 1; i <= number; i++)
            {
                Console.Write($"Syötä luku {i}: ");
                // voi tehdä myös sum = sum + int.Parse(Console.ReadLine());
                int input = int.Parse(Console.ReadLine());
                sum += input;

            }
            avg = sum / number;
            Console.Write($"Lukujen summa on {sum} ja lukujen keskiarvo on {avg}!");





            Console.ReadKey();
        }
    }
}
