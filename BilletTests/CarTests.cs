using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billet.Tests {
    [TestClass]
    public class CarTests {
        [TestMethod]
        public void TestCar_PriceNotNegative() {
            //arrange
            Car car = new Car();

            //act
            int actual = car.Price();

            //assert
            Assert.IsTrue(actual >= 0);
        }

        [TestMethod]
        public void TestCar_PriceEquals240() {
            //arrange
            Car car = new Car();

            //act
            int expected = 240;
            int actual = car.Price();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCar_VehicleTypeNotWhiteOrNullspace() {
            //arrange
            Car car = new Car();

            //act
            string actual = car.VehicleType();

            //assert
            Assert.IsFalse(String.IsNullOrWhiteSpace(actual));
        }

        [TestMethod]
        public void TestCar_LicensePlateAfterFirstSet() {
            //arrange
            Car car = new Car();
            string expected = "ABCD";

            //act
            string actual = car.LicensePlate = "ABCD";

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCar_LicensePlateLongerThan7_ThrowsEx() {
            //arrange
            Car car = new Car();

            //act
            car.LicensePlate = "ABCDEFGH";
        }

        [TestMethod]
        public void TestCar_DateAfterFirstSet() {
            //arrange
            Car car = new Car();
            DateTime expected = new DateTime(1970, 1, 1, 0, 0, 0);

            //act
            car.Date = new DateTime(1970, 1, 1, 0, 0, 0);
            DateTime actual = car.Date;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
