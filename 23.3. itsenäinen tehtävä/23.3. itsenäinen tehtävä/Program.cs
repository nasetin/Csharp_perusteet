using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._3.itsenäinen_tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Pinta-ala laskuri");
			Console.Write("Syötä Leveys metreinä: ");
			string width = Console.ReadLine();
			int userwidth = int.Parse(width);


			Console.Write("Syötä korkeus metreinä: ");
			string height = Console.ReadLine();
			int userheight = int.Parse(height);

			int surfacearea = userheight * userwidth;
			Console.WriteLine("Pinta-ala= " + surfacearea + "m2");

		}
	}
}
