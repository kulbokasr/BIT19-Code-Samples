﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsgardMarketplace.Domain.Dtos
{
    public class CreateOrder
    {
        public int UserId { get; set; }
        public int ItemId { get; set; }
    }
}
