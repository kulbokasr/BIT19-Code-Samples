using System.Collections.Generic;

namespace RegistracijosApp.Models
{
    public class RegQandA
    {
        public int Id { get; set; }
        public int RegId { get; set; }
        public int ReiksmeId { get; set; }
        public int PozymisId { get; set; }
        public Reiksme Reiksme { get; set; }
        public Pozymis Pozymis { get; set; }
        
    }
}
