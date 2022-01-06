using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanHotelWebApplication.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public int HotelId { get; set; }
        public bool Booked { get; set; }
        public Hotel Hotel { get; set; }
        public List<Cleaner> Cleaners { get;}
    }
}
