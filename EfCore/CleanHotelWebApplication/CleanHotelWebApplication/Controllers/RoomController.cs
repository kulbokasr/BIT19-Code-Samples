using CleanHotelWebApplication.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanHotelWebApplication.Controllers
{
    public class RoomController : Controller
    {
        private DataContext _context;

        public RoomController(DataContext context)
        {
            _context = context;
        }
        public IActionResult BookRoom(int id)
        {
            var room = _context.Rooms.Find(id);
            room.Booked = true;
            _context.Rooms.Update(room);
            _context.SaveChanges();
            return RedirectToAction("Index", "Hotel");
            
        }
    }
}
