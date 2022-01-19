using StudentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Dtos
{
    public class FakeSchool : NamedEntity
    {
        public List<FakeStudent> Students { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;

    }
}
