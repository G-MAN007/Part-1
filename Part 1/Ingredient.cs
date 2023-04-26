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

        // Constructor
        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

        // Method to display ingredient in a user-friendly format
        public string DisplayIngredient()
        {
            return $"{Name}: {Quantity} {Unit}";
        }

        // Method to scale ingredient quantity based on the specified factor
        public void ScaleIngredient(double scaleFactor)
        {
            Quantity *= scaleFactor;
        }

        // Method to reset the ingredient quantity to its original value
        public void ResetQuantity(double originalQuantity)
        {
            Quantity = originalQuantity;
        }
    }
}
