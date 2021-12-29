using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistracijosApp.Data;
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
            List<Pozymis> pozymiai = new List<Pozymis>();
            pozymiai = _context.Pozymiai/*.Include(c => c.Reiksmes)*/.ToList();
            foreach (var pozymis in pozymiai)
            {
                pozymis.Reiksmes = _context.Reiksmes.Where(a => a.PozymisId == pozymis.Id).ToList();
            }
            return View(pozymiai);
        }
    }
}
