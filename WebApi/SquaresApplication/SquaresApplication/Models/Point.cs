using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresApplication.Models
{
    public class Point
    {
        [Range(-5000, 5000)]
        public int X { get; set; }
        [Range(-5000, 5000)]
        public int Y { get; set; }
        
    }
}
