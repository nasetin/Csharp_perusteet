using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_funktiot_pinta_alat_ja_tilavuudet
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Pinta-alat ja tilavuudet (Yhdessä päivä 10)

            Square squareOne = new Square(5, 10);
            Console.WriteLine($"Area on square one is: {squareOne.Area()}");
            Console.WriteLine($"Circumference of square one is: {squareOne.CircumFerence()}");

            Square squareTwo = new Square(1, 2);

            Console.ReadKey();

        }
    } // Program päättyy

    public class Square
    {
        // Properties
        public double Width { get; set; }
        public double Heighth { get; set; }

        // Constructors

        public Square(double width, double heighth)
        {
            Width = width;
            Heighth = heighth;
        }

        // Methods

        public double Area() // Huomioikaa, ei tarvitse parametrejä. Voi tosin olla parametrejä tarvittaessa.
        {
            return Width * Heighth; // Arvot löytyvät suoraan objektista.
        }

        public double CircumFerence()
        {
            return (Width * 2) + (Heighth * 2);
        }
    }
}
