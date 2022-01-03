using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistracijosApp.Data;
using RegistracijosApp.Dtos;
using RegistracijosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosApp.Controllers
{
    public class PozymisController : Controller
    {
        private DataContext _context;

        public PozymisController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var createPozymis = new CreatePozymis()
            {
                Pozymis = new Pozymis()
                {
                    Id = 0,
                    Name = "",
                    ReiksmeId = 0,
                   
                },
                PozymisList = _context.Pozymiai.ToList(),
                RegQandAList = _context.Registracijos.ToList(),


            };

            //List<Pozymis> pozymiai = new List<Pozymis>();
            //pozymiai = _context.Pozymiai.ToList();
            //foreach (var pozymis in pozymiai)
            //{
            //    pozymis.Reiksmes = _context.Reiksmes.Where(a => a.PozymisId == pozymis.Id).ToList();
            //}

            foreach (var pozymis in createPozymis.PozymisList)
            {
                pozymis.Reiksmes = _context.Reiksmes.Where(a => a.PozymisId == pozymis.Id).ToList();
            }

            return View(createPozymis);
        }

        [HttpPost]
        public IActionResult Index(CreatePozymis createPozymis)
        {
            List<Pozymis> pozymiai = new List<Pozymis>();
            pozymiai = _context.Pozymiai.ToList();
            for (int i = 0; i < pozymiai.Count; i++)
            {
                pozymiai[i].ReiksmeId = createPozymis.PozymisList[i].ReiksmeId;
            }

                _context.Pozymiai.UpdateRange(pozymiai);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
