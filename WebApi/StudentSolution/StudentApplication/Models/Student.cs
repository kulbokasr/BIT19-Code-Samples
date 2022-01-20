using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Models
{
    public class Student : NamedEntity
    {
        public int SexId { get; set; }
        public Sex Sex { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}
