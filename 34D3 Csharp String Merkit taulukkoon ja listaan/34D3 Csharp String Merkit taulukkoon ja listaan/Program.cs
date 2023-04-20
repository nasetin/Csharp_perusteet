using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34D3_Csharp_String_Merkit_taulukkoon_ja_listaan
{
    class Program
    {
        static void Main(string[] args)
        {
            // 34D3 C# String: Merkit taulukkoon ja listaan


            Console.Write("Syötä sana: ");
            string word = Console.ReadLine();


            char[] charArray = new char[word.Length];
            List<char> wordList = new List<char>();

            for (int i = 0; i < word.Length; i++)
            {
                charArray[i] = word[i];
                wordList.Add(word[i]);
            }

            foreach (char c in charArray)
            {
                if (c % 2 != 0)
                {
                    char upper = Char.ToUpper(c);
                    Console.Write(upper);
                }
                else
                {
                    Console.Write(c);
                }
            }

            Console.WriteLine();

            foreach (char c in wordList)
            {
                if (c % 2 == 0)
                {
                    char upper = Char.ToUpper(c);
                    Console.Write(upper);
                }
                else
                {
                    Console.Write(c);
                }
            }

            Console.WriteLine(" Press any key to exit...");
            Console.ReadKey();
        }
    }
}
