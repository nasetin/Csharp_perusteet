using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars_csharp_poista_eka_ja_vika_merkki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Remove_char("testaus"));
            Console.ReadKey();
        }

        public static string Remove_char(string s)
        {
            // "testi" -> est
            // "testaus" -> estau

            string result = "";

            // silmukka jättää välistä merkkijonon ensimmäisen ja viimeisen indeksin
            // koska i alkaa indeksistä 1 ja päättyy Length - 1.
            for (int i = 1; i < s.Length -1; i++)
            {
                result += s[i]; // Lisätään merkki uuteen string muuttujaan.
            }

            // Your Code
            return result;
        }

    }
}
