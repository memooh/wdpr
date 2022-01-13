using System;

namespace Models {
    public class ZelfhulpDeelname {
        public int Id { get; set; }
        public DateTime Toetredingsdatum { get; set; }
        public Zelfhulpgroep Zelfhulpgroep {get; set;}
        public Gebruiker Client {get; set;}
    }
}