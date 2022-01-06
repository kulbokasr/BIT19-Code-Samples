﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanHotelWebApplication.Models
{
    public class Cleaner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
        public List<Room> Rooms { get; set; }

    }
}
