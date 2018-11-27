using System;
using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Message;
    private static List<Car> Instances = new List<Car> {};

    public Car(string makeModel, int price, int miles, string message)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
      Instances.Add(this);

    }

    public string GetMakeModel()
    {
      return MakeModel;
    }
    public int GetPrice()
    {
      return Price;
    }
    public int GetMiles()
    {
      return Miles;
    }
    public string GetMessage()
    {
      return Message;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public bool UnderMileage(int maxMiles)
    {
      return (Miles <= maxMiles);
    }

    public static List<Car> GetAll()
    {
        return Instances;
    }
    public static List<Car> GetMatchResult(int maxPrice, int maxMiles)
    {
      List<Car> filteredList = new List<Car>() {};
      foreach(Car automobile in Instances)
      {
        if (automobile.WorthBuying(maxPrice) && automobile.UnderMileage(maxMiles))
        {
          filteredList.Add(automobile);
        }
      }
      return filteredList;
    }
  }

}
