using Homework_15.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_15.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private Fish[] fishArray = new Fish[]

               {
                new Fish("Plotva", 12, 35),
                new Fish("Karas", 4, 12),
                new Fish("Shuka", 30, 45)
            };

        
        public IActionResult ViewDataPage()
        {
            
            foreach (var fish in fishArray)
            {
                ViewData["Fish"] += fish.ToFishString();
            }

          
            return View();
        }

        public IActionResult ViewBagPage()
        {
            ViewBag.Fish = fishArray;
            return View();
        }


        public IActionResult ViewModelPage()
        {
            ViewData["Name"] = "Karp";
            ViewBag.Weight = 10;
            return View(fishArray);
        }

        #region default
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #endregion
    }
}
