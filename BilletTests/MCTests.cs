using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletTests {
    [TestClass]
    public class MCTests {
        [TestMethod]
        public void TestMC_PriceNotNegative() {
            //arrange
            MC mc = new MC();

            //act
            int actual = mc.Price();

            //assert
            Assert.IsTrue(actual >= 0);
        }

        [TestMethod]
        public void TestMC_PriceEquals240() {
            //arrange
            MC mc = new MC();

            //act
            int expected = 240;
            int actual = mc.Price();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCar_VehicleTypeNotWhiteOrNullspace() {
            //arrange
            MC mc = new MC();

            //act
            string actual = mc.VehicleType();

            //assert
            Assert.IsFalse(String.IsNullOrWhiteSpace(actual));
        }

        [TestMethod]
        public void TestCar_LicensePlateAfterFirstSet() {
            //arrange
            MC mc = new MC();
            string expected = "ABCD";

            //act
            string actual = mc.LicensePlate = "ABCD";

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCar_DateAfterFirstSet() {
            //arrange
            MC mc = new MC();
            DateTime expected = new DateTime(1970, 1, 1, 0, 0, 0);

            //act
            mc.Date = new DateTime(1970, 1, 1, 0, 0, 0);
            DateTime actual = mc.Date;

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
