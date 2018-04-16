using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondAspMvc6project.Models;

namespace SecondAspMvc6project.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentData()
        {
            ViewBag.studentId = "802";
            ViewBag.StudentName = "shahJahan";



            Student s = new Student();
            s.id = 032148;
            s.name = "Shah Jahan802";
            s.subject = "BSCS";
            s.course = "oop";
            s.institute = " AJK university";
            //s.time = 3 / 4 /;
                       
            ViewBag.Studinfo = s;

            return View();
        }
        
    }
}