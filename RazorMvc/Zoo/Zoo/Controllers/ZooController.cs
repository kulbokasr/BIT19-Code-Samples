using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Zoo.Models;
using Zoo.Services;

namespace Zoo.Controllers
{
    public class ZooController : Controller
    {
        private readonly ZooService _zooService; //cia kontrolerio klaseje susikuri to serviso objekta tuscia.
       
        // GET: ZooController

        public ZooController(ZooService zooService) //konstruktorius priima sservice objekta ir priskiria tam kitnamajam kur auksciau sukurei
        {
            _zooService = zooService; //TADA tu jį gali laisvai naudoti bet kuriam metode.
        }
        public ActionResult Index()
        {
            //tada cia naudosi serviso objekta, kad pasiekti metoda kuris yra service klaseje. metoda getAll pvz()
           var result = _zooService.ReadFromDB();
            return View("Zoo", result);
        }

        public ActionResult DisplaySubmitData()
        {
            //var emptyModel = new ZooModel()
            //{
            //    Name = "Name",
            //    Description = "Description",
            //    Age = 4,
            //    Gender = "Gender"
            //};
            return View(/*emptyModel*/);
        }


        // will receive filled model and will save to file
        public  ActionResult SendSubmitData(ZooModel model)
        {
            _zooService.AddToDB(model);
            return RedirectToAction("DisplaySubmitData");
        }
        
        public ActionResult Delete( int Id)
        {
            _zooService.DeleteAnimal(Id); 
            return RedirectToAction("Index");
        }


        // GET: ZooController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZooController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZooController/Create
        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: ZooController/Edit/5
        public ActionResult Edit(int id) 
        {
            var result = _zooService.ReadFromDBById(id);
            return View("ZooEdit", result); 
        }

        // POST: ZooController/Edit/5  
        [HttpPost]
        public ActionResult Edit(ZooModel animal) 
            
        {
            _zooService.Edit(animal, animal.Id);
            return RedirectToAction("Index");

        }


    }
}
