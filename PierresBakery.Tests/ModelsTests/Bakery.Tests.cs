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
       
  }
}