using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensibleLibrary.Test
{
    [TestClass]
    public class DependencyTests
    {
        public CompositionContainer CompositionContainer { get; set; }

        [TestInitialize]
        public void Setup()
        {
            AggregateCatalog aggregateCatalog = new AggregateCatalog();
            aggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Car).Assembly));
            CompositionContainer = new CompositionContainer(aggregateCatalog);
        }

        [TestMethod]
        public void Dependencies_Can_Be_Imported()
        {
            // arrange
            Car car = CompositionContainer.GetExportedValue<Car>();

            // act
            ;

            // assert
            Assert.IsNotNull(car.BodyType);
            Assert.IsNotNull(car.TransmissionType);
        }

        [TestMethod]
        public void GetExportedValue_Requires_Export_Attribute()
        {
            Assert.ThrowsException<ImportCardinalityMismatchException>(
                () => CompositionContainer.GetExportedValue<NonExportedCar>());
        }
    }
}
