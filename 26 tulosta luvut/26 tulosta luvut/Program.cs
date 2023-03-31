using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_tulosta_luvut
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Valitse kokonais luku: ");            
                int userInput = int.Parse(Console.ReadLine());
                int a = 1;
 
            while (a <= userInput)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.ReadKey();
        }
    }
}
