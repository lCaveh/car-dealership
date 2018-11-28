using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dealership.Controllers;
using Dealership.Models;

namespace Dealership.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
         public void Index_ReturnsCorrectView_True()
         {
             //Arrange
             HomeController controller = new HomeController();

             //Act
             ActionResult indexView = controller.Index();

             //Assert
             Assert.IsInstanceOfType(indexView, typeof(ViewResult));
         }

       [TestMethod]
       public void Index_HasCorrectModelType_CarList()
       {
           //Arrange
           HomeController controller = new HomeController();
            ViewResult indexView = new HomeController().Index() as ViewResult;

           //Act
           ViewResult result = (ViewResult) indexView.ViewData.Model;

           //Assert
           Assert.IsInstanceOfType(result, typeof(List<Car>));
       }

    }
}
