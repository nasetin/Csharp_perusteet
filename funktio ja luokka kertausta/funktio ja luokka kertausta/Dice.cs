using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funktio_ja_luokka_kertausta
{
    class Dice
    {
        // Properties = mitä dataa nopassa on

        private static Random rng; // Jos luodaan static, tämä jaetaan kaikkien
                            // noppa objektien kesken.
                            // Jolloin ei saada enää samoja arvoja.

        public int MaxValue { get; set; } // Nopassa on lukuja 1 - tämä arvo

        public int Value { get; set; } // Nopan arvo, joka on ylöspäin

        // Jokin property, jolla voi tehdä "huijaus" nopan


        // Constructors

        public Dice(int maxValue)
        {
            rng = new Random();
            MaxValue = maxValue;
            Roll();
        }

        public Dice(int maxValue, int value) // Kahden parametrin overload
        {
            rng = new Random();
            MaxValue = maxValue;
            Value = value;
        }

        // Methods

        // Noppaa "heitetään" ja arvotaan siihen uusi satunnainen arvo
        public void Roll()
        {
            Value = rng.Next(1, MaxValue +1);
        }

    }
}
