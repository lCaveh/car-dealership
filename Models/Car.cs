using System;
using System.Collections.Generic;

namespace Dealership {

  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;

    public Car(string makeModel, int price, int miles) // Constructor method for Car Class
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
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

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }
  }

}