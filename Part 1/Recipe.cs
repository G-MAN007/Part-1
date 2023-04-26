using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RecipeApplication
{
    // Recipe class to manage the ingredients and steps in the recipe
    internal class Recipe
    {
        // Properties
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; private set; }
        public List<Step> Steps { get; private set; }

        // Constructor
        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }

        // Add an ingredient to the recipe
        public void AddIngredient(string name, double quantity, string unit)
        {
            Ingredients.Add(new Ingredient(name, quantity, unit));
        }

        // Add a step to the recipe
        public void AddStep(string description)
        {
            Steps.Add(new Step(description));
        }

        // Scale the recipe by a given factor
        public void ScaleRecipe(double factor)
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        // Reset the recipe to its original quantities before scaling
        public void ResetRecipe()
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.ResetQuantity();
            }
        }

        // Clear all the ingredients and steps from the recipe
        public void ClearRecipe()
        {
            Ingredients.Clear();
            Steps.Clear();
        }
        public void DisplayRecipe(Recipe recipe)
        {
            Console.WriteLine($"Recipe Name: {recipe.Name}\n");

            Console.WriteLine("Ingredients:");
            for (int i = 0; i < recipe.Ingredients.Count; i++)
            {
                Ingredient ingredient = recipe.Ingredients[i];
                Console.WriteLine($"{i + 1}. {ingredient.Name} - {ingredient.Quantity} {ingredient.Unit}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < recipe.Steps.Count; i++)
            {
                Step step = recipe.Steps[i];
                Console.WriteLine($"{i + 1}. {step.Description}");
            }
        }
    }
}
    




    
