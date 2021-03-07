using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test Order", "Crossant order", 35);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Trial Order";
      string title = "Crossant order";
      int price = 35;
      Order newOrder = new Order(description, title, price);

      //Act
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Trial Order";
      string title = "Crossant order";
      int price = 35;
      Order newOrder = new Order(description, title, price);

      //Act
      string updatedDescription = "Real order";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;


      //Assert
     Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      //Arrange
      string description = "Trial Order";
      string title = "Crossant order";
      int price = 35;
      Order newOrder = new Order(description, title, price);

      //Act
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      //Arrange
      string description = "Trial Order";
      string title = "Crossant order";
      int price = 35;
      Order newOrder = new Order(description, title, price);

      //Act
      int updatedPrice = 45;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;


      //Assert
     Assert.AreEqual(updatedPrice, result);
    }

[TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string description = "Trial Order";
      string title = "Crossant order";
      int price = 35;
      Order newOrder = new Order(description, title, price);

      //Act
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_ReturnsTitle_String()
    {
      //Arrange
      string description = "Trial Order";
      string title = "Crossant order";
      int price = 35;
      Order newOrder = new Order(description, title, price);

      //Act
      string updatedTitle = "Bread Order";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;


      //Assert
     Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string description01 = "Trial Order-1";
      string description02 = "Trial Order-2";
      string title01 = "Crossant order";
      string title02 = "Bread order";
      int price01 = 35;
      int price02 = 45;
      Order newOrder1 = new Order(description01, title01, price01);
      Order newOrder2 = new Order(description02, title02, price02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}