using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProject.Models
{
    public class Application
    {
        public int CreditAmount { get; set; }
        public int Term { get; set; }
        public int CurrentCreditAmount { get; set; }
    }
}
