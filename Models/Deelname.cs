using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Models;

namespace Models {
    public class Deelname {
        public int Id {get; set;}
        public DateTime Toetredingsdatum {get; set;}
        public Boolean Geblokkeerd {get; set;}
        public Chat Chat {get; set;}
        public Gebruiker Client {get; set;}
        public ICollection<Bericht> Berichten {get; set;}

        [NotMapped]
        public int AantalBerichtenVerstuurd { get {
            return Berichten.Count();
            }
        }
    }
}