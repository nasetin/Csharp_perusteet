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
            game.Start();

            Console.ReadKey();
        }
    }
}
