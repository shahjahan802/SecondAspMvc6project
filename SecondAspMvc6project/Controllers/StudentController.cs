using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondAspMvc6project.Models;

namespace SecondAspMvc6project.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentData()
        {
            ViewBag.studentId = 802;
            ViewBag.StudentName = "shahJahan";
            ViewData["Roll"] = 7868;
            ViewData["name"]="Shah jahan";

            //  ViewBag.Title = System.Resources.ApplicationTitle;
            // ViewBag.LabelStatus = ResourceSet.Status;
            //ViewBag.img=@"C:\wwwroot\images\shah.jpg";


            //ViewBag.Logo =MapPath("~") + @"Content\Images\Logo.png";



            Student s = new Student();
            s.id = 032148;
            s.name = "Shah Jahan802";
            s.subject = "BSCS";
            s.course = "oop";
            s.institute = " AJK university";
            //s.time = 3 / 4 /;
            //s.Dweek = 33442;
           
                       
            ViewBag.Studinfo = s;

            return View();
        }
        
    }
}