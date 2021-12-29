using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosApp.Models
{
    public class Pozymis : Entity
    {
        public Reiksme Reiksme { get; set; }
        public int ReiksmeId { get; set; }
    }
}
