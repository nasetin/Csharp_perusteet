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
            Console.WriteLine($"{meters}m sentteinä on:{MeterConverter.ToCentimeter(meters)};");
            Console.WriteLine($"{meters}m kilometreinä on:{MeterConverter.ToKilometer(meters)}");
            Console.WriteLine($"{meters}m desimetreinä on:{MeterConverter.ToDecimeter(meters)}");
            Console.WriteLine($"{meters}m tuumina on:{MeterConverter.ToInch(meters)}");
            Console.WriteLine($"{meters}m jalkoina on:{MeterConverter.ToFoot(meters)}");
            Console.WriteLine($"{meters}m jaardeina on:{MeterConverter.ToYard(meters)}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
