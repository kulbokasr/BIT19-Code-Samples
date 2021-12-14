using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zoo.Models;
using Zoo.Services;

namespace Zoo.Controllers
{
    public class SponsorController : Controller
    {
        private readonly SponsorsService _sponsorService;
        // GET: SponsorController

        public SponsorController(SponsorsService sponsorService)
        {
            _sponsorService = sponsorService;
        }

        public ActionResult Index()
        {
            var result = _sponsorService.ReadFromDB();
            return View("Sponsor", result);
        }

        public ActionResult DisplaySubmitData()  // jo... sakau kazkas ne to. tai cia.
        {
            var emptyModel = new SponsorModel();
            emptyModel.Animals = _sponsorService.animals(); // sponsor service grazina cia animal list. tikrinam.
            //tusias objektas sponsor su uzpildytu animals masyvu
            return View(emptyModel);//ir ji paduodi. td veiks. bandyk
        }

        public ActionResult SendSubmitData(SponsorModel model)
        {
            _sponsorService.AddToDB(model); 
            return RedirectToAction("Index");// cia gal geriau nuukreipti i lista. kai idedi, grizti i sarasa, nes kai grizti i idejima, atdoro, kad neidejai o kazkas suluzo puslapy. nebent turetum success message, bet cia razor tai... kreipk i index.
          }

        // GET: SponsorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SponsorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SponsorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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

        // GET: SponsorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SponsorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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

        // GET: SponsorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SponsorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
