using System;
using Models;

namespace Models {
    public class Deelname {
        public int Id {get; set;}
        public DateTime Toetredingsdatum {get; set;}
        public Chat Chat {get; set;}
        public Gebruiker Client {get; set;}
    }
}