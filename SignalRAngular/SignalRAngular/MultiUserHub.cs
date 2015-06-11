using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRAngular
{
    [HubName("chat")]
    public class MultiUserHub : Hub
    {
        public void SendMessage(string message)
        {
            Clients.All.newMessage(message);
        }
    }
}