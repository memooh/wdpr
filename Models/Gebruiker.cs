using System;

namespace Models {
    public class Gebruiker {
        public int Id {get; set;}
        public string Gebruikersnaam  {get; set;}
        public string Wachtwoord {get; set;}
        public string Email {get; set;}
        public DateTime Geboortedatum {get; set;}
        public Gebruiker Voogd {get; set;}
    }
}