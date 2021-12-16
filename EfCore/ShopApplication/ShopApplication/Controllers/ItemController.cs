using Microsoft.AspNetCore.Mvc;
using ShopApplication.Data;
using ShopApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopApplication.Controllers
{
    public class ItemController : Controller
    {
        private DataContext _context;

        public ItemController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //item list atiduoda item controlleris. cia turi atiduoti parduotuves, ne itemus. jei labai nori galima:
            //cia parduotuves paimi, ju sarasa ir jas atvaizduoji. kai paspausi ant jos, tada uzeisi i vidu. ir gausi sarasa is:
            //ItemController, kuris uzkraus TOS KONKRECIOS parduotuves prekiu sarasa, ir atvaizduos.. item/Index.chtml
            List<Item> items = new List<Item>();
            items = _context.Items.ToList();
            return View(items);
        }
        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();
            items = _context.Items.ToList();
            return items;
        }
    }
}
