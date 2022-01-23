using System;

namespace Models {
    public class Aanmelding {
        public int Id { get; set; }
        public DateTime Datum {get; set;}
        public string Gebruikersnaam {get; set;}
        public string Voornaam {get; set;}
        public string Achternaam {get; set;}
        public DateTime GeboorteDatum {get; set;}
        public Gebruiker? Voogd { get; set;}
        public Gebruiker Behandelaar { get; set;}

        public bool HeeftAccount {get; set;}

        public string GenereerWachtwoord() {
            return Voornaam.Substring(0,1).ToUpper() + Achternaam.ToLower() + 2022 + "!"; 
        }
    }
}