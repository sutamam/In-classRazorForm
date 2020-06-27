using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using In_classRazorForm.Models;
using InClassCS3.Models;

namespace In_classRazorForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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

        public IActionResult InputNameState(string name, string state)
        {
            //Setting Data in Model
            var inp = new input() { name = name, state = state };

            //The navigated page will retrieve data from model (input)
            ViewBag.explaination = "Welcome " + inp.name + " to the state of " + inp.state;

            return View();
        }
    }
}
