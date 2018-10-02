using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.TeamProfilePageData
{
    public class PlayerDataModel
    {

        public class Handedness
        {
            public object Throws { get; set; }
        }

        public class ExternalMapping
        {
            public string Source { get; set; }
            public string ID { get; set; }
        }

        public class Player
        {
            public string ID { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string JerseyNumber { get; set; }
            public string Position { get; set; }
            public string Height { get; set; }
            public string Weight { get; set; }
            public string BirthDate { get; set; }
            public string Age { get; set; }
            public string BirthCity { get; set; }
            public string BirthCountry { get; set; }
            public string IsRookie { get; set; }
            public object HighSchool { get; set; }
            public object College { get; set; }
            public object Twitter { get; set; }
            public string RosterStatus { get; set; }
            public Handedness handedness { get; set; }
            public object draft { get; set; }
            public object currentContractYear { get; set; }
            public string officialImageSrc { get; set; }
            public ExternalMapping externalMapping { get; set; }
        }

        public class Team
        {
            public string ID { get; set; }
            public string City { get; set; }
            public string Name { get; set; }
            public string Abbreviation { get; set; }
        }

        public class Playerentry
        {
            public Player player { get; set; }
            public Team team { get; set; }
        }

        public class Activeplayers
        {
            public string lastUpdatedOn { get; set; }
            public List<Playerentry> playerentry { get; set; }
        }

        public class RootObject
        {
            public Activeplayers activeplayers { get; set; }
        }

    }
}
