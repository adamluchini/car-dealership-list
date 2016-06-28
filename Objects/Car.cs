using System.Collections.Generic;

namespace CarDealership.Objects
{
  public class Car
  {
    private string _make;
    private string _model;
    private string _mileage;
    private string _price;
    private static List<Car> _instances = new List<Car> {};
    public Car (string make, string model, string mileage, string price)
    {
      _make = make;
      _model = model;
      _mileage = mileage;
      _price = price;
    }
    public void SetMake(string newMake)
    {
      _make = newMake;
    }
    public string GetMake()
    {
      return _make;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }
    public string GetModel()
    {
      return _model;
    }
    public void SetMileage(string newMileage)
    {
      _mileage = newMileage;
    }
    public string GetMileage()
    {
      return _mileage;
    }
    public void SetPrice(string newPrice)
    {
      _price = newPrice;
    }
    public string GetPrice()
    {
      return _price;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
  }
}
