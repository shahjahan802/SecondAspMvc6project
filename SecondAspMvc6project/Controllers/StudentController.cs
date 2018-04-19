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
          //  ViewBag.path = Ur\wwwroot\images\shah.jpg");
            ViewData["Roll"] = 7868;
            ViewData["name"] = "Shah jahan";
            TempData["Institute"] = "punjabi college";
            //  ViewBag.Title = System.Resources.ApplicationTitle;
            // ViewBag.LabelStatus = ResourceSet.Status;
            //ViewBag.img=@"C:\wwwroot\images\shah.jpg";


            //ViewBag.Logo =MapPath("~") + @"Content\Images\Logo.png";

            // GET: Demo/GetImageFromByteArray  


            // Get image path  

    
            Student s = new Student();
            s.id = 032148;
            s.name = "Shah Jahan802";
            s.subject = "BSCS";
            s.course = "oop";
            s.institute = " AJK university";
            //s.time = 3 / 4 /;
            //s.Dweek = 33442;
            // ViewData["VD"] = s;
            //TempData["TD"] = s;

            ViewBag.Studinfo = s;

            return View();
        }
        public IActionResult studlistData()
        {
            Student obj = new Student();
            obj.id = 4444;
            obj.name = "Vicky list";
            obj.institute = "Punjab collete.list";

            List<Student> objlist = new List<Student>();
            objlist.Add(obj);
            return View(objlist.ToList());
        }
        
        public IActionResult studlistst()
        {
            List<string> dat = new List<string>();
            dat.Add("Shah jahna");
            dat.Add("Vicky");
            dat.Add("Usman");
            ViewBag.stdd = dat;
            return View();
        }
        public IActionResult stdDeligation( string id,int roll)
        {
            ViewBag.Id = id;
            ViewBag.Roll = roll;
            return View();
        }
        public IActionResult index()
        {
            return View();

        }
    }
}