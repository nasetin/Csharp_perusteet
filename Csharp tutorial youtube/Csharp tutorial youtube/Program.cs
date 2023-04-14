using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_tutorial_youtube
{
    class Program
    {
        static void Main(string[] args)
        {
            // Drawing a Shape - Piirretään kuvia
            /*
            Console.WriteLine("Hello World!");

            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
            Console.WriteLine();
            */

            // Variables - Muuttujat
            /*
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There ince was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            Console.WriteLine();
            */

            // Data Types
            /*
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.2;
            bool isMale = true;

            Console.WriteLine(false);
            Console.WriteLine();
            */

            // Working with strings
            // \n \"

            //string phrase = "Giraffe Academy";
            ////               0123
            //Console.WriteLine(phrase.Substring(phrase.IndexOf("Academy")));



            // Working with numbers


            //Console.WriteLine((4 + 2 ) * 3);
            //Console.WriteLine(Math.Abs(-40));
            //Console.WriteLine(Math.Pow(3, 2));
            //Console.WriteLine(Math.Sqrt(36));
            //Console.WriteLine(Math.Max(4, 90));
            //Console.WriteLine(Math.Min(90, 80));
            //Console.WriteLine(Math.Round(4.8));


            // Getting user input

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //string age = Console.ReadLine();
            //Console.WriteLine("Hello " + name + " you are " + age + " old");

            // Building a calculator

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);

            // Building a mad libs game

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);


            Console.ReadKey();


        }
    }
}
