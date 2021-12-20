using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System;
using System.Collections.Generic;

namespace Tracker.Tests
{

  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("test title", "test description", 1, "01/01/21");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string testTitle = "test title";
      Order testOrder = new Order(testTitle, "test description", 1, "01/01/21");
      string result = testOrder.Title;
      Assert.AreEqual(testTitle, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string testTitle = "test title";
      Order testOrder = new Order(testTitle, "test description", 1, "01/01/21");

      string updatedTitle = "test title two";
      testOrder.Title = updatedTitle;
      string result = testOrder.Title;

      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyOrdersList_OrderList()
    {
      List<Order> testOrder = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(testOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsFullOrdersList_OrderList()
    {
      string testTitle01 = "test title 1";
      string testTitle02 = "test title 2";
      Order testOrder01 = new Order(testTitle01, "test description 01", 1, "01/01/21");
      Order testOrder02 = new Order(testTitle02, "test description 02", 1, "01/01/21");
      List<Order> testList = new List<Order> {testOrder01, testOrder02};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(testList, result);
    }

  }
}