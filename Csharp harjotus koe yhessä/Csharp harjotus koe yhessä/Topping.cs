﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_harjotus_koe_yhessä
{
    class Topping
    {
        // Property - eli data, jota objektissa on tallessa
        public string Name { get; set; }
        // Voisi olla muuta dataa

        // Constructor - Suoritettava koodi, kun luodaan luokasta objekti
        public Topping(string name)
        {
            Name = name;
        }

    }
}
