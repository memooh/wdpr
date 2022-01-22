using System.Collections.Generic;

namespace Models {
    public class Zelfhulpgroep {
        public int Id {get; set;}
        public string Naam { get; set; }
        public ICollection<ZelfhulpDeelname> ZelfhulpDeelnames {get; set;}
        public Chat Chat {get; set;}
    }
}