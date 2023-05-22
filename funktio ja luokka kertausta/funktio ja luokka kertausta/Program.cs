using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funktio_ja_luokka_kertausta
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOPPAPELI_____________________________________
            //Dice noppa1 = new Dice(6);
            //Dice noppa2 = new Dice(6, 1);

            //noppa1.Roll();
            ////Console.ReadKey();
            //noppa2.Roll();

            //Console.WriteLine($"Nopan 1 silmäluku on: {noppa1.Value}");
            //Console.WriteLine($"Nopan 2 silmäluku on: {noppa2.Value}");
            // Tallennetaan erikseen data objektiin
            // null reference on yleinen sovelluksen kaatumiseen

            //KAUPPALISTA__________________________________________________________

            //List<ShoppingList> order = new List<ShoppingList>();

            Console.Write("Mihin kauppaan tehdään ostoslista: ");
            string shop = Console.ReadLine();

            ShoppingList newOrder = new ShoppingList(shop);

            // Suunnittelun tapa menetelmät
            // Waterfall - Mini/Agile waterfall(scrum) - Agile(pari ohjelmointi)

            bool userExitsProductsLoop = false;

            do // Käyttäjä lisää ostoksia
            {
                Console.Clear();
                Console.WriteLine($"Valittu kauppa on {newOrder.ShopName}");
                Console.WriteLine();

                // Näytetään valitut tuotteet
                // 1. Nimi Hinta
                // Ei päästä suoraan ShoppingList objektin private listaan käsiksi
                // 1. vaihto ehto on: ShoppingList.GetProducts(); <- palauttaa listan tuotteista ja
                // se käydään läpi täällä.
                // 2. vaihto ehto on : ShoppingList.PrintProducts(); <- Tulostaa tuottee  consoliin suoraan                                          
                newOrder.PrintProduct();

                Console.WriteLine();
                Console.Write("Syötä tuote ja lukumäärä(esim. maito, 3): ");
                string input = Console.ReadLine();

                if (input != "") // Tallennetaan tuote, jos käyttäjä on syöttänyt jotakin
                {
                    string[] splitInput = input.Split(',');
                    int ammount = int.Parse(splitInput[1].Trim());

                    //Lisätään tuote listaan käyttäjän syöttämän luvun verran
                    for (int i = 1; i <= ammount; i++)
                    {
                        newOrder.AddProduct(splitInput[0]);
                    }
                }
                else // Kun input on tyhjä, lopetetaan silmukka
                {
                    userExitsProductsLoop = true;
                }


            } while (userExitsProductsLoop != true);

            // Näytetään summa käyttäjälle

            Console.WriteLine();
            Console.WriteLine($"Ostoksien summa: {newOrder.Sum}");
        }
    }

    // luokan voi laittaa tänne tai tehdä uuden tiedoston solutin -> add->.....
}
