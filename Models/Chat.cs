using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Models {
    public class Chat {
        public int Id {get; set;}
        public string Naam {get; set;}
        public bool Actief {get; set;}
        public Gebruiker ?Behandelaar {get; set;}
        public ICollection<Bericht> Berichten { get; set; }
        public ICollection<Deelname> Deelnames { get; set; }
        public int ?ZelfhulpgroepInt {get; set;}
        public Zelfhulpgroep Zelfhulpgroep {get; set;}

        public string ChatNaam(Gebruiker gebruiker)
        {
            Console.WriteLine(Deelnames.Count());
            if (Zelfhulpgroep == null)
            {
                if(Behandelaar != gebruiker) 
                    return "Chat met " + Behandelaar.Email;
                
            }
            return Naam;
        }

        public string ChatNaamGlobaal()
        {
            if (Zelfhulpgroep != null) {
                return Zelfhulpgroep.Naam;
            }
            else if (Deelnames.Count() == 1) {
                return "Chat tussen " + Behandelaar.Email + " en " + Deelnames.First().Client.Email;
            }
            else {
                return Naam;
            }
        }
    }
}