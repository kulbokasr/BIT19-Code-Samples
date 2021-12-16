using Microsoft.AspNetCore.Mvc;
using ShopApplication.Data;
using ShopApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopApplication.Controllers
{
    public class ShopController : Controller
    {
        private DataContext _context;

        public ShopController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Item> items = new List<Item>();
            items = _context.Items.ToList();
            Shop shop = new Shop();
            foreach (Item item in items) { item.Shop = shop; };
            foreach (Item item in items) { item.Shop.Name = _context.Shops.Where(c => c.Id == item.ShopId)};
            return View(items);
        }

    }
}
