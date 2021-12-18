using System.Collections.Generic;
namespace Tracker.Models
{
  public class Vendor
  {
    public string Name { get; set; } // user input
    public string Description { get; set; } // user input
    public int Id { get; } // auto generated
    private static List<Vendor> _instances = new List<Vendor> {}; // auto generated

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Id = _instances.Count;
      _instances.Add(this);
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