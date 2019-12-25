using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.signalr.hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.  
            //Clients.All.broadcastMessage(name, message);
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}