using System.ComponentModel.Composition;

namespace ExtensibleLibrary.Food
{
    public class Meal
    {
        [Import]
        public Carb Carb { get; set; }

        [Import]
        public Protein Protein { get; set; }
    }
}