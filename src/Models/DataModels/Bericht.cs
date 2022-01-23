using System;
using System.Collections.Generic;

namespace Models {
    public class Bericht: IBericht {
        public int Id {get; set;}
        public string Beschrijving {get; set;}
        public DateTime Datum { get; set; }
        public Deelname Deelname {get; set;}
        public Chat Chat { get; set; }
        public ICollection<Melding> Meldingen {get; set;}
    }
}