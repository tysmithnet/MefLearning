using System;
using System.ComponentModel.Composition.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.Composition;

namespace ExtensibleLibrary.Test
{
    [TestClass]
    public class CreationTests
    {   
        [TestMethod]
        public void SatisfyImportsOnce_Does_Not_Require_Export_Attribute()
        {
            // arrange
            NonExportedCar nonExportedCar = new NonExportedCar();

            // act
            Utility.CarContainer.SatisfyImportsOnce(nonExportedCar);

            // assert
            Assert.IsNotNull(nonExportedCar.BodyType);
            Assert.IsNotNull(nonExportedCar.Transmission);
        }

        [TestMethod]
        public void GetExportedValue_Requires_Export_Attribute()
        {
            // arrange
            // act
            // assert
            Assert.ThrowsException<ImportCardinalityMismatchException>(
                () => Utility.CarContainer.GetExportedValue<NonExportedCar>());
        }

        [TestMethod]
        public void SatisfyImportOnce_Does_Not_Throws_If_Called_Twice()
        {
            // arrange
            NonExportedCar nonExportedCar = new NonExportedCar();

            // act
            Utility.CarContainer.SatisfyImportsOnce(nonExportedCar);
            Utility.CarContainer.SatisfyImportsOnce(nonExportedCar);

            // assert
            Assert.IsNotNull(nonExportedCar.BodyType);
            Assert.IsNotNull(nonExportedCar.Transmission);
        }

        [TestMethod]
        public void Import_Requires_Single_Matching_Export()
        {
            // arrange
            // act
            // assert
            Assert.ThrowsException<ImportCardinalityMismatchException>(() => Utility.CarContainer.GetExportedValue<Junk>());
        }
    }
}