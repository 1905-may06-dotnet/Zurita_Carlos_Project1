using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TotalCostTest()
        {
            //Arrange
            int sizecost1 = 6;
            int crustcost1 = 6;
            int expected = 12;

            //Act
            int actual = PizzaBox.Domain.BusinessLogic.totalordercost(sizecost1, crustcost1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SelectSizeTest()
        {
            //Arrange
            int usersize1 = 1;
            string expected = "Small";

            //Act
            string actual = PizzaBox.Domain.BusinessLogic.SelectSize(usersize1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SelectCrustTest()
        {
            //Arrange
            int usersizec1 = 1;
            string expected = "Thin";

            //Act
            string actual = PizzaBox.Domain.BusinessLogic.SelectCrust(usersizec1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SizeCostTest()
        {
            //Arrange
            string sizesels = "Small";
            int expected = 6;

            //Act
            int actual = PizzaBox.Domain.BusinessLogic.SizeCost(sizesels);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CrustCostTest()
        {
            //Arrange
            string crustselc = "Thin";
            int expected = 6;

            //Act
            int actual = PizzaBox.Domain.BusinessLogic.CrustCost(crustselc);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
