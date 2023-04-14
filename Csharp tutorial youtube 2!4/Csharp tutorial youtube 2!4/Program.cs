using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_tutorial_youtube_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays_______________________________________

            //int[] luckyNumbers = {4, 8, 15, 16, 23, 42};

            //string[] friends = new string[5];
            //friends[0] = "Jim";
            //friends[1] = "Kelly";

            //Console.WriteLine(luckyNumbers[1]);

            // Methods____________________________________________


            //SayHi("Sasu", 29);
            //SayHi("Mike", 70);
            //SayHi("Hawk", 69);

            // return statement_________________________________________
            //int cubedNumber = cube(5);
            //Console.WriteLine(cubedNumber);

            // If statement____________________________________________________
            //bool isMale = true;
            //bool isTall = true;

            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male");
            //}
            //else if (isMale && !isTall)
            //{
            //    Console.WriteLine("You are a short male");
            //}
            //else if (!isMale && isTall)
            //{
            //    Console.WriteLine("You are a not male but you are tall");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male and not tall");
            //}

            // More if statements____________________________________________

            //Console.WriteLine(GetMax(20, 10, 4));

            // Building a better calculator_________________________________________

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter operator: ");
            //string op = Console.ReadLine();

            //Console.Write("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if (op == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else if (op == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (op == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //else if (op == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator");
            //}

            // Switch statements

            //Console.WriteLine(GetDay(9));

            // While loops________________________________________________

            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } 
            while (index <= 5);

                Console.ReadKey();

        }

        // Switch statements__________________________________________________
        //static string GetDay(int dayNum)
        //{
        //    string dayName;

        //    switch (dayNum)
        //    {
        //        case 0:
        //            dayName = "Sunday";
        //            break;
        //        case 1:
        //            dayName = "Monday";
        //            break;
        //        case 2:
        //            dayName = "Tuesday";
        //            break;
        //        case 3:
        //            dayName = "Wednesday";
        //            break;
        //        case 4:
        //            dayName = "Thursday";
        //            break;
        //        case 5:
        //            dayName = "Friday";
        //            break;
        //        case 6:
        //            dayName = "Saturday";
        //            break;
        //        default:
        //            dayName = "Invalid day number";
        //                break;
        //    }


        //    return dayName;
        //}


        // More if statements____________________________________________
        //static int GetMax(int num1, int num2, int num3)
        //{
        //    int result;
        //   if (num1 >= num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    }
        //   else if (num2 >= num1 && num2 >= num3)
        //    {
        //        result = num2;
        //    }
        //   else
        //    {
        //        result = num3;
        //    }



        //    return result;
        //}


        // return statement______________________________________
        //static double cube(int num) 
        //{
        //    int result = num * num * num;
        //    return result;
       //} 
        // Methods________________________________________________
        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + " you are " + age);

        //}
    }
}
