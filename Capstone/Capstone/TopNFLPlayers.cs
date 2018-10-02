using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class TopNFLPlayers
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }
    }
}
