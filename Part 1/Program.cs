using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RecipeApplication
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            ConsoleColor orange = ConsoleColor.Red;
            ConsoleColor blue = ConsoleColor.Blue;


            while (true)
            {
                Console.ForegroundColor = orange;
                Console.BackgroundColor = blue;
                Console.WriteLine("Enter a command:");
                Console.WriteLine("1. Add ingredient");
                Console.WriteLine("2. Scale recipe");
                Console.WriteLine("3. Print recipe");
                Console.WriteLine("4. Reset quantities to original values");
                Console.WriteLine("5. Clear all data and start over");
                Console.WriteLine("6. Print ingredients with steps");
                Console.WriteLine("0. Exit");

                string command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                            recipe.AddIngredient(name, quantity, unit);
                            Console.Write("Ingredient: " + (i + 1) + "\n");
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Quantity: ");
                            double quantity = double.Parse(Console.ReadLine());
                            Console.Write("Unit: ");
                            string unit = Console.ReadLine();
                            
                        break;

                    case "2":
                            Console.Write("Enter scale factor: ");
                            double factor = double.Parse(Console.ReadLine());
                            recipe.Scale(factor);
                        break;

                    case "3":
                            Console.WriteLine(recipe.ToString());
                        break;

                    case "4":
                            recipe.Reset();
                        break;

                    case "5":
                            recipe.Clear();
                        break;

                    case "6":
                            Console.WriteLine(recipe.ToStringWithSteps());
                        break;

                    case "0":
                        return;

                    default:
                            Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
    }
}
