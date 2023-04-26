using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RecipeApplication
{
    // main program class to interact with the user
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Recipe Scaler!");

            bool isRunning = true;
            Recipe currentRecipe = null;

            while (isRunning)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Create a new recipe");
                Console.WriteLine("2. Scale the current recipe");
                Console.WriteLine("3. Reset the current recipe to its original values");
                Console.WriteLine("4. Display the current recipe");
                Console.WriteLine("5. Clear the current recipe and start over");
                Console.WriteLine("6. Exit the program");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("\nCreating a new recipe");
                        currentRecipe = new Recipe();
                        currentRecipe.AddIngredient();
                        currentRecipe.AddStep();
                        break;
                    case "2":
                        Console.WriteLine("\nScaling the recipe");
                        if (currentRecipe != null)
                        {
                            currentRecipe.Scale();
                        }
                        else
                        {
                            Console.WriteLine("No recipe created yet!");
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nResetting the recipe to its original values");
                        if (currentRecipe != null)
                        {
                            currentRecipe.Reset();
                        }
                        else
                        {
                            Console.WriteLine("No recipe created yet!");
                        }
                        break;
                    case "4":
                        Console.WriteLine("\nDisplaying the recipe");
                        if (currentRecipe != null)
                        {
                            currentRecipe.DisplayRecipe();
                        }
                        else
                        {
                            Console.WriteLine("No recipe created yet!");
                        }
                        break;
                    case "5":
                        Console.WriteLine("\nClearing the current recipe and starting over");
                        currentRecipe = null;
                        break;
                    case "6":
                        Console.WriteLine("\nExiting the program");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid input, please try again");
                        break;
                }
            }
        }
    }
}
