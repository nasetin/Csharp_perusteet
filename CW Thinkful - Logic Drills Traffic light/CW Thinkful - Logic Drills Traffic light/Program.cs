using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Thinkful___Logic_Drills_Traffic_light
{
    class Program
    {
        static void Main(string[] args)
        {



        }
        public static string UpdateLight(string current)
        {
            string result = "";
            //Do Some Magic
            switch (current)
            {
                case "green":
                    result = "yellow";
                    break;

                case "yellow":
                    result = "red";
                    break;
                case "red":
                    result = "green";
                    break;
            }
            return result;
        }
    }
}
