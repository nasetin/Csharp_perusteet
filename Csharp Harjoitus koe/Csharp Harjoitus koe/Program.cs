using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Harjoitus_koe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Topping> valitutTäytteet = new List<Topping>();
            Pizza pizza = new Pizza();

            Console.WriteLine("Pitsan tilaus:");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Valitut täytteet: ");
                foreach (Topping topping in valitutTäytteet)
                {
                    Console.WriteLine(topping.Name);
                }

            Console.WriteLine("Vaihtoehdot");
            Console.WriteLine("1.Pepperoni");
            Console.WriteLine("2.Herkkusieni");
            Console.WriteLine("3.Oliivi");
            Console.WriteLine("4.Jauheliha");
            Console.WriteLine("5.Tonnikala");
            Console.WriteLine("Valitse numeroilla haluamasi täytteet tai paina e lopettaaksesi ohjelma");

                string input = Console.ReadLine();

                if (input == "e")
                {
                    break;
                }

                if (int.TryParse(input, out int toppingNumber) && toppingNumber >= 1 && toppingNumber <= 5)
                {
                    Topping topping = GetToppingByNumber(toppingNumber);
                    if (topping != null)
                    {
                        valitutTäytteet.Add(topping);
                    }
                }

                Console.Clear();
            }




            Console.ReadKey();
        }
    }
}
