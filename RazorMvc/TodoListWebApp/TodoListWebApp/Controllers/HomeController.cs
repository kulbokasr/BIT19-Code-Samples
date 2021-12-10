using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TodoListWebApp.Models;
using TodoListWebApp.Services;

namespace TodoListWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataService _dataService; 
        private readonly DataService1 _dataService1;

        public HomeController(ILogger<HomeController> logger, DataService dataService, DataService1 dataService1)
        {
            _logger = logger;
            _dataService = dataService;
            _dataService1 = dataService1;
        }
        // Display a page with the form
        public IActionResult DisplaySubmitData()
        {
            var emptyModel = new TasksModel()
            {
                Name = "Fill in task name",
                Description = "Fill in task description"
            };
            return View(emptyModel);
        }
        public IActionResult SendSubmitData(TasksModel model)
        {
            if(model.Name == null & model.Description == null)
            {    
                return RedirectToAction("DisplaySubmitData");
            }
            else
            {
                _dataService.Add(model); 
                return RedirectToAction("DisplaySubmitData");
            }
        }

        public IActionResult SendSubmitDataList()
        {
            //  string[] lines = System.IO.File.ReadAllLines(@"C:\Users\kulbo\projects\.Net-Course\RazorMvc\TodoListWebApp\test.txt");
            var logFile = System.IO.File.ReadAllLines(@"C:\Users\kulbo\projects\.Net-Course\RazorMvc\TodoListWebApp\test.txt");
            var logList = new List<string>(logFile);
            return RedirectToAction("DisplaySubmitData");

        }


        public IActionResult TasksList()
        {
         var tasks = _dataService.GetAll();
       
         var tasksList = new TasksListModel()
            {
                Tasks = tasks
            };
            return View(tasksList);
        }
        public IActionResult Index()
        {
            // C# backend logic is here
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
