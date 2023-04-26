namespace ErenYeager
{
    // Step class to represent a step in the recipe
    public class Step
    {
        // Properties
        public string Description { get; set; }

        // Constructors
        public Step(string description)
        {
            Description = description;
        }
    }
}
