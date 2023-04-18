using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Funktiot_Verolaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Verolaskuri (Yhdessä päivä 9)


            Console.Write("Syötä bruttopalkka: ");
            decimal grosssalary = decimal.Parse(Console.ReadLine());
            Console.Write("Syötä veroprosentti: ");
            decimal taxPercentage = decimal.Parse(Console.ReadLine());

            (decimal, decimal) netAndTax = netSalary(grosssalary, taxPercentage);

            Console.WriteLine($"Nettopalkka on: {netAndTax.Item1} \r\nMaksettu vero on: {netAndTax.Item2}");


            Console.ReadKey();

        }
        // Nyt metodi palauttaa tuple datarakenteen, joka on pari decimal arvoja
        private static (decimal, decimal) netSalary(decimal grossSalary, decimal taxPercentage)
        {

            (decimal, decimal) result = (0,0);

            // Tässä välissä lasketaan lopputulos
            result.Item1 = (grossSalary / 100) * (100 - taxPercentage);
            result.Item2 = grossSalary - (grossSalary / 100) * (100 - taxPercentage);
            return result;
        }

    }
}
