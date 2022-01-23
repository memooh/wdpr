using System.Collections.Generic;

namespace Models {
    public class Zelfhulpgroep: IZelfhulpgroep {
        public int Id {get; set;}
        public string Naam { get; set; }
        public ICollection<ZelfhulpDeelname> ZelfhulpDeelnames {get; set;}
        public Chat Chat {get; set;}
        public string Description { get; set;}
        public string avgLeeftijd {get; set;}
    }
}