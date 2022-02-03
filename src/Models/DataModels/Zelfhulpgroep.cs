using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models {
    public class Zelfhulpgroep: IZelfhulpgroep {
        public int Id {get; set;}

        [Display(Name = "Naam")]
        public string Naam { get; set; }
        public ICollection<ZelfhulpDeelname> ZelfhulpDeelnames {get; set;}
        public Chat Chat {get; set;}

        [Display(Name = "Beschrijving")]
        public string Description { get; set;}

        [Display(Name = "Gemiddelde leeftijd")]
        public string avgLeeftijd {get; set;}
    }
}