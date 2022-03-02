using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VintedConsoleApp.Models
{
    public class PricingModel
    {
        public string Provider { get; set; }
        public string PackageSize { get; set; }
        public decimal Price { get; set; }
        public DateOnly Date { get; set; }
    }
}
