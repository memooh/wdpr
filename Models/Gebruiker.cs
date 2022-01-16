using System;
using Microsoft.AspNetCore.Identity;

namespace Models {
    public class Gebruiker: IdentityUser {
        public DateTime Geboortedatum {get; set;}
        public Gebruiker Voogd {get; set;}
    }
}