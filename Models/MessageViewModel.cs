using System;
using System.Collections.Generic;
using Models;

public class MessageViewModel {
    
    public string Beschrijving {get; set;}
    public DateTime Datum {get; set;}
    public string Verzender {get; set;}
    public bool IsVerzender {get; set;}
    public int BerichtId {get; set;}
    public MessageViewModel (Bericht Bericht, Gebruiker IngelogdeGebruiker ) {
        Beschrijving = Bericht.Beschrijving;
        Datum = Bericht.Datum;
        Verzender = Bericht.Deelname.Client.Email;
        IsVerzender = Bericht.Deelname.Client.Id == IngelogdeGebruiker.Id;
        BerichtId = Bericht.Id;
    } 
}