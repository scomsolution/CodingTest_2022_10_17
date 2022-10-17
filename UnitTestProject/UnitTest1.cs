using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double coinValue = 0.10;
            bool expexted = true;

            //Act
            bool status = CodingTest.VenderMachine.IsValidCoin(coinValue);

            //Assert
            Assert.AreEqual(expexted, status);

        }

        [TestMethod]
        public void _IsValidCoin()
        {
            //Arrange
            double coinValue = 0.10;
            bool expexted = true;

            //Act
            bool status = CodingTest.VenderMachine.IsValidCoin(coinValue);

            //Assert
            Assert.AreEqual(expexted, status);

        }

        [TestMethod]
        public void _SelectProduct()
        {
            //Arrange
            List<CodingTest.product> products = CodingTest.VenderMachine.GetProductList();
            

            int inputProductID = 2;
            CodingTest.product expextedOutput = products[inputProductID-1];

            //Act
            CodingTest.product output = CodingTest.VenderMachine.SelectProduct(inputProductID);

            //Assert
            var js = new JavaScriptSerializer();
            Assert.AreEqual(js.Serialize(expextedOutput), js.Serialize(output));

            
        }

        //[TestMethod]
        //public void _IsValidCoin()
        //{
        //    //Arrange
        //    double coinValue = 0.10;
        //    bool expexted = true;

        //    //Act
        //    bool status = CodingTest.VenderMachine.IsValidCoin(coinValue);

        //    //Assert
        //    Assert.AreEqual(expexted, status);

        //}

        //[TestMethod]
        //public void _IsValidCoin()
        //{
        //    //Arrange
        //    double coinValue = 0.10;
        //    bool expexted = true;

        //    //Act
        //    bool status = CodingTest.VenderMachine.IsValidCoin(coinValue);

        //    //Assert
        //    Assert.AreEqual(expexted, status);

        //}

        //[TestMethod]
        //public void _IsValidCoin()
        //{
        //    //Arrange
        //    double coinValue = 0.10;
        //    bool expexted = true;

        //    //Act
        //    bool status = CodingTest.VenderMachine.IsValidCoin(coinValue);

        //    //Assert
        //    Assert.AreEqual(expexted, status);

        //}

        //Done
    }
}
