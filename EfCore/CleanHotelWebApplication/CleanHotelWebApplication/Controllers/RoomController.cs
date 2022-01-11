using CleanHotelWebApplication.Data;
using CleanHotelWebApplication.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [HttpGet]
        public IActionResult AddRoom()
        {
            var hotelRoom = new HotelRoom()
            {
                Hotels = _context.Hotels.Include(i => i.RoomsList).ToList(),
                Rooms = _context.Rooms.ToList()

            };
            return View(hotelRoom);
        }
        [HttpPost]
        public IActionResult AddRoom(HotelRoom hotelRoom)
        {
            _context.Rooms.Add(hotelRoom.Room);
            _context.SaveChanges();
            return RedirectToAction("Index", "Hotel");
        }

        public IActionResult EditRoom(int id)
        {
            var hotelRoom = new HotelRoom()
            {
                Hotels = _context.Hotels.Include(i => i.RoomsList).ToList(),
                Rooms = _context.Rooms.ToList(),
                TrueFalse =  new List<Models.BookedDropDown>() { 
                    new Models.BookedDropDown { Value = "true", Text = "Yes" }, 
                    new Models.BookedDropDown { Value = "false", Text = "No" } 
                },

                Room = _context.Rooms.Find(id)

            };
            return View(hotelRoom);

        }
        [HttpPost]
        public IActionResult EditRoom(HotelRoom hotelRoom)
        {
            _context.Rooms.Update(hotelRoom.Room);
            _context.SaveChanges();
            return RedirectToAction("ListRooms");
        }
        public IActionResult ListRooms()
        {
            var rooms = _context.Rooms.ToList();
            return View(rooms);
        }

    }
}
