using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Dealership.Models;

namespace Dealership.Tests
{
  [TestClass]
  public class CarTest

  {

    [TestMethod]
    public void CarConstructor_CreatesInstanceOfCar_Car()
    {
      Car newCar = new Car("BMW 530i",20000,30000,"Good car!");
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }

    [TestMethod]
    public void GetMakeModel_ReturnsModel_String()
    {
      Car newCar = new Car("BMW 530i",20000,30000,"Good car!");
      string result = newCar.GetMakeModel();
      Assert.AreEqual("BMW 530i", result);
    }
    [TestMethod]
    public void GetPrice_ReturnsPrice_Integer()
    {
      Car newCar = new Car("BMW 530i",20000,30000,"Good car!");

      int result = newCar.GetPrice();
      Assert.AreEqual(20000, result);
    }
    [TestMethod]
    public void GetMiles_ReturnsMiles_Integer()
    {
      Car newCar = new Car("BMW 530i",20000,30000,"Good car!");

      int result = newCar.GetMiles();
      Assert.AreEqual(30000, result);
    }
    [TestMethod]
    public void GetMessage_ReturnsMessage_String()
    {
      Car newCar = new Car("BMW 530i",20000,30000,"Good car!");

      string result = newCar.GetMessage();
      Assert.AreEqual("Good car!", result);
    }
    [TestMethod]
    public void WorthBuying_ReturnBool()
    {
      Car newCar = new Car("BMW 530i",20000,30000,"Good car!");
      Assert.IsFalse(newCar.WorthBuying(10000));
      Assert.IsTrue(newCar.WorthBuying(30000));
    }
    public void UnderMileage_ReturnBool()
    {
      Car newCar = new Car("BMW 530i",20000,30000,"Good car!");
      Assert.IsFalse(newCar.UnderMileage(10000));
      Assert.IsTrue(newCar.UnderMileage(30000));
    }

  }
}
