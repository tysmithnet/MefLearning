using System;
using System.ComponentModel.Composition.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.Composition;
using ExtensibleLibrary.Cars;
using ExtensibleLibrary.Food;

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
        public void Singletons_Are_Created_By_Default()
        {
            // arrange
            // act
            Car car1 = Utility.CarContainer.GetExportedValue<Car>();
            Car car2 = Utility.CarContainer.GetExportedValue<Car>();

            NonExportedCar nonExportedCar1 = new NonExportedCar();
            NonExportedCar nonExportedCar2 = new NonExportedCar();
                             
            // assert
            Assert.AreSame(car1, car2);
            Assert.AreNotSame(nonExportedCar1, nonExportedCar2);
            Assert.AreSame(nonExportedCar1.BodyType, nonExportedCar2.BodyType);
            Assert.AreSame(nonExportedCar1.Transmission, nonExportedCar2.Transmission);
        }

        [TestMethod]
        public void New_Instances_Can_Be_Created()
        {
            // arrange
            // act
            Meal meal1 = Utility.FoodContainer.GetExportedValue<Meal>();
            Meal meal2 = Utility.FoodContainer.GetExportedValue<Meal>();

            // assert
            Assert.AreNotSame(meal1, meal2);
        }

        [TestMethod]
        public void New_Instances_Have_Singleton_Components_Unless_They_Have_NonShared()
        {
            // arrange
            // act
            Meal meal1 = Utility.FoodContainer.GetExportedValue<Meal>();
            Meal meal2 = Utility.FoodContainer.GetExportedValue<Meal>();

            // assert                                     
            Assert.AreNotSame(meal1, meal2);
            Assert.AreSame(meal1.Carb, meal2.Carb);
            Assert.AreNotSame(meal1.Protein, meal2.Protein);
        }
    }
}