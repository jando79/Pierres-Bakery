using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void CreateBreadClass_CreateClass_BreadClass()
    {
      Bread newBread = new Bread("5");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void CreatePastryClass_CreateClass_PastryClass()
    {
      Pastry newPastry = new Pastry("3");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetBreadNumber_ReturnsBreadNumber_Int()
    {
      string stringBreadNumber = "5";
      Bread newBread = new Bread(stringBreadNumber);
      int breadNumber = int.Parse(stringBreadNumber);
      int result = newBread.BreadNumber;
      Assert.AreEqual(breadNumber, result);
    }

    [TestMethod]
    public void GetPastryNumber_ReturnPastryNumber_Int()
    {
      string stringPastryNumber = "3";
      Pastry newPastry = new Pastry(stringPastryNumber);
      int pastryNumber = int.Parse(stringPastryNumber);
      int result = newPastry.PastryNumber;
      Assert.AreEqual(pastryNumber, result);
    }

    [TestMethod]
    public void BreadPrice_ReturnBreadPrice_Int()
    {
      string stringBreadNumber = "1";
      Bread newBread = new Bread(stringBreadNumber);
      int expected = 5;
      int result = newBread.BreadPrice();
      Assert.AreEqual(expected, result);
    }
  }


}