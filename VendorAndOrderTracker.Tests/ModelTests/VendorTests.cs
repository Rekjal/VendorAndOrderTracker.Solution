using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;


namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor Name", "trial Vendor desciption");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
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

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Vendor Name";
      string description = "Vendor Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      //Arrange
      string name = "Vendor Name";
      string description = "Vendor Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string updatedName = "New Vendor Name";
      newVendor.Name = updatedName;
      string result = newVendor.Name;


      //Assert
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Vendor Name";
      string description = "Vendor Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Vendor Name-1";
      string name02 = "Vendor Name-2";
      string description01 = "Vendor Description-1"; 
      string description02 = "Vendor Description-2";
      Vendor newVendor01 = new Vendor(name01, description01);
      Vendor newVendor02 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor01, newVendor02 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }



  }
}