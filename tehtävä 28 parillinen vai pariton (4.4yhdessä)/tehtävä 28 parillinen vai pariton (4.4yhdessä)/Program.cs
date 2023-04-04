using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä_28_parillinen_vai_pariton__4._4yhdessä_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tee ohjelma joka kysyy mihin lukuun saakka tulostetaan lukuja.
            // 20 => 1, 2, 3, 4, 5, 6, ....20
            //Käyttäjältä myös kysytään, tulostetaanko parilliset vai parittomat.
            // "Pariton"           "Parillinen"
            //Sovellus lopuksi tulostaa joko parittomat tai parilliset luvut, nollasta alkaen.

            // Aloitetaan tekemällä sovellus, joka tulostaa lukuja 1 - käyttäjän syöttämä luku

            // 1. Pyydetään käyttäjältä luku
            // 2. luetaan ja tallennetaan luku muuttujaan
            //int number = int.Parse(Console.ReadLine());

            // 3. Luodaan silmukka, joka suoritetaan niin monta kertaa kuin 1 - käyttäjä luku on
            //            -while, pitää miettiä jokin sopiva ehto
            //            -jotta voidaan tulostaa numeroita 1 alkaen, tarvitaan muuttuja, joka on alussa 1

            //int i = 1; // iterointi: i++ => i++ => i == 3 jne

            // Kysytään käyttäjältä halutaanko parillinen vai pariton
            // Console.Write("Parillinen / Pariton: ");
            // string input = Console.ReadLine();


           /* while (i <= number)
            {
                // Lisätään ehto, joka tulostaa vain parittoman numeron
                if (i % 2 != 0 && input == "Pariton")
                {
                    Console.WriteLine(i);
                }
                else if (i % 2 == 0 && input == "Parillinen")
                {
                    Console.WriteLine(i);
                }
                i++; // suoritetaan iteraatio jokaisella silmukan kierroksella
            }

            // 4. Silmukassa tulostetaan numero 1, jonka muuttuja iteroidaan joka kierros.
           */

            const string EVEN_TEXT = "Parillinen";
            const string ODD_TEXT = "Pariton";

            Console.Write("Syötä luku, johon asti tulostetaan: ");
            int number = int.Parse(Console.ReadLine());

            // while tarkistaa, että käyttäjä syöttää hyväksyttävän arvon
            string input = ""; // Muuttuja luodaan ennen silmukkaa, jotta sitä voi käyttää ehdossa
            bool inputFalse = true;

            while (inputFalse == true) // silmukka toistetaan, niin kauan kuin käyttäjän input on väärin
            {

                Console.Write($"{EVEN_TEXT} / {ODD_TEXT} ");
                input = Console.ReadLine();

                if (input == EVEN_TEXT)
                {
                    inputFalse = false; // kun tämä muuttuja on false, pysähtyy silmukka
                }
                else if (input == ODD_TEXT)
                {
                    inputFalse = false; // kun tämä muuttuja on false, pysähtyy silmukka
                }
            }


            // Käyttäjän syöte tarkistetaan aiemmin
            int startingPoint = input == EVEN_TEXT ? 2 : 1;
            // Parillinen alkaa 2
            // Pariton alkaa 1

            for (int i = startingPoint; i <= number; i += 2)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();

        }
    }
}
