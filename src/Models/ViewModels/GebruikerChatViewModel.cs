using System;
using System.Collections.Generic;
using System.Linq;
using Models;

public class GebruikerChatViewModel {
    public DateTime Geboortedatum {get; set;}
    public string Id {get; set;}
    public string UserName {get; set;}
    public string Email {get; set;}
    public string PhoneNumber {get; set;}

    public bool IsMinderjarig {get; set;}

    public ICollection<Chat> Chats {get; set;}

    public ICollection<Deelname> Deelnames {get; set;}
    
    public int ChatsVerstuurdDoorVerzender(Chat chat) {
       return chat.Berichten.Count(b => b.Deelname.Client.Id == Id);
    }
    public int ChatFrequentie(Chat chat) {
        return chat.Berichten.Count();
    }

    public DateTime LaatsteBerichtDatum(Chat chat) {
        return chat.Berichten.Last().Datum;
    }

    public GebruikerChatViewModel(Gebruiker gebruiker) {
        Id = gebruiker.Id;
        Geboortedatum = gebruiker.Geboortedatum;
        UserName = gebruiker.UserName;
        Email = gebruiker.Email;
        PhoneNumber = gebruiker.PhoneNumber;
        Chats = gebruiker.Chats;
        Deelnames = gebruiker.Deelnames;
        IsMinderjarig = gebruiker.IsMinderjarig();
    }
}