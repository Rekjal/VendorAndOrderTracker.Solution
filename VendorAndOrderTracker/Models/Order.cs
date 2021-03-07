using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Description { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public int Id { get; }
    public string Title { get; set; }
    public string Price { get; set; }
    public string Date { get; }

    public Order(string description, string title, int price)
    {
      // Description = description;
      // _instances.Add(this);
      // Id = _instances.Count;
      // Title = title;
      // Price = price;
      // Date = DateTime.Now.ToString("M/d/yyyy");
    }

  

  }
}