using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_korttipeli_harjoitus
{
    class Card
    {
        public enum Suites // Voi tallentaa vakio arvoja
        {
            Hearts,     // 0
            Diamonds,   // 1
            Clubs,      // 2
            Spades      // 3
        } 

        // Properties
        public int Value { get; set; } // 1-13
        public Suites Suite { get; set; } // "Hertta", "pata", "risti", "ruutu"

        // Constructors

        public Card(int value, Suites suite)
        {
            Value = value;
            Suite = suite;
        }


        // Methods


    }
}
