﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondAspMvc6project.Models;

namespace SecondAspMvc6project.Controllers
{
    public class stdvdataController : Controller
    {
        public IActionResult StudentViewData()
        {
            Student std = new Student()
            { id=123,
            name="VIEWDATA",
            subject="COMPUTER SCIENCE"

            };
            ViewData["vdStd"] = std;

            return View(std);

        }
        public IActionResult StudentTempdata()
        {
            TempData["Name"] = "This Tempdata show";
            return RedirectToAction ("StudentViewData");
          
        }


    }
}