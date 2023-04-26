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
    public class Recipe
    {
        // Properties
        private string recipeName;
        private List<Ingredient> ingredientsList;
        private List<Step> stepsList;
        private double servingSize;
        private bool isScaled;

        // Constructor
        public Recipe(string name)
        {
            recipeName = name;
            ingredientsList = new List<Ingredient>();
            stepsList = new List<Step>();
            servingSize = 1;
            isScaled = false;
        }

        // Methods

        // AddIngredient method adds a new ingredient to the recipe
        public void AddIngredient(string name, double quantity, string unit)
        {
            Ingredient newIngredient = new Ingredient(name, quantity, unit);
            ingredientsList.Add(newIngredient);
        }

        // AddStep method adds a new step to the recipe
        public void AddStep(string stepText)
        {
            Step newStep = new Step(stepText);
            stepsList.Add(newStep);
        }

        // Scale method scales the recipe by the given factor
        public void Scale(double factor)
        {
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
                    ingredient.Scale(factor);
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
                    ingredient.Reset();
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
            Console.WriteLine("\nRecipe: " + recipeName);
            Console.WriteLine("Serving size: " + servingSize + "\n");

            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in ingredientsList)
            {
                Console.WriteLine("- " + ingredient.ToString());
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < stepsList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + stepsList[i].ToString());
            }

            Console.WriteLine();
        }
    }
}
    




    
