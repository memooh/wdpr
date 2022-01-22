using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Models {
    public class Gebruiker: IdentityUser {
        public DateTime Geboortedatum {get; set;}
        public Gebruiker Voogd {get; set;}
        public ICollection<Gebruiker> Voogdij {get; set;}
        public ICollection<Chat> Chats {get; set;}
        public ICollection<Deelname> Deelnames {get; set;}
        public ICollection<Behandeld> Behandelingen {get; set;}


        public bool IsMinderjarig() {
            int age = 0;  
            age = DateTime.Now.AddYears(-Geboortedatum.Year).Year;  
            return age < 16;  
        }
    }
}