using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, string group)
        {
            await Clients.Group(group).SendAsync("ReceiveMessage", user, message).ConfigureAwait(true);
        }

        public void AddToGroup(string Chat)
        {
            if(Chat != null) {
                Groups.AddToGroupAsync(Context.ConnectionId, Chat);
            }
        }
        
        public void RemoveFromGroup(string Chat)
        {
            if(Chat != null) {
                Groups.RemoveFromGroupAsync(Context.ConnectionId, Chat);
            }
        }
    }
}