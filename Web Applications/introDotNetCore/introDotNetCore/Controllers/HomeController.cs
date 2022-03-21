using introDotNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 42;
            ViewBag.Name = "Türkay";
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        } 

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks");
            }
           
            return View();
        }
    }
}
