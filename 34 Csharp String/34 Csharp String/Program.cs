using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Csharp_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string[] splitInput = new string[1];
            bool inputHasErrors = true;

            while (inputHasErrors == true)
            {

            Console.Write("Syötä sana ja poistettavien merkkien määrä(\"Omena\" 1): ");
            input = Console.ReadLine();

            splitInput = input.Split(' ');
                // tällä taulukolla on indeksit 0 ja 1

                // Muokataan "inputHasErrors"-totuusmuuttujan arvo false, jos käyttäjän syöte on OK.
                // Tällöin silmukka päättyy.
                // TODO: error checking and place ReadLine inside a loop until passes error checking
                // [ luku > 0 ] JA [ luku * 2 < sana.Length ]

                // splitInput[0] == käyttäjän syöttämä sana
                // splitInput[1] == käyttäjän syöttämä numero
                // 0 == vähintään poistettavien merkkien määrä
                // 2 == lasketaan yhteensä poistettavien merkkien määrä
                //      alusta ja lopusta == kertaa 2
                if (int.Parse(splitInput[1]) > 0 && int.Parse(splitInput[1]) * 2 < splitInput[0].Length)
                {
                    inputHasErrors = false;
                }
            }
            //// Tällä taulukolla on indeksit 0 ja 1

            ///[ luku > 0 ] JA [ luku * 2 ei saa > sana.Length ]

            //// Vaihtoehto 1
            //// Otetaan käyttäjän sanasta Substring
            //// Substring vaatii aloitus indeksin ja montako merkkiä otetaan talteen aloituskohdasta lähtien.

            ////               0123456 <- testaus string arvon indeksit
            //// Esimerkiksi: "testaus" 2
            //// Tarvittavat arvot Substring-metodiin alla:
            //// Nämä indeksit on itse sen string merkkijonon indeksejä.
            //// Aloitusindeksi: 2
            //// Tallennettavien merkkien määrä: 3 => sanan pituus - alunpoisto - lopun poisto = merkkien määrä
            ////                                      splitInput[0].Length - poistettavat merkit * 2 = merkkien määrä

            //// UUSI TERMI: parametri, on metodin sulkujen sisälle syötetyt arvot.
            ////              overload, metodi voi ottaa vastaan eri määrän parametrejä. Overload ilmaisee montako vaihtoehtoa on.
            ////              Hiiri metodin päällä: ctrl+K sitten ctrl+P, voi käydä läpi kaikki ero overload vaihtoehdot.
            //string result1 = splitInput[0].Substring(int.Parse(splitInput[1]), splitInput[0].Length - (int.Parse(splitInput[1]) * 2));
            //Console.WriteLine(result1);

            // Vaihtoehto 1


            // Vaihtoehto 2
            // Tehdään silmukka, jossa tallennetaan merkkejä yksi kerrallaan
            // "testaus 2" Aloitetaan silmukka kolmannesta indeksistä ja jatketaan viimeiseen kopioitavaa indeksiin.
            // => "sta"

            //string result2 = ""; // Tähän lisätään merkkejä yksi kerrallaan
            //// StringBuilder => jos suorituskyky ongelmia

            //// Silmukka alkaa ensimmäisen tallennettavan merkin indeksistä ja loppuun viimeiseen tallennettavaan indeksiin.
            //for (int i = int.Parse(splitInput[1]); i < splitInput[0].Length - int.Parse(splitInput[1]); i++)
            //{
            //    result2 += splitInput[0][i]; // kopioidaan merkki käyttäjän sanan tietystä indeksistä.
            //    // splitInput[0] viittaa käyttäjän sanaan eli => "testaus"[i]
            //}
            //Console.WriteLine(result2);


            // Vaihtoehto 2

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
