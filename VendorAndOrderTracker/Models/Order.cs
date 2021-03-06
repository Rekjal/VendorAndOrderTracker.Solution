using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Description { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public int Id { get; }
    public string Title { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }

    public Order(string description, string title, int price)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Title = title;
      Price = price;
      // DateTime date1 = new DateTime(2008, 6, 1, 7, 47, 0);
      // DateTime dateOnly = date1.Date;
      Date = DateTime.Now.ToString("M/d/yyyy");
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
       _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
