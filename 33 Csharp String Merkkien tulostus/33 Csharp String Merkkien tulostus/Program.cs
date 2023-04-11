using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Csharp_String_Merkkien_tulostus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tee ohjelma joko tulostaa sanan alusta tai lopusta halutun määrän merkkejä.
            // Käyttäjä valitse tulostetaanko merkit sanan alusta vai lopusta.
            // Pyydetään sana ja tulostun suunta yhdellä input: lla.

            // Esimerkki käyttäjän syötteestä: "Lattia A" "Seinä L"

            // Merkki " - voidaan näyttää käyttäjälle kenoviivalla \ ennen "-merkkiä. ctrl+alt+?
            Console.Write("Syötä sana ja tulostus suunta (\"Lattia A\"): ");
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            // Käyttäjä syötti "terve L"
            // inputSplit[0] == "terve"
            // inputSplit[1] == "L"

            // Tarvitaan valintarakenne, jolla tutkitaan tulostuksen suuntaa
            // Ehtorakenne kääntää string merkkien järjestyksen
            if (inputSplit[1] == "A") // Alusta
            {
                // Tätä ei periaatteessa tarvita
            }
            else if (inputSplit[1] == "L") // Lopusta
            {
                char[] chars = inputSplit[0].ToCharArray(); 
                Array.Reverse(chars);
                string test = new string(chars);
                inputSplit[0] = test;
            }

            foreach (char jokinNimi in inputSplit[0])
            {
                Console.WriteLine(jokinNimi);
            }



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
