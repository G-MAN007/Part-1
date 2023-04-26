using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication
{
    internal class Step
    {
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;

        }
    }
}
