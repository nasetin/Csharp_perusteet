using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_funktiot_pinta_alat_ja_tilavuudet
{
    class Triangle
    {
        // Properties

        public double Heigth { get; set; }
        public double Base { get; set; }

        public Triangle(double heigth, double baseparameter)
        {
            Heigth = heigth;
            Base = baseparameter;
        }

        // Methods
        // Ei tarvitse static, koska tätä käytetään luokan objektista.
        // Esim. Triangle test = new Triangle(2, 5); - Luodaan objekti luokasta, nimeltä "test"
        // Console.WriteLine()

        public double Area()
        {
            double result = Base * Heigth / 2;

            return result;
        }

        public double Perimeter() 
        {
            
            double result = 0;

            result = Heigth + Base + Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Heigth, 2));

            return result;
        }
    }
}
