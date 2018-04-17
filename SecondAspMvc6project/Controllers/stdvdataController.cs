using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SecondAspMvc6project.Controllers
{
    public class stdvdataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}