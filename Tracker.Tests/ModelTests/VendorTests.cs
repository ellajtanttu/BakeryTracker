using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System;
using System.Collections.Generic;

namespace Tracker.Tests
{

  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("Sally's", "delicatessen on Main St.");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_Vendor()
    {
      //Arrange
      string vendorName = "Sally's";

      //Act
      Vendor testVendor = new Vendor(vendorName, "delicatessen on Main St.");
      string result = testVendor.Name;

      //Assert
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetAll_ReturnEmptyVendorList_VendorList()
    {
      //Arrange
      List<Vendor> testVendorList = new List<Vendor> { };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(testVendorList, result);
    }

    [TestMethod]
    public void GetAll_ReturnVendors_VendorList()
    {
      //Arrange
      string vendorName01 = "Sally's";
      string vendorName02 = "12th Street Bistro";
      Vendor newVendor01 = new Vendor(vendorName01, "desc1");
      Vendor newVendor02 = new Vendor(vendorName02, "desc2");
      List<Vendor> testVendorList = new List<Vendor> { newVendor01, newVendor02 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(testVendorList, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string vendorName = "Sally's";
      string vendorDesc = "delicatessen on Main St.";
      Vendor newVendor01 = new Vendor(vendorName, vendorDesc);

      //Act
      int expectedResult = 1;
      int result = newVendor01.Id;

      //Assert
      Assert.AreEqual(expectedResult, result);
    }

  }
}