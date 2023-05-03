﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_korttipeli_harjoitus
{
    class Deck
    {
        // Properties

        // Lista kortti objekteja
        public List<Card> Cards = new List<Card>();

        // Constructors


        // Method

        // Generoidaan Deck-luokan Cards-listaan yksi kappale jokaista korttia.

        public void GenerateCards()
        {
            // Arvojen lukumäärä korttipakassa
            const int numberOfValues = 13;

            // käydään läpi korttien arvot 1-13
            for (int i = 1; i <= numberOfValues; i++)
            {
                // Käydään läpi maat
                foreach (Card.Suites suite in Enum.GetValues(typeof(Card.Suites)))
                {
                    // Lisätään uusi kortti objekti tämän objektin kortit listaan.
                    Cards.Add(new Card(i, suite));
                }
            }
        }

        // Nostetaan alin kortti
        public Card Draw()
        {
            Card tempCard = Cards[0]; // Kaatuu, jos lista on tyhjä
            Cards.RemoveAt(0);

            return tempCard;
        }

        // Sekoitetaan pakan kortit
        public void Shuffle()
        {
            Random random = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n+ 1);
                Card temp = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = temp;
            }
        }

    }
}
