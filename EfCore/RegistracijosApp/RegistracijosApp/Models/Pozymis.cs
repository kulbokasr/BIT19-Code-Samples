using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosApp.Models
{
    public class Pozymis : Entity
    { 
        public List<Reiksme> Reiksmes { get; set; }
        public int ReiksmeId { get; set; } = 0;
    }
}
