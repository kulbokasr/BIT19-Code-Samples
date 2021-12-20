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

        [HttpGet]
        public IActionResult AddItem()
        {
            var item = new Item();
            item.Shops = _context.Shops.ToList();
            return View(item);
        }
        [HttpPost]
        public IActionResult AddItem(Item item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            _context.Items.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index", "Shop");
        }

        public IActionResult DeleteItem(int id)
        {
            var item = _context.Items.Find(id);
            _context.Items.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Index", "Shop");
        }

        public IActionResult UpdateItem(int id)
        {
            var item = _context.Items.Find(id);
            return View(item);
        }
        [HttpPost]
        public IActionResult UpdateItem(Item item)
        {
            _context.Items.Update(item);
            _context.SaveChanges();
            return RedirectToAction("Index", "Shop");
        }


    }
}
