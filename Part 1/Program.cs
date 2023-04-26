using System;

namespace ErenYeager
{
    // main program class to interact with the user
    public class Program
    {
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
            bool running = true;

            while (running)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add ingredient");
                Console.WriteLine("2. Add step");
                Console.WriteLine("3. Print recipe");
                Console.WriteLine("4. Scale recipe");
                Console.WriteLine("5. Reset quantities");
                Console.WriteLine("6. Clear recipe");
                Console.WriteLine("7. Quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddIngredient();
                        break;
                    case "2":
                        AddStep();
                        break;
                    case "3":
                        PrintRecipe();
                        break;
                    case "4":
                        ScaleRecipe();
                        break;
                    case "5":
                        ResetQuantities();
                        break;
                    case "6":
                        ClearRecipe();
                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }

        private void AddIngredient()
        {
            Console.WriteLine("Enter ingredient name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter quantity:");
            double quantity;
            while (!double.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine("Enter unit of measurement:");
            string unit = Console.ReadLine();

            Recipe.AddIngredient(name, quantity, unit);
        }

        private void AddStep()
        {
            Console.WriteLine("Enter step description:");
            string description = Console.ReadLine();

            Recipe.AddStep(description);
        }

        private void PrintRecipe()
        {
            Recipe.PrintRecipe();
        }

        private void ScaleRecipe()
        {
            Console.WriteLine("Enter scaling factor:");
            double factor;
            while (!double.TryParse(Console.ReadLine(), out factor))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Recipe.ScaleRecipe(factor);
        }

        private void ResetQuantities()
        {
            Recipe.ResetQuantities();
        }

        private void ClearRecipe()
        {
            Recipe.Clear();
        }
    }
}

