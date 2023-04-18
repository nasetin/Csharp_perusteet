using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshar_Funktiot_Kalorit_jouleiksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Kalorit jouleiksi
            // Kirjoita ohjelma, joka muuttaa kalorit jouleiksi ja päinvastoin.
            // Joulet voidaan muuntaa kaloreiksi kertomalla ne luvulla 0,2390 ja kalorit jouleiksi kertomalla ne luvulla 4,184.
            // Tee kummallekin muunnokselle oma aliohjelma. (2 eri metodia)


            Console.Write("Syötä kalorit: ");
            decimal calories = decimal.Parse(Console.ReadLine());

            Console.Write("Syötä joulet: ");
            decimal joules = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"k => j == {caloriesToJoules(calories)}");
            Console.WriteLine($"j => k == {joulesToCalories(joules)}");




            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        private static decimal caloriesToJoules(decimal calories)
        {
            return calories * 4.184m;
        }
        private static decimal joulesToCalories(decimal joules)
        {
            return joules * 0.2390m;
        }

    }
}
