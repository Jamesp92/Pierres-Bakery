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
   }
}
