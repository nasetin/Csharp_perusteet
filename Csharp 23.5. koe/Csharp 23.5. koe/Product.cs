using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_23._5.koe
{
    class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;

        }
        public Product()
        {

        }

        // 20 x 0.2 = 4 ja 20 - 4 = 16 <- lopullinen hinta
        public decimal CalculateDiscountedPrice(decimal discountPercentage)
        {

            decimal ale = Price * discountPercentage;
            decimal finalPrice = Price - ale;

            return finalPrice;

        }

    }
}
