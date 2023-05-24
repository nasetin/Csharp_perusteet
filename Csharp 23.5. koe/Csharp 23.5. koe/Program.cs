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
            List<JavelinThrow> newThrow = new List<JavelinThrow>();

            Console.Write("Syötä heittäjän nimi: ");
            string athleteName = Console.ReadLine();
            Console.Write("Syötä heittäjän metrit: ");
            int meters = int.Parse(Console.ReadLine());
            Console.Write("Syötä heittäjän sentit: ");
            int centimeters = int.Parse(Console.ReadLine());

            newThrow.Add(new JavelinThrow(1, athleteName, meters, centimeters));

            List<Product> products = new List<Product>();

            Console.Write("Syötä tuotteen nimi: ");
            string name = Console.ReadLine();

            



            Console.ReadKey();
        } // main!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
 
        private static string lastNameCut(string lastName)
        {
            string result1 = lastName.Substring(0, 5);
            return result1;
        }
        private static string firstNameCut(string firstname)
        {
            string result2 = firstname.Substring(0, 3);
            return result2;
        }


    }
}
