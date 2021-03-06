using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Models
{
    public class NamedEntity
    {
        public int Id { get; set; }
        [Required] [MinLength(4)]
        public string Name { get; set; }
    }
}
