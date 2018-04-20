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
                            EmpFirstName = "Imran"
                            
                        };
            TempData["Employee"] = employee;
            
            return RedirectToAction("PermanentEmployee");
        }

        //Controller Action 2(PermanentEmployee)
        //[HttpPost]       
        public IActionResult PermanentEmployee()

        {
            Employee employee = new Employee
            {
                EmpLastName = "sialkot"

            };
            TempData["employee"] = employee;
            return View();
        }


        ////oop apprach
        //public ActionResult Index()
        //{
        //    Employee model = new Employee
        //    { EmpID = 23,
        //        EmpFirstName = "ali"
        //    };
        //    TempData["ModelName"] = model;
        //    return RedirectToAction("About");
        //}
        //public ActionResult About()
        //{
        //     = TempData["ModelName"];
            
        //    return View(model);
        //}
    }
}