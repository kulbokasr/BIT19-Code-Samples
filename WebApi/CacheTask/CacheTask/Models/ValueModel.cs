using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheTask.Models
{
    public class ValueModel
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string KeyModelKey { get; set; }
    }
}
