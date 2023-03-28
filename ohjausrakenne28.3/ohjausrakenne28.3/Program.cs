using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohjausrakenne28._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uusi aihe: Ohjausrakenne - Control structure
            // 1. if - rakenne

            // if (ehto - condition) // lopputulos true / false
            // { <- start of code block
            // if condition == true
            // Suoritetaan if blokin koodi
            // } <- end of if code block
            // Jos kondition - false
            // Hypätään koodi blokin yli

            Console.WriteLine("Ennen if");
            if (5 > 10) // false
            {
                Console.WriteLine("sisällä if");

            }
            Console.WriteLine("Jälkeen if");
            Console.WriteLine();

            // 2. if -else
            // Joko suoritetaan if code block
            // Tai suoritetaan else code block

            Console.WriteLine("before if");
            if ("moi" == "terve")
            {
                Console.WriteLine("inside if");
            }
            else
            {
                Console.WriteLine("inside else");
            }
            Console.WriteLine("after if-else");

            Console.WriteLine();

            // 3. if - else if - else
            // Rakenteessa voi olla myös muita vertailuja
            // ainoastaan yksi code block suoritetaan
            
            if (6.5 >= 5.5 )
            {
                Console.WriteLine("inside if");
            }
            else if (10 <= 10)
            {
                Console.WriteLine("inside else-if");
            }
            else
            {
                Console.WriteLine("inside else");
            }

            // Vertailuoperaattorit - Comparison operators
            // Vertailujen lopputulos on totuusarvo - boolean
            // true/ false

            // == samat arvo
            // != eri arvot
            // < vasen pienempi kuin oikea
            // > vasen isompi kuin oikea
            // <= vasen pienempi tai yhtä suuri kuin oikea
            // >= vasen isompi tai yhtä suuri kuin oikea

            // Loogiset operaattorit - logical operators
            // Voidaan yhdistää useampi vertailuoperaatio

            // && molemmat totta -and-
            // age >= ageLimit && length == targetHeigth

            // || ctrl+alt+< toinen totta -or-
            // age >= ageLimit || length == targetHeigth

            // ! kääntää totuusarvon
            // bool accountDeleted = true;
            // if (!accountDeleted)
            //{
            // Jos ei ole poistettu, voidaan käyttää
            //}

            // if sulkujen sisällä pitää olla true
            // jos vertaillaan arvoa, jonka halutaam olla false
            // ! ennen muuttujaa

            // 4. Silmukat - Loops

            // while(condition)
            // {
            //      Execute done
            //      As long as condition == true
            // }

            // ensin maalataan koodi mikä halutaan muuttaa kommentiksi
            // kommentointi ctrl + k sitten ctrl + c
            //poista ctrl + k sitten ctrl + u
            //while (true)
            //{
            //    Console.Write("moi");
            //}

            string input = "";
            while (input != "exit")
            {
                Console.Write("Choose action: ");
                input = Console.ReadLine();
                Console.WriteLine($"Executing action {input}");
            }


            
            Console.ReadKey();



        }

    }
}
