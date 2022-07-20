using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PastryTest.Tests
{
    [TestClass]
    public class PastryTest
    {
        [TestMethod]
        public void  PastryCost_CostOnePastryNoDiscount_Int()
        
        {
            //Arrange
            int pastryQuantity = 1;
            double pastryCost = 2;
            //Act
           Pastry PastryOrder = new Pastry(pastryQuantity);
            //Assert
            Assert.AreEqual(pastryCost , PastryOrder.PastryCost());
        }
        

         
}
}