﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication
{
    internal class Ingredient
    {
            public string Name { get; set; }
            public double Quantity { get; set; }
            public string Unit { get; set; }
        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name}";
        }
    }
}
