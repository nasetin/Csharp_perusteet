﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_kaikkien_aiheiden_kertaus
{
    class HirsiPuu
    {
        private string[] randomWords = { "matti", "teppo", "seppo", };
        private int attempts = 5;
        private string randomWord;
        private string hiddenWord;

        public void Start()
        {

            Random random = new Random();
            int randomIndex = random.Next(0, randomWords.Length);
            randomWord = randomWords[randomIndex];

            // Näytetään pelaajalle montako kirjainta sanassa
            hiddenWord = new string('_', randomWord.Length);

            // Montako kertaa pelaaja saa saa arvata väärin


            while (attempts > 0)
            {

                Console.WriteLine("Arvaa suomen rakastetuimman veljes trion veljen nimi: " + hiddenWord);
                Console.WriteLine($"Arvauksia jäljellä {attempts}");
                Console.Write("Syötä kirjain arvaus: ");
                char userGuess = Console.ReadKey().KeyChar;
                Console.WriteLine();

                bool letterFound = false;
                for (int i = 0; i < randomWord.Length; i++)
                {
                    if (randomWord[i] == userGuess)
                    {
                        // ilmeisesti päivittää random sanaa jos käyttäjä arvaa oikean kirjaimen
                        hiddenWord = hiddenWord.Remove(i, 1).Insert(i, userGuess.ToString());
                        letterFound = true;
                    }
                }

                if (letterFound)
                {
                    Console.WriteLine();
                    Console.WriteLine("Oikein arvattu!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Väärin arvattu.");
                    attempts--;
                }

                if (hiddenWord == randomWord)
                {
                    Console.WriteLine("Arvasit veljen oikein! Voitit pelin!");
                    Console.WriteLine("Arvotonta kissankultaa minä sain!!!");
                    Console.WriteLine("Sen tiedän nyt mä vain!!");
                    Console.WriteLine("Petollista kissankultaa kiiltävää!!!!!!");                    
                    Console.WriteLine();
                    break;
                }
            }

            string gameOver = (attempts == 0) ? "Hävisit pelin. Oikea veljes oli: " + randomWord : "";
            Console.WriteLine(gameOver);
            Console.WriteLine();
        }
    }

}