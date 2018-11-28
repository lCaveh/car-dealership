using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dealership.Controllers;
using Dealership.Models;

namespace Dealership.Tests
{
    [TestClass]
    public class CarControllerTests
    {

       [TestMethod]
     public void Create_ReturnsCorrectActionType_RedirectToActionResult()
     {
         //Arrange
         CarsController controller = new CarsController();

         //Act
         IActionResult view = controller.Create("bmw 530 i",20000,30000,"Good car!");

         //Assert
         Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
     }

     [TestMethod]
     public void Create_RedirectsToCorrectAction_Index()
     {
         //Arrange
         CarsController controller = new CarsController();
         RedirectToActionResult actionResult = controller.Create("bmw 530 i",20000,30000,"Good car!") as RedirectToActionResult;

         //Act
         string result = actionResult.ActionName;

         //Assert
         Assert.AreEqual(result, "Index");
     }
    //  [TestMethod]
    //  public void SearchForm_ReturnsCorrectActionType_ViewResult()
    //  {
    //      //Arrange
    //      CarsController controller = new CarsController();
    //      IActionResult view = controller.SearchForm() as ViewResult();
     //
    //      //Act
     //
    //      //Assert
    //      Assert.IsInstanceOfType(view, typeof(ActionResult));
    //  }


    }
}
