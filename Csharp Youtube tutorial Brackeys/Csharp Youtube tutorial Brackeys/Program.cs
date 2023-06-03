using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Youtube_tutorial_Brackeys
{
    class Program
    {
        static void Main(string[] args)
        {
            // EPISODE 01!!!

            //// Change the apperance

            //Console.Title = "skynet";
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WindowHeight = 40;

            //// Get a conversation going

            //Console.WriteLine("Hello, what's your name?");

            //Console.ReadLine(); // This works too

            //Console.WriteLine("My name is RX-9000.\nI'm an AI from the future to destroy mankind.");
            //Console.WriteLine("What is your favorite color?");

            //Console.ReadLine();

            //Console.WriteLine("Cool! Mine is destruction.");
            //_____________________________________________________________________

            // Episode 02!!!

            //Console.WriteLine("What is your name?");

            //string userName = Console.ReadLine();

            //Console.WriteLine("Hello" + userName + ", nice to meet you!");

            //double num01;
            //double num02;

            //Console.Write("Input a number: ");

            //num01 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Input a second number: ");

            //num02 = Convert.ToDouble(Console.ReadLine());

            //double result = num01 * num02;
            //Console.WriteLine("The result is " + result);
            //_____________________________________________________________________

            // Episode 03!!!

            //Console.WriteLine("Welcome! Tickets are 5€. Please insert cash.");

            //int cash = Convert.ToInt32(Console.ReadLine());

            //if (cash < 5)
            //{
            //    Console.WriteLine("That's not enough money.");
            //}
            //else if(cash == 5)
            //{
            //    Console.WriteLine("Here is your ticket!");
            //}
            //else
            //{
            //    int change = cash - 5;
            //    Console.WriteLine("Here is your ticket and " + change + "euros in change.");
            //}


            //int age;
            //int height;

            //Console.Write("Please input age: ");
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please input height (CM): ");
            //height = Convert.ToInt32(Console.ReadLine());

            //if (age >= 18 || height >= 160)
            //{                
            //    Console.WriteLine("You can enter!");
            //}
            //else
            //{
            //    Console.WriteLine("You dont meet the requirements!");
            //}

            //Console.Write("Input a number between 1 and 5: ");

            //int num = Convert.ToInt32(Console.ReadLine());

            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("One");
            //        break;
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    case 3:
            //        Console.WriteLine("Three");
            //        break;
            //    case 4:
            //        Console.WriteLine("Four");
            //        break;
            //    case 5:
            //        Console.WriteLine("Five");
            //        break;
            //    default:
            //        Console.WriteLine("Default");
            //        break;
            //}
            //__________________________________________________________________

            //  EPISODE04!!!
            //Console.Write("How many cool numbers you want: ");

            //int count = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < count; i++)
            //{
            //    double result = Math.Pow(2, i);
            //    Console.WriteLine(result);
            //}

            //Random numberGen = new Random();

            //int roll = 0;
            //int attempts = 0;

            //Console.WriteLine("Press enter to roll the die!");

            //while (roll != 6)
            //{
            //    Console.ReadKey();
            //    roll = numberGen.Next(1, 7);
            //    Console.WriteLine("You rolled" + roll);
            //    attempts++;
            //}

            //Console.WriteLine("It took you " + attempts + "attempts to roll a six!");
            //______________________________________________________________________

            // Episode 05

            //string[] movies = {"Lord of the Rings", "Fight Club", "Interstellar", "Gladiator" };

            //for (int i = 0; 1 < movies.Length; i++)
            //{
            //    int rank = i + 1;
            //    Console.WriteLine(rank + ". " + movies[i]);
            //}

            //string[] movies = new string[4];

            //Console.WriteLine("Type in 4 movies: ");

            //for (int i = 0; i < movies.Length; i++)
            //{
            //    movies[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Here they are alphabetical: ");

            //Array.Sort(movies);

            //for (int i = 0; i < movies.Length; i++)
            //{
            //    Console.WriteLine(movies[i]);
            //}

            //List<string> shoppingList = new List<string>();

            //shoppingList.Add("Dreams");
            //shoppingList.Add("Miracles");
            //shoppingList.Add("Rainbows");
            //shoppingList.Add("Pony");

            //for (int i = 0; i < shoppingList.Count; i++)
            //{
            //    Console.WriteLine(shoppingList[i]);
            //}

            //shoppingList.Remove("Dreams");
            //shoppingList.RemoveAt(1);

            //Console.WriteLine("---------");

            //for (int i = 0; i < shoppingList.Count; i++)
            //{
            //    Console.WriteLine(shoppingList[i]);
            //}
            //______________________________________________________________

            // EPISODE 06

            //MeetAlien();

            //Console.WriteLine("-----------");

            //MeetAlien();

            //Multiply(3, 8);
            //Multiply(7, 13);
            //Multiply(11, 5);

            //int result = Multiply(3, 8);

            //Console.WriteLine("The result is " + result);
            //if (result % 2 == 0)
            //{
            //    Console.WriteLine("Result is even number!");
            //}
            //else
            //{
            //    Console.WriteLine("Result is odd number!");
            //}
            //_____________________________________________________________________

            // EPISODE 07

            Wizard wizard01 = new Wizard("Parry Potter", "unexpecto Patronum");

            wizard01.CastSpell();

            Wizard wizard02 = new Wizard("nase nasukka", "Vittu mitä paskaa");

            wizard02.CastSpell();

            Console.WriteLine(Wizard.Count);

            Console.ReadKey();

        }

        static void MeetAlien()
        {
            Random numberGen = new Random();

            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi, I'm " + name);
            Console.WriteLine("I'm " + age + " years old.");
            Console.WriteLine("Oh, and i'm an alien.");
        }

        static int Multiply(int num01, int num02)
        {
            int result = num01 * num02;
            return result;
        }
    }
    class Wizard
    {
        public string name;
        public string favoriteSpell;
        private int spellSlots;
        private float experience;

        public static int Count;

        public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            experience = 0;

            Count++;
        }

        public void CastSpell()
        {
            if (spellSlots > 0)
            {

            Console.WriteLine(name + " casts " + favoriteSpell);
            spellSlots--;
                experience += 0.3f;
            }
            else
            {
                Console.WriteLine(name + " is out of spell slots!");
            }
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots");
            spellSlots = 2;
        }
    }
}
