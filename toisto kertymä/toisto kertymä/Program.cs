using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toisto_kertymä
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Toisto: Kertymä
            // Tee ohjelma, joka pyytää käyttäjältä kierrosmäärän, ohjelma laskee kierroslukujen kertymän.
            // Eli jos käyttäjä antaa syötteen 3, laskee ohjelma 0 + 1 + 2, jos 5 niin 0 + 1 + 2 + 3 + 4.
            // Lopuksi ohjelma tulostaa käyttäjälle lopputuloksen muodossa:
            // 3 kierrosta Kertymäksi saatiin: 3

            // Toteuta käyttämällä for rakennetta
            // Toteuta myös harjoitukseksi while rakenteella

            Console.Write("Syötä kierrosmäärä: ");
            int loops = int.Parse(Console.ReadLine());
            int sum = 0;

            // Summataan luvut o:sta käyttäjän lukuun asti
            for (int i = 0; i < loops; i++)
            {
                // Summataan, tarvitaan muuttuja
                sum = sum + i;
            }

            Console.WriteLine($"{loops} kierrosta kertymäksi saatiin: {sum}");

            Console.ReadKey();
        }
    }
}
