using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_tutorial_youtube_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# tutorial youtube 3/4

            // Guessing game

            //string secretWord = "giraffe";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 3;
            //bool outOfGuesses = false;

            //while (guess != secretWord && !outOfGuesses)
            //{
            //    if (guessCount < guessLimit)
            //    {
            //        Console.Write("Enter guess: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else
            //    {
            //        outOfGuesses = true;
            //    }

            //}
            //if (outOfGuesses)
            //{
            //    Console.Write("You lose!");
            //}
            //else
            //{

            //    Console.Write("You win!");
            //}


            // For Loops_________________________________________

            //int i = 1;
            //while (i <= 5)
            //{
            //Console.WriteLine(i);
            //i++;
            //}

            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            //for(int i = 0; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine(luckyNumbers[i]);

            //}


            // Buildin an exponent method______________________________

            //Console.WriteLine(GetPow(4, 3));



            // 2d Arrays_______________________________________

            //int[,] numberGrid =
            //{
            //    {1, 2},
            //    {3, 4},
            //    {5, 6},    

            //};
            //int[,] myArray = new int[2, 3];

            //Console.WriteLine(numberGrid[0, 0]);

            // Comments___________________________________________

            /*
             lol
            lol

            Console.WriteLine("Comments are fun"); 
             */

            // Exception handling____________________________________

            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}



            // Classes and objeckts___________________________________

            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord Of the rings";
            book2.author = "Tolkien";
            book2.pages = 700;

            Console.WriteLine(book2.title);


            Console.ReadKey();
        }


        // Buildin an exponent method______________________________
        //static int GetPow(int baseNum, int powNum)
        //{
        //    int result = 1;

        //    for (int i = 0; 1 < powNum; i++)
        //    {
        //        result = result * baseNum;
        //    }


        //    return result;
        //}

               


    }
}
