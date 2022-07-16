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
    public void BreadCost_ReturnBaseBreadCost_5()
    {
      int BreadCost = 5;
      Bread BreadOrder = new Bread();
    
    Assert.AreEqual(BreadCost, BreadOrder.GetBreadCost(1));

    }
    
  }
}