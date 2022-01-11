using System;
using System.ComponentModel.DataAnnotations;

namespace wdpr
{

    public class Gebruiker
    {
        [Key]
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string VolledigeNaam { get;}
        public int Leeftijd { get; set; }
        public bool Moderator { get; set; }
        public bool Orthopedagoog { get; set; }
        public bool Client { get; set; }
        public bool Stagair { get; set; }
        public bool Administratie { get; set; }
    }
}
