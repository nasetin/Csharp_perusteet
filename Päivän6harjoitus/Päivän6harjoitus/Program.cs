using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Päivän6harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // c# for ja switch
           
            double initialValue = 12d;

            // Luodaan for silmukka, joka tapahtuu 4 kertaa
            // 1 - 2 - 3 - 4 
            for (int i = 1; i < 5; i++ )
            {
                switch (i) // sULKUJEN SISÄLLÄ TUTKITTAVA ARVO
                {
                    case 1:
                        // Koodi
                        initialValue += i;
                        break; // Päättää switch rakenteen suorituksen
                    case 2:
                        initialValue = initialValue * i;
                        break;
                    case 3:
                        initialValue /= i;
                        break;
                    case 4:
                        initialValue = initialValue - i;
                        break;
                }
            }

            Console.WriteLine($"Lopputulos: {initialValue}");
            


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
