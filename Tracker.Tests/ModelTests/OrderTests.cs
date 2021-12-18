using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System;
using System.Collections.Generic;

namespace Tracker.Tests
{

  [TestClass]
  public class OrderTests //: IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("test title", "test description", 1, "01/01/21");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

  }
}

// (string title, string description, int price, int date)