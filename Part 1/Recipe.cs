using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Services;
using System.Xml.Linq;

namespace ErenYeager
{
    // Recipe class to manage the ingredients and steps in the recipe
    public class Recipe
    {
        // Properties
        public int NumIngredients { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public int NumSteps { get; set; }
        public List<string> Steps { get; set; }

        // Constructors
        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }

        // Methods
        public void AddIngredient(string name, double quantity, string unit)
        {
            Ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });
        }

        public void AddStep(string description)
        {
            Steps.Add(description);
        }

        public void Clear()
        {
            NumIngredients = 0;
            Ingredients.Clear();
            NumSteps = 0;
            Steps.Clear();
        }

        public void PrintRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }

        public void ScaleRecipe(double factor)
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.Quantity /= 2;
            }
        }
    }

}






