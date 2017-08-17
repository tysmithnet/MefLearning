using System;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using ExtensibleLibrary.Cars;
using ExtensibleLibrary.Food;

namespace ExtensibleLibrary.Test
{
    public static class Utility
    {
        public static CompositionContainer CarContainer { get; } = GetCarContainer();

        public static CompositionContainer GetCarContainer()
        {
            var types = typeof(Car).Assembly.ExportedTypes.Where(x => x.Namespace == typeof(Car).Namespace).ToArray();
            return new CompositionContainer(new TypeCatalog(types));
        }

        public static CompositionContainer FoodContainer { get; } = GetFoodContainer();

        public static CompositionContainer GetFoodContainer()
        {
            var types = typeof(Meal).Assembly.ExportedTypes.Where(x => x.Namespace == typeof(Meal).Namespace).ToArray();
            return new CompositionContainer(new TypeCatalog(types));
        }
    }
}