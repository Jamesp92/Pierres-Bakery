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
    public void BreadCost_ResturnBaseBreadCost_5()
    {
      int BreadQuanity = 1;
      double BreadCost = 5;
      Bread BreadOrder = new Bread();
    
    Assert.AreEqual(BreadCost, BreadOrder.GetBread(BreadQuanity));

    }
    
  }
}