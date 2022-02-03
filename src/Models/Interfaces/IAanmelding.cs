using System;
using Models;

public interface IAanmelding {
        public int Id { get; set; }
        public DateTime Datum {get; set;}
        public string Email {get; set;}
        public string Voornaam {get; set;}
        public string Achternaam {get; set;}
        public DateTime GeboorteDatum {get; set;}    
    #nullable enable
        public Gebruiker? Voogd { get; set;}
    #nullable disable

        public Gebruiker Behandelaar { get; set;}

        public bool HeeftAccount {get; set;}

        public string GenereerWachtwoord() {
            return Voornaam.Substring(0,1).ToUpper() + Achternaam.ToLower() + 2022 + "!"; 
        }
}