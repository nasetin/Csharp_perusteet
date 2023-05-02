using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshaep_Funktiot_MeterConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä mitta(m): ");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine($"{meters}m sentteinä on:{MeterConverter.ToCentimeter(1.826)};");
            Console.WriteLine($"{meters}m kilometreinä on:{MeterConverter.ToKilometer(meters)}");


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
