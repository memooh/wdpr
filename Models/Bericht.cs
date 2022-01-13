using System;

namespace Models {
    public class Bericht {
        public int Id {get; set;}
        public string Beschrijving {get; set;}
        public DateTime Datum { get; set; }
        public Gebruiker Verzender {get; set;}
        public Chat Chat { get; set; }
    }
}