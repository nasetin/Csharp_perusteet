using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä4harjotukset
{
    class Program
    {
        static void Main(string[] args)
        {


            #region
            
            // 14 c# valinta: Parillinen vai pariton

            // 1. Pyydetään käyttäjää antamaan luku
            /* Console.Write("Anna luku: ");

             // 2. Luetaan luku ja tallennetaa muuttujaan
             int userNumber = int.Parse(Console.ReadLine());

             // 3. Ehto rakenne, jossa verrataan muuttujan arvoa
             // if-else
             // %-operaatio, eli jakojäännös. Jos jakojäännös == 0, luku meni tasan kahdella.
             if (userNumber % 2 == 0) // Onko jaollinen kahdella
             {
                 Console.WriteLine($"Numero {userNumber} on parillinen.");
             }
             //else if (userNumber % 2 == 1) tai
             else 
             {
                 Console.WriteLine($"Numero {userNumber} on pariton.");
             } 
            // switch
            // 1. Pyydetään käyttäjää antamaan luku
            Console.Write("Anna luku: ");

            /*
            // 2. Luetaan luku ja tallennetaa muuttujaan
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber % 2) // Suoritetaan jakojäännöksen laskeminen
            {
                case 0: // Verrataan jakojäännöksen tulosta. Jakojäännös on 0, eli parillinen
                    Console.WriteLine($"Numero {userNumber} on parillinen. ");
                    break;
                case 1: // Jakojäännös jäi 1, eli pariton
                    // default  // Voi käyttää myös defaulttia, koska luku on pariton, jos se ei ollut parillinen.
                    Console.WriteLine($"Numero {userNumber} on pariton. ");
                    break;
            }
            */
            // ternary
            // 1. Pyydetään käyttäjää antamaan luku
            Console.Write("Anna luku: ");

            // 2. Luetaan luku ja tallennetaa muuttujaan
            int userNumber = int.Parse(Console.ReadLine());
            //                      ehto           ?          arvojos true :                :          arvo jos false
            string message = (userNumber % 2 == 0) ? $"Numero {userNumber} on parillinen. " : $"Numero {userNumber} on pariton. ";
            //                                                                              Tässä kohtaa voi ketjuttaa uuden ternary operaation
            Console.WriteLine("message"); // Näytetään tulos käyttäjälle





            #endregion




        }

    }
}
