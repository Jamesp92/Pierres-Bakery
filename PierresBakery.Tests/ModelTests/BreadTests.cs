using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace BreadTest.Tests
{
   [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void  BreadCost_CostOneLoafNoDiscount_Int()
        
        {
            //Arrange
            int breadQuantity = 1;
            double breadCost = 5;
            //Act
           Bread BreadOrder = new Bread(breadQuantity);
            //Assert
            Assert.AreEqual(breadCost , BreadOrder.BreadCost());
        }
        [TestMethod]
        public void  BreadCost_CostTwoLoafNoDiscount_Int()
        
        {
            //Arrange
            int breadQuantity = 2;
            double breadCost = 10;
            //Act
           Bread BreadOrder = new Bread(breadQuantity);
            //Assert
            Assert.AreEqual(breadCost , BreadOrder.BreadCost());
        }
         [TestMethod]
        public void  BreadCost_thirdLoafisDiscount_Int()
        
        {
            //Arrange
            int breadQuantity = 3;
            double breadCost = 10;
            //Act
           Bread BreadOrder = new Bread(breadQuantity);
            //Assert
            Assert.AreEqual(breadCost , BreadOrder.BreadCost());
        }
         
}
}
