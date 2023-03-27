using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opetuspv2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Harjoitus 22.3.

            int age = 31; // integer - kokonaisluku
            age = 32; // Muokataan muuttujan arvo
            // " = shift+F2
            // { = ctrl+alt+7 
            // } = ctrl+alt+0
            // $ = ctrl+alt+4
            Console.WriteLine($"{age} on käyttäjän ikä");

            double height = 1.78; // double - liukuluku(desimaalit)
       

            height = 1.8;
            Console.WriteLine($"{height} on käyttäjän pituus");

            String name = "Sasu";
            name = "nase";
            Console.WriteLine($"{name} käyttäjän nimi.");

            bool loggedin = true; // boolean - totuusarvomuuttuja
            loggedin = false;
            Console.WriteLine($"Käyttäjä on kirjautunut: {loggedin}");

            // ' = Ä oikealla puolella
            char replaceWhit = 't';
            replaceWhit = 'T';
            Console.WriteLine($"Korvataan kirjaimella {replaceWhit}");

            // Harjoitus 23.3.
            string userInput; // tallennetaan käyttäjän syöttämä arvo

            Console.WriteLine();
            Console.WriteLine("Harjoitus 23.3. ");
            Console.Write("Anna pituus metreinä: ");
            userInput = Console.ReadLine(); // Käyttäjän syöttämä luku tallennetaan
            double length = double.Parse(userInput); // Muokataan string arvo double dataksi

            Console.Write("Anna leveys metreinä ");
            userInput = Console.ReadLine();
            double width = double.Parse(userInput);

            double area = length * width;
            Console.WriteLine($"Alueen pinta-ala: {area}");






            // koodin lopussa
            Console.ReadKey();





        }
    }
}
