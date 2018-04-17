using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondAspMvc6project.Models;

namespace SecondAspMvc6project.Controllers
{
    public class TemviewdateController : Controller
    {
      

        //Controller Action 1 (TemporaryEmployee)
       // [HttpPost]
        public IActionResult TemporaryEmployee()
        {
            Employee employee = new Employee
                        {
                            EmpID = 121,
                            EmpFirstName = "Imran",
                            EmpLastName = "Ghani"
                        };
                        
            TempData["Employee"] = employee;
            return View();
        }

        //Controller Action 2(PermanentEmployee)
        //[HttpPost]       
        public IActionResult PermanentEmployee()

        {
            Employee employee = TempData["Employee"] as Employee;
            return View(employee);
        }


        //oop apprach
       /* public ActionResult Index()
        {
            var model = new Review()
            {
                Body = "Start",
                Rating = 5
            };
            TempData["ModelName"] = model;
            return RedirectToAction("About");
        }
         public ActionResult About()
        {
            var model = TempData["ModelName"];
            return View(model);
        }*/
    }
}