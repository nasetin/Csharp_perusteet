﻿using System;
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
            Dice noppa1 = new Dice(6);
            Dice noppa2 = new Dice(6, 1);

            noppa1.Roll();
            //Console.ReadKey();
            noppa2.Roll();

            Console.WriteLine($"Nopan 1 silmäluku on: {noppa1.Value}");
            Console.WriteLine($"Nopan 2 silmäluku on: {noppa2.Value}");
            // Tallennetaan erikseen data objektiin
            // null reference on yleinen sovelluksen kaatumiseen

            Console.ReadKey();
        }
    }

    // luokan voi laittaa tänne tai tehdä uuden tiedoston solutin -> add->.....
}
