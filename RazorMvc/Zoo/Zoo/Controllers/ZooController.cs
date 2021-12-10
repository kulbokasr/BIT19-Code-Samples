using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        // POST: ZooController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ZooController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZooController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
