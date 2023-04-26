using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RecipeApplication
{
    internal class Recipe
    {
        private List<Ingredient> ingredients = new List<Ingredient>();
        private Dictionary<Ingredient, List<string>> ingredientSteps = new Dictionary<Ingredient, List<string>>();
        private List<Ingredient> originalIngredients = new List<Ingredient>();

        public void AddIngredient(string name, double quantity, string unit)
        {
            Console.Write("How many ingredients will you input?");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)

            {
                Console.Write($"How many steps for {name}? ");
                int numSteps = int.Parse(Console.ReadLine());

                for (int z = 0; z < numSteps; z++)
                {
                    Console.Write($"Step {z + 1}: ");
                    string description = Console.ReadLine();
                    AddStep(description);
                }
            }
            ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });

            Ingredient ingredient = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
            
            originalIngredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });

            ingredientSteps.Add(ingredient, new List<string>());

        }

        public void AddStep(string description)
        {
            if (ingredients.Count > 0)
            {
                Ingredient currentIngredient = ingredients.Last();
                if (!ingredientSteps.ContainsKey(currentIngredient))
                {
                    ingredientSteps[currentIngredient] = new List<string>();
                }
                ingredientSteps[currentIngredient].Add(description);
            }
        }

        public void Scale(double factor)
        {
            
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void Reset()
        {
            for (int i = 0; i < ingredients.Count; i++)
            {
                ingredients[i].Quantity = originalIngredients[i].Quantity;
            }
        }

        public void Clear()
        {
            ingredients.Clear();
            ingredientSteps.Clear();
            originalIngredients.Clear();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Ingredients:");
            foreach (Ingredient ingredient in ingredients)
            {
                builder.AppendLine($"{ingredient.Name}: \n {ingredient.Quantity} {ingredient.Unit}");
            }

            return builder.ToString();
        }

        public string ToStringWithSteps()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Recipe :");
            sb.AppendLine();

            foreach (Ingredient ingredient in ingredients)
            {
                sb.AppendLine($"{ingredient.Name}: \n{ingredient.Quantity} {ingredient.Unit}");
                if (ingredientSteps.ContainsKey(ingredient))
                {
                    List<string> steps = ingredientSteps[ingredient];
                    for (int a = 0; a < steps.Count; a++)
                    {
                        sb.AppendLine($"{a + 1}. Steps: \n{steps[a]}");
                    }
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}

