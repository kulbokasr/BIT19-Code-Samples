using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProject.Models
{
    public class Application
    {
        [Required]
        public int CreditAmount { get; set; }
        [Required]
        public int Term { get; set; }
        [Required]
        public int CurrentCreditAmount { get; set; }
    }
}
