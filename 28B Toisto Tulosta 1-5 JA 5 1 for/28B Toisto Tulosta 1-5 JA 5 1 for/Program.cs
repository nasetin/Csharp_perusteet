using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28B_Toisto_Tulosta_1_5_JA_5_1_for
{
    class Program
    {
        static void Main(string[] args)
        {
            // 28B C# Toisto: Tulosta 1 ... 5 JA 5 ... 1 (for)

            //  Console.Write("Syötä aloitus luku: ");
            //  int number1 = int.Parse(Console.ReadLine());

            //  Console.Write("Syötä lopetus luku: ");
            //  int number = int.Parse(Console.ReadLine());

            ////int number1 = 5;

            //  for (int i = 1; number <= number1; number++)
            //  {
            //      Console.WriteLine(number);

            //  }
            //  /*
            //  int number3 = 1;
            //  for (int i = 5; i >= 1; i--)
            //  {
            //      Console.WriteLine(i);
            //  } */

            Console.Write("Syötä aloitus luku: ");
            int startnumber = int.Parse(Console.ReadLine());

            Console.Write("Syötä lopetus luku: ");
            int endnumber = int.Parse(Console.ReadLine());

            for (int i = startnumber; i <= endnumber; i = i+1)
            {
                Console.WriteLine(i);
                if (startnumber > endnumber)
                {                   
                }
            }



            Console.ReadKey();
        }
    }
}
