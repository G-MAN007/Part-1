using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace RecipeApplication
{
    // Recipe class to manage the ingredients and steps in the recipe
    class Recipe
    {
        // Properties
        private string recipeName;
        private List<Ingredient> ingredientsList;
        private List<Step> stepsList;
        private double servingSize;
        private bool isScaled;

        // Constructor
        public Recipe(string nawa)
        {
            recipeName = nawa;
            ingredientsList = new List<Ingredient>();
            stepsList = new List<Step>();
            servingSize = 1;
            isScaled = false;
        }

        // Methods

        public void AddIngredient()
        {
            Console.WriteLine("Enter recipe name:");
            string nawa = Console.ReadLine();
            Console.WriteLine("Enter number of servings:");
            int servings = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter number of ingredients:");
            int numIngredients = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numIngredients; i++)
            {
                
                Console.WriteLine($"Enter ingredient {i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter quantity of {name}:");
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter unit of {name}:");
                string unit = Console.ReadLine();

                if (i >= 0 && i < ingredientsList.Count)
                {
                    ingredientsList[i] = new Ingredient(name, quantity, unit);
                }

                

            }
            
            Console.WriteLine("Enter number of steps:");
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                string description = Console.ReadLine();
                if (i >= 0 && i < stepsList.Count)
                {
                    stepsList[i] = new Step(description);
                }
            }
        }

        // Scale method scales the recipe by the given factor
        public void Scale()
        {
            double factor = 1;
            if (factor <= 0)
            {
                Console.WriteLine("Invalid scale factor. The scale factor must be greater than 0.");
            }
            else if (factor == 1)
            {
                Console.WriteLine("The recipe is already at its original scale.");
            }
            else
            {
                foreach (Ingredient ingredient in ingredientsList)
                {
                    ingredient.ScaleIngredient(factor);
                }

                servingSize *= factor;
                isScaled = true;
            }
            
        }

        // Reset method resets the recipe back to its original scale
        public void Reset()
        {
            if (isScaled)
            {
                foreach (Ingredient ingredient in ingredientsList)
                {
                    ingredient.ResetQuantity(1);
                }

                servingSize = 1;
                isScaled = false;
                Console.WriteLine("The recipe has been reset to its original scale.");
            }
            else
            {
                Console.WriteLine("The recipe is already at its original scale.");
            }
        }

        // Clear method clears the recipe data
        public void Clear()
        {
            ingredientsList.Clear();
            stepsList.Clear();
            servingSize = 1;
            isScaled = false;
            Console.WriteLine("The recipe data has been cleared.");
        }

        // DisplayRecipe method displays the recipe to the console
        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe for {recipeName} (serves {servingSize}):");
            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in ingredientsList)
            {
                Console.WriteLine($"- {ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
            }

            Console.WriteLine("Steps:");
            foreach (Step step in stepsList)
            {
                Console.WriteLine($"- {step.Description}");
            }
        }
    }
}






