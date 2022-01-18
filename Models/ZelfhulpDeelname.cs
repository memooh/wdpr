using System;
using Microsoft.AspNetCore.Identity;

namespace Models {
    public class ZelfhulpDeelname {
        public int Id { get; set; }
        public DateTime Toetredingsdatum { get; set; }
        public int ZelfhulpgroepId {get; set;}
        public Zelfhulpgroep Zelfhulpgroep {get; set;}
        public IdentityUser Client {get; set;}


    }
}