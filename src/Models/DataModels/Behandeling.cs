using System.Collections.Generic;

namespace Models {
    public class Behandeling : IBehandeling {
        public int Id {get; set;}
        public string Naam {get; set;}
        public ICollection<Behandeld> Behandelaren {get; set;}
    }
}