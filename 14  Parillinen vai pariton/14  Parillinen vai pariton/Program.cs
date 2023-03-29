using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14__Parillinen_vai_pariton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tee ohjelma, joka ilmoittaa onko käyttäjän antama luku parillinen vai pariton
            // Tässä tarvitsette % -operaattoria ja hieman selvittää,
            // kuinka parillisuus saadaan selvillä ohjelmoinnissa.

            // Testaillaan looppia
            while (true)
            {
                // Pyydetään käyttäjältä luku ja
                // tallennetaan se muuttujaan inPut
                Console.Write("Syötä luku: ");
                int number = int.Parse(Console.ReadLine());
                

                // Jos käyttäjän luvun voi jakaa numerolla 2 se on parillinen!
                if (number % 2 == 0)
                {
                    Console.WriteLine("Luku on parillinen!");
                }
                else
                {
                    // Jos ei voi jakaa numerolla 2 se on pariton!
                    Console.WriteLine("Luku on pariton!");
                }
            }

                         
        }
    }
}
