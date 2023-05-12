using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_kaikkien_aiheiden_kertaus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hangman Game

            //This app generates a random word and prompts the user to guess the letters.
            //The user has a limited number of guesses.
            //Step - by - step instructions:
            //Create a new console application in Visual Studio.
            //Generate a random word.
            //Display underscores for each letter of the word.
            //Prompt the user to guess a letter.
            //Check if the letter is in the word and replace the corresponding
            //underscore with the letter.
            //Repeat steps 4 and 5 until the user guesses the word or runs out of guesses.


            string[] randomWords = {"matti", "teppo", "seppo",};

            Random random = new Random();
            int randomIndex = random.Next(0, randomWords.Length);
            string randomWord = randomWords[randomIndex];
            string hiddenWord = new string('_', randomWord.Length);

            Console.WriteLine("Satunnainen sana: " + hiddenWord);
            try
            {

            Console.WriteLine("Arvaa kirjain");
            string guessedLetter = Console.ReadLine();
            }
            catch(FormatException e)
            {
                Console.WriteLine();
            }




            Console.ReadKey();
        }
    }
}
