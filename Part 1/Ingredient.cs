using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication
{
    // Ingredient class to represent an ingredient in the recipe
    internal class Ingredient
    {
        // Properties
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        private double originalQuantity;

        // Constructor
        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            originalQuantity = quantity;
        }

        // Reset the ingredient quantity to its original quantity
        public void ResetQuantity()
        {
            Quantity = originalQuantity;
        }
    }
}
