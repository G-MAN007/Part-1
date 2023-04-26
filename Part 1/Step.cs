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
        public string Description { get; set; } // holds the description of the step

        // constructor to initialize the description of the step
        public Step(string description)
        {
            Description = description;
        }
    }
}
