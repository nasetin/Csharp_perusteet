using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Parillinen_Pariton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tee ohjelma joka kysyy mihin lukuun saakka tulostetaan lukuja.

            // Käyttäjältä myös kysytään, tulostetaanko parilliset vai parittomat.

            //Sovellus lopuksi tulostaa joko parittomat tai parilliset luvut, nollasta alkaen.

            Console.Write("Mihinkä lukuun saakka tulostetaan lukuja: ");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine("Tulostetaanko parilliset vai parittomat luvut ?:");
            Console.Write("Valitse 1 = parittomat tai 2 = parilliset: ");
            int number = int.Parse(Console.ReadLine());


           
            if (number % 2 == 0)
            {               
                Console.WriteLine("\n Kaikki parilliset luvut 1 to {0} : ", numb);
                EvenAndOdd(2, numb); 
            }
            else
            {
               
                Console.WriteLine("\n\n Kaikki parittomat luvut 1 to {0} : ", numb);
                EvenAndOdd(1, numb);
                Console.WriteLine("\n\n");
            }
            return;
        }

        
        private static void EvenAndOdd(int stVal, int n)
        {
            if (stVal > n)
                return;
            Console.Write(" {0}  ", stVal);
            EvenAndOdd(stVal + 2, n);






            Console.ReadKey();

        }
    }
}
