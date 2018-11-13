using System;
using System.Collections.Generic;

namespace Dealership
{

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2014 Porsche 911", 85000, 7550, "Super fast red porsche!!");
      Car ford = new Car("2011 Ford Mustang", 24500, 65000, "Fun to drive!");
      Car lexus = new Car("2013 Lexus RX 350", 44700, 16000, "very reliable!");
      Car mercedes = new Car("2018 Mercedes Benz CLS550", 59900, 2200, "convertible, awesome!");
      Car secondCar =  new Car("Toyota Rav-4", 7000, 150000, "4 wheel drive!");
      Car firstCar = new Car("Chrysler Lebaron", 4000, 200000, "Old classic!");

      List<Car> Cars = new List<Car> { porsche, ford, lexus, mercedes, secondCar, firstCar };

      lexus.SetPrice(2000);

      Console.WriteLine("Enter maximum price: ");
      string maxPriceString = Console.ReadLine();
      int maxPrice = int.Parse(maxPriceString);
      Console.WriteLine("Enter maximum mileage: ");
      string maxMilesString = Console.ReadLine();
      int maxMiles = int.Parse(maxMilesString);

      List<Car> carsMatchingSearch = new List<Car>(0);

      foreach(Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice) && automobile.UnderMileage(maxMiles))
        {
          carsMatchingSearch.Add(automobile);
        }
      }
      if (carsMatchingSearch.Count == 0)
      {
        Console.WriteLine("Your search returned no results.");
      }

      foreach(Car automobile in carsMatchingSearch)
      {
        Console.WriteLine("-----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
        Console.WriteLine("This car is " + automobile.GetMessage());
      }
    }
  }

}
