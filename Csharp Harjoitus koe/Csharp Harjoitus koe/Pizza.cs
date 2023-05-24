using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Harjoitus_koe
{
    class Pizza
    {
        public decimal BasePrice { get; } = 15.0m;

        public decimal CalculatePrice(List<Topping> toppings)
        {
            return BasePrice + (toppings.Count * 1.0m);
        }


    }
}
