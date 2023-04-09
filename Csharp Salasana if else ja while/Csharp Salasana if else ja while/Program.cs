using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Salasana_if_else_ja_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "salasana123";
            bool passwordCorrect = false;

            while (passwordCorrect == false)
            {

                Console.Write("Syötä salasan: ");
                string userinput = Console.ReadLine();

                if (userinput == password)
                {
                    Console.WriteLine("Salasana oikein!!!");
                    passwordCorrect = true;
                }
                else
                {
                    Console.WriteLine("Salasana väärin:!!!");
                }
            }
        }
    }
}
