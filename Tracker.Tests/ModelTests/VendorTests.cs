using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System;
using System.Collections.Generic;

namespace Tracker.Tests
{
  public class TrackerTests
  {
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("Sally's", "delicatessen on Main St.");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
  }
}