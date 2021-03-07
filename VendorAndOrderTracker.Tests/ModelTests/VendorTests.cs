using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  // public class VendorTests : IDisposable
  public class VendorTests
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor Name", "trial Vendor desciption");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Vendor Name";
      string description = "Vendor Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string name = "Vendor Name";
      string description = "Vendor Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string updatedDescription = "Updated Vendor Description";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;


      //Assert
      Assert.AreEqual(updatedDescription, result);
    }


  }
}