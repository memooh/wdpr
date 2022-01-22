using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Models;

public class ChatViewModel {

    public List<Deelname> Deelnames {get; set;}
    public UserManager<Gebruiker> UserManager {get; set;}
    public Gebruiker Gebruiker {get; set;}
    public ChatViewModel(List<Deelname> deelnames, UserManager<Gebruiker> userManager, Gebruiker gebruiker) {
        Deelnames = deelnames;
        UserManager = userManager;
        Gebruiker = gebruiker;
    }
}