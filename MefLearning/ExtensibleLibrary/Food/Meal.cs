using System.ComponentModel.Composition;

namespace ExtensibleLibrary.Food
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Meal
    {
        [Import]
        public Carb Carb { get; set; }

        [Import]
        public Protein Protein { get; set; }
    }
}