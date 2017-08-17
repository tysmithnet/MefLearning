using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensibleLibrary.Test
{
    [TestClass]
    public class DependencyTests
    {   
        [TestMethod]
        public void Dependencies_Can_Be_Imported()
        {
            // arrange
            Car car = Utility.CarContainer.GetExportedValue<Car>();

            // act
            ;

            // assert
            Assert.IsNotNull(car.BodyType);
            Assert.IsNotNull(car.Transmission);
        }
    }
}
