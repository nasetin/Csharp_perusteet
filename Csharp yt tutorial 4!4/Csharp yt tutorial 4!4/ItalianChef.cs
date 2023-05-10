using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_yt_tutorial_4_4
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
    }
}
