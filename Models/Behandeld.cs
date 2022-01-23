using System.Collections.Generic;
using Models;

public class Behandeld {    
    public int Id { get; set; }
    public Behandeling Behandeling {get; set;}
    public Gebruiker Behandelaar {get; set;}
}