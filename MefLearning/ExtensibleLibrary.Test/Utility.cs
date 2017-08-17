using System;
using System.ComponentModel.Composition.Hosting;

namespace ExtensibleLibrary.Test
{
    public static class Utility
    {
        public static Type[] CarTypes = new Type[]
        {
            typeof(Car),
            typeof(NonExportedCar),
            typeof(Transmission),
            typeof(Automatic),
            typeof(BodyType),
            typeof(FourDoor)
        };

        public static CompositionContainer CarContainer { get; } = GetCarContainer();

        public static CompositionContainer GetCarContainer()
        {
            TypeCatalog typeCatalog = new TypeCatalog(CarTypes);
            return new CompositionContainer(typeCatalog);
        }
    }
}