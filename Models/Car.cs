using System;
using System.Collections.Generic;

namespace Dealership {

  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Message;

    public Car(string makeModel, int price, int miles, string message) // Constructor method for Car Class
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
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

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

  }

}
