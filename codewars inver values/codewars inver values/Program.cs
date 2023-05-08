using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars_inver_values
{
    class Program
    {
        static void Main(string[] args)
        {
         


        }
        public static int[] InvertValues(int[] input)
        {
            //Code it!
            // Käänteinen arvo: arvo = arvo * -1;

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] * -1;
            }
            return input;
        }
    }
}
