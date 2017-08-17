using System.ComponentModel.Composition.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.Composition;

namespace ExtensibleLibrary.Test
{
    [TestClass]
    public class CreationTests
    {
        public CompositionContainer CompositionContainer { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            CompositionContainer = Utility.GetCompositionContainer();
        }

        [TestMethod]
        public void SatisfyImportsOnce_Does_Not_Require_Export_Attribute()
        {
            // arrange
            NonExportedCar nonExportedCar = new NonExportedCar();

            // act
            CompositionContainer.SatisfyImportsOnce(nonExportedCar);

            // assert
            Assert.IsNotNull(nonExportedCar.BodyType);
            Assert.IsNotNull(nonExportedCar.TransmissionType);
        }

        [TestMethod]
        public void GetExportedValue_Requires_Export_Attribute()
        {
            // arrange
            // act
            // assert
            Assert.ThrowsException<ImportCardinalityMismatchException>(
                () => CompositionContainer.GetExportedValue<NonExportedCar>());
        }

        [TestMethod]
        public void SatisfyImportOnce_Does_Not_Throws_If_Called_Twice()
        {
            // arrange
            NonExportedCar nonExportedCar = new NonExportedCar();

            // act
            CompositionContainer.SatisfyImportsOnce(nonExportedCar);
            CompositionContainer.SatisfyImportsOnce(nonExportedCar);

            // assert
            Assert.IsNotNull(nonExportedCar.BodyType);
            Assert.IsNotNull(nonExportedCar.TransmissionType);
        }
    }
}