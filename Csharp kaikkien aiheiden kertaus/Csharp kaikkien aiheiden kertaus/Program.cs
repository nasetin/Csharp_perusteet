using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_kaikkien_aiheiden_kertaus
{
    class Program
    {
        static void Main(string[] args)
        {
            HirsiPuu game = new HirsiPuu();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("HIRSIPUU PELI!");
                Console.WriteLine("1. Aloita uusi peli");
                Console.WriteLine("2. EXIT");
                Console.Write("Syötä valintasi: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        game.Start();
                        break;
                    case "2":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Väärä syöte. Kokeile uudestaan!");
                        Console.WriteLine();
                        break;
                }
            }
         
        }
    }
}
