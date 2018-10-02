using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static Capstone.TeamProfilePageData.PlayerDataModel;
using static Capstone.TeamProfilePageData.PlayerStatsModel;

namespace Capstone.TeamProfilePageData
{
    public class PlayerStatsModel
    {
        public class Player
        {
            [JsonProperty("ID")]
            public string Id { get; set; }

            [JsonProperty("LastName")]
            public string LastName { get; set; }

            [JsonProperty("FirstName")]
            public string FirstName { get; set; }

            [JsonProperty("JerseyNumber")]
            public string JerseyNumber { get; set; }

            [JsonProperty("Position")]
            public string Position { get; set; }
        }

        public class Team
        {
            [JsonProperty("ID")]
            public string Id { get; set; }

            [JsonProperty("City")]
            public string City { get; set; }

            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("Abbreviation")]
            public string Abbreviation { get; set; }
        }

        public class GamesPlayed
        {
            [JsonProperty("@abbreviation")]
            public string Abbreviation { get; set; }

            [JsonProperty("#text")]
            public string Text { get; set; }
        }

        public class PassAttempts
        {
            public string category { get; set; }

            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PassCompletions
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PassPct
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }


        public class PassYards
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PassAvg
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PassYardsPerAtt
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
         }

        public class PassTD
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PassTDPct
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PassInt
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PassIntPct
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PassLng
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Pass20Plus
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Pass40Plus
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PassSacks
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PassSackY
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class QBRating
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class RushAttempts
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class RushYards
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class RushAverage
        {
            public string category { get; set; }
            public string abbreviation { get; set; }
            public string text { get; set; }
        }


        public class RushTD
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class RushLng
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Rush1stDowns
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string  abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Rush1stDownsPct
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Rush20Plus
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Rush40Plus
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }


        public class RushFumbles
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Targets
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Receptions
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            public string text { get; set; }
        }

        public class RecYards
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class RecAverage
        {
            public string _category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string _text { get; set; }
          }

        public class RecTD
        {
            public string category { get; set; }

            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class RecLng
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Rec1stDowns
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Rec20Plus
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Rec40Plus
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class RecFumbles
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class TackleSolo
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class TackleTotal
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class TackleAst
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }

        }

        public class Sacks
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class SackYds
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Safeties
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class TacklesForLoss
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Interceptions
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class IntTD
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class IntYds
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class IntAverage
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class IntLng
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PassesDefended
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Stuffs
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class StuffYds
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

       public class KB
       {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Fumbles
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class FumLost
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class FumForced
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class FumOwnRec
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class FumOppRec
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class FumRecYds
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class FumTotalRec
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class FumTD
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class KrRet
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class KrYds
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }

            [JsonProperty("#text")]
            public string text { get; set; }
        }


        public class KrAvg
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class KrLng
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class KrTD
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }


        public class Kr20Plus
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Kr40Plus
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class KrFC
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class KrFum
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PrRet
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PrYds
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PrAvg
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PrLng
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PrTD
        {

            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Pr20Plus
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class Pr40Plus
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PrFC
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class PrFum
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class TwoPtAtt
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class TwoPtMade
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class TwoPtPassAtt
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class TwoPtPassMade
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class TwoPtPassRec
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class TwoPtRushAtt
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }

        public class TwoPtRushMade
        {
            public string category { get; set; }
            [JsonProperty("@abbreviation")]
            public string abbreviation { get; set; }
            [JsonProperty("#text")]
            public string text { get; set; }
        }



public class Stats
        {
            public GamesPlayed GamesPlayed { get; set; }
            public PassAttempts PassAttempts { get; set; }
            public PassCompletions PassCompletions { get; set; }
            public PassPct PassPct { get; set; }
            public PassYards PassYards { get; set; }
            public PassAvg PassAvg { get; set; }
            public PassYardsPerAtt PassYardsPerAtt { get; set; }
            public PassTD PassTD { get; set; }
            public PassTDPct PassTDPct { get; set; }
            public PassInt PassInt { get; set; }
            public PassIntPct PassIntPct { get; set; }
            public PassLng PassLng { get; set; }
            public Pass20Plus Pass20Plus { get; set; }
            public Pass40Plus Pass40Plus { get; set; }
            public PassSacks PassSacks { get; set; }
            public PassSackY PassSackY { get; set; }
            public QBRating QBRating { get; set; }
            public RushAttempts RushAttempts { get; set; }
            public RushYards RushYards { get; set; }
            public RushAverage RushAverage { get; set; }
            public RushTD RushTD { get; set; }
            public RushLng RushLng { get; set; }
            public Rush1stDowns Rush1stDowns { get; set; }
            public Rush1stDownsPct Rush1stDownsPct { get; set; }
            public Rush20Plus Rush20Plus { get; set; }
            public Rush40Plus Rush40Plus { get; set; }
            public RushFumbles RushFumbles { get; set; }
            public Targets Targets { get; set; }
            public Receptions Receptions { get; set; }
            public RecYards RecYards { get; set; }
            public RecAverage RecAverage { get; set; }
            public RecTD RecTD { get; set; }
            public RecLng RecLng { get; set; }
            public Rec1stDowns Rec1stDowns { get; set; }
            public Rec20Plus Rec20Plus { get; set; }
            public Rec40Plus Rec40Plus { get; set; }
            public RecFumbles RecFumbles { get; set; }
            public TackleSolo TackleSolo { get; set; }
            public TackleTotal TackleTotal { get; set; }
            public TackleAst TackleAst { get; set; }
            public Sacks Sacks { get; set; }
            public SackYds SackYds { get; set; }
            public Safeties Safeties { get; set; }
            public TacklesForLoss TacklesForLoss { get; set; }
            public Interceptions Interceptions { get; set; }
            public IntTD IntTD { get; set; }
            public IntYds IntYds { get; set; }
            public IntAverage IntAverage { get; set; }
            public IntLng IntLng { get; set; }
            public PassesDefended PassesDefended { get; set; }
            public Stuffs Stuffs { get; set; }
            public StuffYds StuffYds { get; set; }
            public KB KB { get; set; }
            public Fumbles Fumbles { get; set; }
            public FumLost FumLost { get; set; }
            public FumForced FumForced { get; set; }
            public FumOwnRec FumOwnRec { get; set; }
            public FumOppRec FumOppRec { get; set; }
            public FumRecYds FumRecYds { get; set; }
            public FumTotalRec FumTotalRec { get; set; }
            public FumTD FumTD { get; set; }
            public KrRet KrRet { get; set; }
            public KrYds KrYds { get; set; }
            public KrAvg KrAvg { get; set; }
            public KrLng KrLng { get; set; }
            public KrTD KrTD { get; set; }
            public Kr20Plus Kr20Plus { get; set; }
            public Kr40Plus Kr40Plus { get; set; }
            public KrFC KrFC { get; set; }
            public KrFum KrFum { get; set; }
            public PrRet PrRet { get; set; }
            public PrYds PrYds { get; set; }
            public PrAvg PrAvg { get; set; }
            public PrLng PrLng { get; set; }
            public PrTD PrTD { get; set; }
            public Pr20Plus Pr20Plus { get; set; }
            public Pr40Plus Pr40Plus { get; set; }
            public PrFC PrFC { get; set; }
            public PrFum PrFum { get; set; }
            public TwoPtAtt TwoPtAtt { get; set; }
            public TwoPtMade TwoPtMade { get; set; }
            public TwoPtPassAtt TwoPtPassAtt { get; set; }
            public TwoPtPassMade TwoPtPassMade { get; set; }
            public TwoPtPassRec TwoPtPassRec { get; set; }
            public TwoPtRushAtt TwoPtRushAtt { get; set; }
            public TwoPtRushMade TwoPtRushMade { get; set; }
        }

        public class Playerstatsentry
        {
            [JsonProperty("player")]
            public Capstone.TeamProfilePageData.PlayerStatsModel.Player player { get; set; }

            [JsonProperty("team")]
            public Capstone.TeamProfilePageData.PlayerStatsModel.Team team { get; set; }

            [JsonProperty("stats")]
            public Stats stats { get; set; }
        }

        public class Cumulativeplayerstats
        {
            [JsonProperty("lastUpdatedOn")]
            public string lastUpdatedOn { get; set; }

            [JsonProperty("playerstatsentry")]
            public List<Playerstatsentry> playerstatsentry { get; set; }
        }

        public class RootObject
        {
            [JsonProperty("cumulativeplayerstats")]
            public Cumulativeplayerstats cumulativeplayerstats { get; set; }
        }

 }
}

