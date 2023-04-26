using ErenYeager;
using System;

namespace ErenYeager
{
    // main program class to interact with the user
    public class Program
    {
        public static int action;
        public static void Main(string[] args)
        {
            Program cli = new Program();
            cli.Run();
        }
        // Properties
        public Recipe Recipe { get; set; }

        // Constructor
        public Program()
        {
            Recipe = new Recipe();
        }


        // Methods
        public void Run()
        {

            Console.WriteLine("Welcome to the Recipe Manager!");

            // Prompt the user for the number of ingredients they want to add
            Console.Write("How many ingredients do you want to add? ");
            int numIngredients = int.Parse(Console.ReadLine());

            // Prompt the user for the name, quantity, and unit of measurement for each ingredient
            for (int i = 1; i <= numIngredients; i++)
            {
                AddIngredient();
            }

            // Prompt the user for the number of steps they want to add
            Console.Write("How many steps do you want to add? ");
            int numSteps = int.Parse(Console.ReadLine());

            // Prompt the user for the description for each step
            for (int i = 1; i <= numSteps; i++)
            {
                AddStep();
            }

            // Prompt the user for the action they want to perform

            while (action <= 7)
            {
                Console.Write("\nWhat would you like to do?\n" +
                    "1. Add ingredient\n" +
                    "2. Add step\n" +
                    "3. Print recipe\n" +
                    "4. Scale recipe\n" +
                    "5. Reset quantities\n" +
                    "6. Clear recipe\n" +
                    "7. Exit): ");
                action = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        AddIngredient();
                        break;

                    case 2:
                        AddStep();
                        break;

                    case 3:
                        PrintRecipe();
                        break;

                    case 4:
                        ScaleRecipe();
                        break;

                    case 5:
                        ResetQuantities();
                        break;

                    case 6:
                        ClearRecipe();
                        break;

                    case 7:
                        Console.WriteLine("\nGoodbye!");
                        break;

                    default:
                        Console.WriteLine("\nInvalid input. Please try again.");
                        break;
                }
            }
        }

        public void AddIngredient()
        {
            Console.Write("\nEnter the ingredient name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the quantity: ");
            double quantity = double.Parse(Console.ReadLine());

            Console.Write("Enter the unit of measurement: ");
            string unit = Console.ReadLine();

            Recipe.AddIngredient(name, quantity, unit);
        }

        public void AddStep()
        {
            Console.Write("\nEnter the step description: ");
            string description = Console.ReadLine();

            Recipe.AddStep(description);
        }

        public void PrintRecipe()
        {
            Recipe.PrintRecipe();
        }

        public void ScaleRecipe()
        {
            Console.Write("\nEnter the scaling factor (0.5, 2, or 3): ");
            double factor = double.Parse(Console.ReadLine());

            Recipe.ScaleRecipe(factor);
        }

        public void ResetQuantities()
        {
            Recipe.ResetQuantities();
            Console.WriteLine("\nQuantities have been reset to their original values.");
        }

        public void ClearRecipe()
        {
            Recipe.Clear();
            Console.WriteLine("\nRecipe has been cleared.");
        }
    }
}

