using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Intro.Models;

namespace MVC_Intro.Controllers
{
    public class MIS3033Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult StudentOfTheYear()
        {
            Student soty = new Student()
            {
                FirstName = "Zareen",
                LastName = "Khan"
            };
            return View(soty);
        }

    }
}
