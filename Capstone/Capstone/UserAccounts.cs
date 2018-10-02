using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class UserAccounts
    {

        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        public string Username { get; set; }

        public string  Password { get; set; }

        public string FavoriteTeam { get; set; }
    }
}
