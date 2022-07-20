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
            int BreadQuantity = 1;
            double BreadCost = 5;
            //Act
           Bread BreadOrder = new Bread();
            //Assert
            Assert.AreEqual(BreadCost, BreadOrder.BreadCost());
        }
   }
}
