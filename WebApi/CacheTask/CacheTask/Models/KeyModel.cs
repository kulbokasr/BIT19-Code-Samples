using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheTask.Models
{
    public class KeyModel
    {
        [Key]
        public string Key { get; set; }
        public List<ValueModel> Values { get; set; }
    }
}
