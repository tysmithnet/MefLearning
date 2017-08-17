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
            CompositionContainer = Utility.GetCompositionContainer();
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
    }
}
