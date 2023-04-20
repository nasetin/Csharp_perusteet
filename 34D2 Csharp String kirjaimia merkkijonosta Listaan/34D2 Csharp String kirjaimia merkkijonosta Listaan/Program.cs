using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34D2_Csharp_String_kirjaimia_merkkijonosta_Listaan
{
    class Program
    {
        static void Main(string[] args)
        {
            // 34D2 C# String: Etsi kirjaimia merkkijonosta Listaan

            Console.Write("Syötä sana 1: ");
            string word1 = Console.ReadLine();

            Console.Write("Syötä sana 2: ");
            string word2 = Console.ReadLine();

            string charNotFound = "";
            string charTested = "";
            List<(char, int)> charsInCommon = new List<(char, int)>();

            for (int i = 0; i < word1.Length; i++)
            {
                int numberOfTimesFound = 0;
                for (int j = 0; j < word2.Length; j++)
                {

                    if (word1[i] == word2[j] && charTested.Contains(word1[i]) == false)
                    {


                        numberOfTimesFound++;
                    }
                }
                if (numberOfTimesFound != 0)
                {
                    (char, int) tuple1 = (word1[i], numberOfTimesFound);
                    charsInCommon.Add(tuple1);
                    charTested += word1[i];
                }
                else if (charTested.Contains(word1[i]) == false && charNotFound.Contains(word1[i]) == false)
                {
                    charNotFound += word1[i];
                    charNotFound += ", ";
                }

            }
            foreach ((char c, int i) pair in charsInCommon)
            {
                Console.WriteLine($"Merkki {pair.Item1} löytyi {pair.Item2} kerran/kertaa");
            }
            Console.WriteLine($"Ei löytyneet merkit: {charNotFound}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
