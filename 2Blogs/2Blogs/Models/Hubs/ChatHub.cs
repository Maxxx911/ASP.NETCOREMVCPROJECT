using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace _2Blogs.Models.Hubs
{
    public class ChatHub : Hub
    {
        private UserManager<ApplicationUser> _userManager;
        public ChatHub(UserManager<ApplicationUser> usr)
        {
            _userManager = usr;
        }
        [Authorize(Roles = "admin, user")]
        public async Task Send(string message)
        {
            var user = Context.User.Identity.Name;
           
            await this.Clients.All.SendAsync("Send", message, user);
        }
    }
}
