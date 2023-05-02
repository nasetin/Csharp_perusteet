using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshaep_Funktiot_MeterConverter
{
    class MeterConverter
    {
        // Properties

        // Construcyor

        // Methods

        public static double ToCentimeter(double meters)
        {
            return meters * 100;
        }

        public static double ToKilometer(double meters)
        {
            return meters / 1000;
        }

        public static double ToDecimeter(double meters)
        {
            return meters * 10;
        }

        public static double ToInch(double meters)
        {
            return meters * 39.370;
        }

        public static double ToFoot(double meters)
        {
            return meters * 3.2808;
        }

        public static double ToYard(double meters)
        {
            return meters * 1.0936;
        }

    }
}
