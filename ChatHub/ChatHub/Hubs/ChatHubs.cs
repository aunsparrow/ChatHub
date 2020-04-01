using ChatHub.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHub.Hubs
{
    public class ChatHubs : Hub
    {
        public async Task SendMassage(Massage massage) =>
            await Clients.All.SendAsync("receiveMassage", massage);
    }
}
