using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Models
{
    public class Gebruiker : IdentityUser
    {
        public DateTime Geboortedatum { get; set; }
        public Gebruiker Voogd { get; set; }

        public string? BehandelaarId {get; set;}

        public Gebruiker Behandelaar {get; set;}
        public virtual List<Gebruiker> Clienten {get;} = new List<Gebruiker>();


    }
}