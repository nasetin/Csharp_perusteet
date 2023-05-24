using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_kokkeeseen_harjottelu
{
    class Program
    {
        static void Main(string[] args)
        {
            int catId = 1;
            List<Kissa> kissaLista = new List<Kissa>();
            Kissa kissa;

            while (catId <= 3)
            {
                kissa = new Kissa(); // luodaan tyhjä kissa. kissa on oli

                Console.Write("Syötä kissen nimi: "); // Otetaan propertit ylös käyttäjältä
                kissa.Name = Console.ReadLine(); // HOX Kissa.cs
                // string catName = Console.ReadLine(); <- toinen vaihto ehto
                // kissa.Name = catName; <- toinen vaihtoehto

                Console.Write("Syötä kissen ikä: "); // Otetaan propertit ylös käyttäjältä
                kissa.Age = int.Parse(Console.ReadLine()); // HOX Kissa.cs

                Console.Write("Syötä kissen paino: "); // Otetaan propertit ylös käyttäjältä
                kissa.Weight = double.Parse(Console.ReadLine()); // HOX Kissa.cs

                kissa.Id = catId; // Lisätään juokseva id HOX rivit 13 ja 36!!!!!

                kissaLista.Add(kissa); // kissaListaan lisätään kissa HOX rivi 19!!!

                kissa.Tulosta(); // HOX!!!!!!!!!!!!!!!!!!!

                catId++; // id numero kasvaa
            }

            foreach (var item in kissaLista)
            {
                Console.WriteLine(item);
            }

            kissa = new Kissa(10, "einari", 20, 30);

            Console.WriteLine(kissa.LaskeYhteen()); // kutsutaan Kissa.cs metodista LaskeYhteen
            kissa.Tulosta(); // kutsutaan Kissa.cs metodista Tulosta

            // Kissa k1 = new Kissa(catId, catName, catAge, catFat); // luodaan uusi kissaolio
            // Kissa k2 = new Kissa(catName, catAge);

            // Kissa k3 = new Kissa();
            // k3.Weight = catFat;



            Console.ReadKey();
        }

    }
}
