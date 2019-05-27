using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _200339879_LessonThree_ClassProject.Models;

namespace _200339879_LessonThree_ClassProject.Controllers
{
    public class CarController : Controller
    {
        List<Car> carList = new List<Car>() {
            new Car (1, "Toyota", "Corolla", "Compact", 2017),
            new Car (2, "Ford", "F-150", "Truck", 2018),
            new Car (3, "Dodge", "Caravan", "Minivan", 2019)
        };
        // GET: Car
        public ActionResult Index()
        {
            //return View();

            //this will redirect to home page 
            //return RedirectToAction("Index", "Home");

            return Content("/Car - This is a list of cars from Content()");
        }
    }
}