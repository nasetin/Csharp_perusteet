using System;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Koodi tullee tänne 
            // Syntax - Syntaksi
            // Syntaksi virre = Syntax error
            // tämä on kommentti
            // Kommentit eivät suorita mitään

            // Datatypes - datatyypit
            // Numeroita
            // 35 - kokonaisluvut - integer
            // 13.5 - liukuluku - floating point
            // Merkkejä - char / Merkkijono - string
            // 't' =char  / "word" =string

            // Bool
            // true/false 1/0 
            // Literals 
            // data on tallessa muuttujissa = variable
            // <data_type> <variable name>

            // int
            int apu = 5;
            int integerValue = 10; // puolipiste rivin loppuun
            integerValue = 15;
            // double - liukuluku
            double doubleValue;
            doubleValue = 3.14;
            // char
            char characterValue = 'r';
            // string
            string stringValue = "Word";
            // bool
            bool boolValue = false;

            // kommunikointi sovelluksen kanssa
            // käyttäjänä 

            //luokaa muuttuja nimeltä message
            // ja antakaa sille arvoksi "Hello"
            /*
            string message = "Hello";
            Console.WriteLine(message);
            string input;
            input = Console.ReadLine();
            // "vastasit x, jossa x on käyttäjän syöte(input).
            Console.WriteLine("Vastasit {0}", input);
            Console.WriteLine($"Interpolating {input} voi jatkaa tekstiä");
            Console.WriteLine("vastasit " + input);
            */
            /*
            #region  3 C# Perus: Ikä-tehtävä
            // koodia tänne 
            
            Console.Write("Anna ikäsi: ");
            string userInput = Console.ReadLine();
            int age = int.Parse(userInput);
            Console.WriteLine($"Olet {age} vuotta!");

            //ilmoita käyttäjän ikä kuukausina
            // +, -, *, /, %
            /*
            int sum = 5 + 4;
            sum = 7 + age;
            sum = sum + age;
            sum += age;
            // sum = 9
            */
            int ikävuosina;
            int ikäsikuukausina;
            // kysytään ikä vuosina

            Console.WriteLine("Minkä ikäinen olet vuosina?");
            // syötetään ikä
            string vuosi = Console.ReadLine();
            // muutetaan tring tietotyyppi int tyypiksi
            ikävuosina = int.Parse(vuosi);
            //12*10
            ikäsikuukausina = 12 * ikävuosina;
            Console.WriteLine("ikäsi kuukausina on " + ikäsikuukausina);

           
            


            
           











        }
    }
}
