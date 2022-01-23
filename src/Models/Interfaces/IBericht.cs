using System;
using System.Collections.Generic;
using Models;

public interface IBericht {
        public int Id {get; set;}
        public string Beschrijving {get; set;}
        public DateTime Datum { get; set; }
        public Deelname Deelname {get; set;}
        public Chat Chat { get; set; }
        public ICollection<Melding> Meldingen {get; set;}
}