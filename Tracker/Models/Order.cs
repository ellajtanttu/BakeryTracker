using System.Collections.Generic;
namespace Tracker.Models
{
  public class Order
  {
    public string Title { get; set; } // user input
    public string Description { get; set; } // user input
    public int Price { get; } // auto generated
    public string Date { get; } // auto generated
    private static List<Order> _instances = new List<Order> { }; // auto generated

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}