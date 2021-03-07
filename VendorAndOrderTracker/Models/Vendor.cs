using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; } //new empty List to eventually contain "Order" objects that belong to this "Vendor".

    public Vendor(string vendorName, string description)
    {
      Name = vendorName;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}




//accepts an ID as an argument and then locates the Category in the static _instances array that matches.