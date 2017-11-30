using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthApi.Models
{
    public class HubUser
    {
        private UserAccount UserAccount { get; set; }
        public string ConnectionId { get; set; }
    }
}