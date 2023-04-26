using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication
{
    // Step class to represent a step in the recipe
    internal class Step
    {
        // Properties
        public string Description { get; set; }

        // Constructor
        public Step(string description)
        {
            Description = description;
        }
    }
}
