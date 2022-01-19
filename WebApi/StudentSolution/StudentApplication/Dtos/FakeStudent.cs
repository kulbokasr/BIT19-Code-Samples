using StudentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Dtos
{
    public class FakeStudent : NamedEntity
    {
        public string Sex { get; set; }
        public int SchoolId { get; set; }
    }
}
