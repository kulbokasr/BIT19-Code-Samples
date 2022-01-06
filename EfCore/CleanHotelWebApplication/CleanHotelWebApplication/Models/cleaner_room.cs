using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanHotelWebApplication.Models
{
    public class Cleaner_Room
    {
        public int Room_Id { get; set; }
        public int Cleaner_Id { get; set; }
        public bool Cleaned { get; set; }
        public Room Room { get; set; }
        public Cleaner Cleaner { get; set; }   
    }
}
