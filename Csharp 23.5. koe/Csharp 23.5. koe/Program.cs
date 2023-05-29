using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_23._5.koe
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Syötä puhelin numero: ");
            //string input = Console.ReadLine();
            //int length = 13;

            //// Syntaksia kyselin chatgpt ja googlee
            //if (input.StartsWith("+358") && input.Length == length)
            //{
            //    Console.WriteLine("Numero hyväksytty!!!");

            //}
            //else
            //{
            //    Console.WriteLine("Väärä syötä");
            //}

            //Console.WriteLine();

            //Console.WriteLine("Syötä etunimi");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Syötä sukunimi");
            //string lastName = Console.ReadLine();

            //Console.WriteLine($"{lastNameCut(lastName)}{firstNameCut(firstName)}");

            //string account = AccountName(firstName, lastName);


            // Sukunimestä 5 kirjainta
            // Etunimestä 3 ensimmäistä
            // string result = str.Substring(0,5);!!!!!!!!

            //__________________________________________________________

            //List<JavelinThrow> newThrow = new List<JavelinThrow>();

            //Console.Write("Syötä heittäjän nimi: ");
            //string athleteName = Console.ReadLine();
            //Console.Write("Syötä heittäjän metrit: ");
            //int meters = int.Parse(Console.ReadLine());
            //Console.Write("Syötä heittäjän sentit: ");
            //int centimeters = int.Parse(Console.ReadLine());

            //newThrow.Add(new JavelinThrow(1, athleteName, meters, centimeters));

            //List<Product> products = new List<Product>();

            //Console.Write("Syötä tuotteen nimi: ");
            //string name = Console.ReadLine();

            //___________________________________________________________________

            List<Product> productLista = new List<Product>();
            Product newProduct;
            int productId = 1;
            decimal discountedPercentage = 0.2m;

            while (productId <= 3)
            {
                newProduct = new Product();
                Console.Write("Syötä tuotteen nimi: ");
                newProduct.Name = Console.ReadLine();

                Console.Write("Syötä tuotteen hinta: ");
                newProduct.Price = decimal.Parse(Console.ReadLine());

                newProduct.Id = productId;

                productLista.Add(newProduct);

                decimal aleHinta = newProduct.CalculateDiscountedPrice(discountedPercentage);

                productId++;
                Console.WriteLine($"Tuote: {newProduct.Id}");
                Console.WriteLine($"Tuotteen nimi on: {newProduct.Name}");
                Console.WriteLine($"Hinta 20% alennuksen jälkeen on: {aleHinta}");
                Console.WriteLine();
            }
            Console.ReadKey();
        } // main!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!



        //private static string lastNameCut(string lastName, string firstname)
        //{
        //    string result1 = lastName.Substring(0, 5);
        //    string result2 = firstname.Substring(0, 3);
        //    return result1+result2;
        //}
        //private static string firstNameCut(string firstname)
        //{
        //    return result2;
        //}
    }
}
