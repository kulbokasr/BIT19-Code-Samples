using FirstMvcApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcApplication.Controllers
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
            // C# backend logic is here
            return View();
        }
        public IActionResult Aboutme()
        {
            var personModel = new PersonModel()
            {
                Name = "Ramunas Kulbokas"
            };
            
            return View(personModel);
        }
        // Display a page with the form
        public IActionResult DisplaySubmitData()
        {
            var emptyModel = new PersonModel()
            {
                Name = "Fill me"
            };
            return View(emptyModel);
        }

        // will receive filled model and will save to file
        public IActionResult SendSubmitData(PersonModel model)
        {
            System.IO.File.WriteAllText("test.txt", model.Name);
            return RedirectToAction("DisplaySubmitData");
                
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
    }
}
