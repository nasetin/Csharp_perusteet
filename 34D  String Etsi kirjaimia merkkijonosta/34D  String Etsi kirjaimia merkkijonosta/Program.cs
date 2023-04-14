using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34D__String_Etsi_kirjaimia_merkkijonosta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä sana 1: ");
            string word1 = Console.ReadLine(); // "kuppi"

            Console.Write("Syötä sana 2: ");
            string word2 = Console.ReadLine(); // "kauppa"

            // Taulukon voi tietää kuinka pitkä sana on
            // 1. Ei voi tietää kuinka pitkä sana on
            // 2. ei voi tietää montako merkkiä ovat samoja

            // TODO: Luo taulukon pituus tarkalleen oikein.

            //charsInCommon sisältää merkit, jotka ilmenevät molemmissa ja montako kertaa ne ilmenee
            // Tässä datatyyppi on "Tuple" johon voi tallentaa kaksi eri datatyyppiä yhdessä
            (char charValue, int intValue)[] charsInCommon = new (char, int)[word1.Length];

            string charTested = "";

            // Luodaan silmukka, joka käy läpi kaikki word1 merkit ja tarkistetaan se word2-muuttujassa
            for (int i = 0; i < word1.Length; i++) // word1 indeksi  == i
            {
                int numberOfTimesFound = 0;
                for (int j = 0; j < word2.Length; j++) // word2 indeksi == j
                {
                    // Onko sanan i sama kirjain kuin sanan 2 indeksissä j
                    // Ja ei ole vielä tallennettu kirjainta taulukkoon
                    if (word1[i] == word2[j] && charTested.Contains(word1[i]) == false) 
                    {
                        // Estetään saman kirjaimen tallennus uudestaan

                        numberOfTimesFound++;
                        charsInCommon[i] = (word1[i], numberOfTimesFound);
                    }
                }
                // Lisätään löydetty merkki, vasta sisemmän silmukan jälkeen

                charTested += word1[i];
            }
            // Silmukka, jossa käydään läpi taulukko löydetyistä kirjaimista
            foreach( (char,int) pair in charsInCommon)
            {
                Console.WriteLine($"Merkki {pair.Item1} löytyi {pair.Item2} kerran/kertaa");
            }
            Console.ReadKey();
        } 
    }
}
