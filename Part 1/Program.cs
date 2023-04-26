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
        public static string name, unit, description;
        public static double factor, quantity;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Recipe Scaler!");

            Recipe recipe = new Recipe(); // create a new recipe object
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add ingredients");
                Console.WriteLine("2. Add steps");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset recipe scale");
                Console.WriteLine("5. Clear recipe");
                Console.WriteLine("6. Display recipe");
                Console.WriteLine("7. Exit");

                // get user input and validate it
                string input;
                int choice;
                do
                {
                    Console.Write("\nEnter your choice (1-7): ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out choice) || choice < 1 || choice > 7);

                switch (choice)
                {
                    case 1:
                        recipe.AddIngredient(name, quantity, unit); // call the AddIngredients method of the recipe object
                        break;
                    case 2:
                        recipe.AddStep(description); // call the AddSteps method of the recipe object
                        break;
                    case 3:
                        recipe.ScaleRecipe(factor); // call the ScaleRecipe method of the recipe object
                        break;
                    case 4:
                        recipe.ResetRecipe(); // call the ResetScale method of the recipe object
                        break;
                    case 5:
                        recipe.ClearRecipe(); // call the ClearRecipe method of the recipe object
                        break;
                    case 6:
                        recipe.DisplayRecipe(recipe); // call the DisplayRecipe method of the recipe object
                        break;
                    case 7:
                        exit = true; // set exit flag to true to exit the loop
                        break;
                }
            }

            Console.WriteLine("Thank you for using Recipe Scaler!");
        }
    }
}
