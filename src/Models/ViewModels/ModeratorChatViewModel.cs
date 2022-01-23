using System.Collections.Generic;
using Models;

public class ModeratorChatViewModel {
    private List<Chat> Chats {get; set;}
    public ModeratorChatViewModel(List<Chat> chats) {
        Chats = chats;
    }
}