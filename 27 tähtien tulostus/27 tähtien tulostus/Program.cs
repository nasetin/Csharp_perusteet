using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_tähtien_tulostus
{
    class Program
    {
        static void Main(string[] args)
        {
            // 27 C# Toisto: Tähtien tulostus (Yhdessä päivä 5)

            // Tee ohjelma joka tulostaa halutun määrän tähtiä esim. 3 tulos on ***

            // 1. Pyydetään käyttäjältä numero ja tallennetaan se muuttujaan
            Console.Write("Syötä numero: ");
            int number = int.Parse(Console.ReadLine());


            Console.Write("Syötä merkki: ");
            char symbol = char.Parse(Console.ReadLine());

            // 2. Lisätään silmukka, joka suoritetaan käyttäjän syöttämän numeron verran
            // Tulostetaan yksi tähti, toistetaan käyttäjän syöttämän numeron verran
            // while / do while
            // for
            // foreach

            // Muokataan sovellus tulostamaan käyttäjän syöttämä merkki

            // jos number = 5 ja i = 1;  1, 2, 3, 4, 5 => suoritetaan 5 kertaa
            for(int i = 1; i <= number; i++)
            {
            Console.WriteLine(symbol);
            }



            Console.ReadKey();
        }
    }
}
