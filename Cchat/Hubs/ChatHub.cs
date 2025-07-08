using Microsoft.AspNetCore.SignalR;

namespace Cchat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string usr, string mssg)
        {
            await Clients.All.SendAsync("ReceiveMessage", usr, mssg);
        }
    }
}