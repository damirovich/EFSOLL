using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _003ASPAdvancedTask1.Hubs
{
    public class CounterHub:Hub
    {
        private static int Counter=0;

        public override Task OnConnectedAsync()
        {
            Counter++;
            base.OnConnectedAsync();
            this.Clients.All.SendAsync("updateCounter", Counter);
            return Task.CompletedTask;
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            Counter--;
            base.OnDisconnectedAsync(exception);
            this.Clients.All.SendAsync("updateCounter", Counter);
            return Task.CompletedTask;
        }
    }
}
