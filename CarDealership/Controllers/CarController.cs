using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles, string message)
    {
      Car myCar = new Car(makeModel, price, miles, message);
      return RedirectToAction("Index");
    }

    [HttpGet("cars/search")]
    public ActionResult SearchForm()
    {
      return View();
    }

    [HttpPost("/cars/results")]
    public ActionResult SearchResults(int maxPrice, int maxMiles)
    {
      List<Car> carsMatchingSearch = Car.GetMatchResult(maxPrice, maxMiles);

      return View(carsMatchingSearch);
    }

  }
}
