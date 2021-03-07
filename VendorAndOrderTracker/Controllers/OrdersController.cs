using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]          // URL PATH: object & ROUTE NAME: Index
    public ActionResult Index()  //Display list of object via GET.
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")] // URL PATH: object/new & ROUTE NAME: New 
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]  // URL PATH: object & ROUTE NAME: Create 
    public ActionResult Create(string description) //create a object using POST
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]  //delete an object using POST
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

    [HttpGet("/items/{id}")] //dynamic routing
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }

  }
}