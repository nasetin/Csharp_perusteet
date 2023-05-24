using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_harjotus_koe_yhessä
{
    class Pizza
    {

        public List<Topping> Toppings { get; set; }

        public int basePrice { get; set; }

        // Constructor
        public Pizza()
        {
            Toppings = new List<Topping>(); // Tyhjä lista
            basePrice = 15; // Voisi hakea tietokannasta
        }

        // Methods
        public int CalculatePrice()
        {
            int result = 0;

            if (Toppings.Count > 3)
            {
                result += Toppings.Count - 3;
            }
            return basePrice + result;
        }

    }
}
