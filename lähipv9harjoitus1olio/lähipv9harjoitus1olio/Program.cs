﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lähipv9harjoitus1olio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lisää tähän tiedostoon uusi metodi, joka ottaa vastaan parametrinä taulukon
            // int lukuja ja palauttaa taulukon keskiarvon.

            int[] someValues = new int[4];
            someValues[0] = 5;
            someValues[1] = 8;
            someValues[2] = 6;
            someValues[3] = 100;

            Console.WriteLine(average(someValues));



            Console.ReadKey();
        }
        private static double average(int[] numbers)
        {
            // Algoritmi, joka laskee keskiarvon
            int count = 0;
            double sum = 0;

            foreach (double temp in numbers)
            {
                sum += temp;
                count++;
            }

            return sum / count;


            
        }

       
    }
}
