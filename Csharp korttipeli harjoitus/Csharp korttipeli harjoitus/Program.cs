using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_korttipeli_harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lisätään koodi, joka generoi pakkaan kortit
            // Lisätään pakalle metodi, jolla nostetaan yksi kortti pakasta.
            // Pakan sekoitus metodi

            // Tässä on pelin kaikki kortit
            Deck deck = new Deck();

            // Tässä on pelaajan 1 käsi
            Deck player1Deck = new Deck();

            // Tässä on pelaajan 2 käsi
            Deck player2Deck = new Deck();

            deck.GenerateCards();
            deck.Shuffle();
            // Pelaaja 1 nostaa kortin
            player1Deck.Cards.Add(deck.Draw());
            // Pelaaja 2 nostaa kortin
            player2Deck.Cards.Add(deck.Draw());

            if (player1Deck.Cards[0].Value > player2Deck.Cards[0].Value)
            {
                Console.WriteLine("Pelaaja yksi voitti!");
            }
            else if (player1Deck.Cards[0].Value < player2Deck.Cards[0].Value)
            {
                Console.WriteLine("Pelaaja kaksi voitti!");
            }
            else // Jos sama arvo, verrataan maat
            {
                if (player1Deck.Cards[0].Suite < player2Deck.Cards[0].Suite)
                {
                    Console.WriteLine("Pelaaja yksi voitti!");
                }
                else
                {
                    Console.WriteLine("Pelaaja kaksi voitti!");
                }
            }

            

            // Lisää sovellukseen toinen pelaaja
            // Nosta molemmille pelaajille kortit
            // Ilmoita kumpi voitti
            // Isompi arvo voittaa
            // Assä == 1
            // Tasapelissä seuraavasti
            // Hearts > Diamond > Clubs > Spades


            Console.ReadKey();
        }
    }
}
