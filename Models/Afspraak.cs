using System;

namespace Models {
    public class Afspraak {
        public int Id {get; set;}
        public DateTime Datum {get; set;}
        public Behandeling Behandeling {get; set;}
        public Gebruiker Behandelaar {get; set;}
        public Gebruiker Client {get; set;}
    }
}