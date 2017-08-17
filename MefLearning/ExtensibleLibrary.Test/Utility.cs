using System.ComponentModel.Composition.Hosting;

namespace ExtensibleLibrary.Test
{
    public static class Utility
    {
        public static CompositionContainer GetCompositionContainer()
        {
            AggregateCatalog aggregateCatalog = new AggregateCatalog();
            aggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Car).Assembly));
            return new CompositionContainer(aggregateCatalog);
        }
    }
}