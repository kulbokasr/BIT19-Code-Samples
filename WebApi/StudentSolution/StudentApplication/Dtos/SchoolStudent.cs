using StudentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Dtos
{
    public class SchoolStudent
    {
        public List<Student> Students { get; set; }
        public List<School> Schools { get; set; }
        public School School { get; set; }
        public Student Student { get; set; }
    }
}
