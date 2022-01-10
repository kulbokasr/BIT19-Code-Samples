using CleanHotelWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanHotelWebApplication.Dtos
{
    public class HotelRoom
    {
        public List<Hotel> Hotels { get; set; }
        public List<Room> Rooms { get; set;}
    }
}
