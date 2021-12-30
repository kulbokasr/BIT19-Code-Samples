using RegistracijosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosApp.Dtos
{
    public class CreatePozymis
    {
        public Pozymis Pozymis { get; set; }
        public List<Pozymis> PozymisList { get; set; }
    }
}
