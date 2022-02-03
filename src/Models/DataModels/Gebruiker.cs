using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Models {
    public class Gebruiker: IdentityUser {
       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Geboortedatum {get; set;}

    #nullable enable
        public Gebruiker? Behandelaar {get; set;}
        public virtual List<Gebruiker> Clienten {get;} = new List<Gebruiker>();
        public Gebruiker? Voogd {get; set;}
        public string? VoogdId {get; set;}

        public string? Beschrijving {get; set;}

        public string? Afbeelding {get; set;}
    #nullable disable
        public virtual List<Gebruiker> Voogdij {get;} = new List<Gebruiker>();

        public ICollection<Chat> Chats {get; set;}
        public ICollection<Deelname> Deelnames {get; set;}
        public ICollection<Behandeld> Behandelingen {get; set;}

        public string Voornaam {get; set;}
        public string Achternaam {get; set;}       
        public string Adres {get; set;}
        public string Postcode {get; set;}
        public string Woonplaats {get; set;}
        public bool IsActief {get; set;}

        public bool IsMinderjarig() {
            int age = 0;  
            age = DateTime.Now.AddYears(-Geboortedatum.Year).Year;  
            return age < 16;  
        }

        public string GenereerWachtwoord() {
            return Voornaam.Substring(0,1).ToUpper() + Achternaam.ToLower() + 2022 + "!"; 
        }
    }
}