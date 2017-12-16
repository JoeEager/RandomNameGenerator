using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RandomNameWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This web application can be used to generate random names based off the github project";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "https://github.com/JoeEager/RandomNameGenerator";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
