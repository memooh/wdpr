using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Models {
    public class Chat: IChat {
        public int Id {get; set;}
        public string Naam {get; set;}
        public bool Actief {get; set;}

    #nullable enable
        public Gebruiker ?Behandelaar {get; set;}
    #nullable disable

        public ICollection<Bericht> Berichten { get; set; }
        public ICollection<Deelname> Deelnames { get; set; }

    
    #nullable enable
        public int ?ZelfhulpgroepInt {get; set;}
    #nullable disable
    
        public Zelfhulpgroep Zelfhulpgroep {get; set;}

        public string ChatNaam(Gebruiker gebruiker)
        {
            if (ZelfhulpgroepInt == null)
            {
                if(Behandelaar != gebruiker) 
                    return "Chat met " + Behandelaar.Email;
                
            }
            return Naam;
        }

        public string ChatNaamGlobaal()
        {
            if (ZelfhulpgroepInt != null) {
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