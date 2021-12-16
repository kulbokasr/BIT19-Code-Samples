using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            List<Shop> shops = new List<Shop>();
            shops = _context.Shops.Include(c => c.Items).ToList();
            return View(shops);
        }

    }
}
