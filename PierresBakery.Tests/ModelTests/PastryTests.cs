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
        [TestMethod]
        public void  PastryCost_CostOfThreePastryWithDiscount_Int()
        
        {
            //Arrange
            int pastryQuantity = 3;
            double pastryCost = 5;
            //Act
           Pastry PastryOrder = new Pastry(pastryQuantity);
            //Assert
            Assert.AreEqual(pastryCost , PastryOrder.PastryCost());
        }
        [TestMethod]
        public void PastryCost_CostOfFourPastryDiscount_Int()
        {
        
          int pastryQuantity = 4;
          double pastryCost = 7;
          
          Pastry pastryOrder = new Pastry(pastryQuantity);
      
          Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
        }

         
    }
}