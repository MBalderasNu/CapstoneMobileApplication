using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.NFLFantasyPerfectLineups
{
    public class FantasyTeamData
    {
        public static IList<FantasyTeam> fantasyplayer{ get; private set; }

        static FantasyTeamData()
        {
            fantasyplayer = new List<FantasyTeam>();

            fantasyplayer.Add(new FantasyTeam
            {
                Name = "Matthew Stafford",
                Position = "QB For Detroit Lions",
                Details = "2017/2018 Season " +
              "\n Oppenent: Arizona Cardinals" +
              "\n" +
              "\n Offense:  Comp: 27 \t Att:41  \t Yds:292 \t TD: 4 \t Int: 1 \t QBR: 113" +
              "\n  ",
                ImageUrl = "MatthewStaffordFantasy.jpg"
            });


            fantasyplayer.Add(new FantasyTeam
            {
                Name = "Tarik Cohen",
                Position = "RB For Chicago Bears",
                Details = "2017/2018 Season " +
              "\n Oppenent: Atlanta Falcons" +
              "\n" +
              "\n Offense:  Att:5  \t Yds:66 \t TD: 0 \t LNG: 46 \t Rec: 8 \t Rec Yds: 47 \t Rec TD: 1" +
              "\n  ",
                ImageUrl = "TarikCohenFantasy.jpg"
            });


            fantasyplayer.Add(new FantasyTeam
            {
                Name = "Leonard Fournette",
                Position = "RB For Jacksonville Jaguars",
                Details = "2017/2018 Season " +
              "\n Oppenent: Houston Texans" +
              "\n" +
              "\n Offense: Att: 26  \t Yds:100 \t TD: 1  \t LNG: 17 " +
              "\n  ",
                ImageUrl = "LeonardFournetteFantasy.jpg"
            });

            fantasyplayer.Add(new FantasyTeam
            {
                Name = "Kenny Golladay",
                Position = "WR For Detroit Lions",
                Details = "2017/2018 Season " +
              "\n Oppenent: Arziona Cardinals" +
              "\n" +
              "\n Offense:  Rec: 4 \t Rec Yds:69 \t TD: 2 " +
              "\n  ",
                ImageUrl = "KennyGolladayFantasy.jpg"
            });

            fantasyplayer.Add(new FantasyTeam
            {
                Name = "Golden Tate",
                Position = "WR For Detroit Lions",
                Details = "2017/2018 Season " +
              "\n Oppenent: Arziona Cardinals" +
              "\n" +
              "\n Passing Offense:  Rec: 10 \t Rec Yds:107 \t Rec TD: 0 " +
              "\n  ",
                ImageUrl = "GoldenTateFantasy.jpg"
            });


            fantasyplayer.Add(new FantasyTeam
            {
                Name = "Antonio Brown",
                Position = "WR For Pittsburgh Steelers",
                Details = "2017/2018 Season " +
              "\n Oppenent: Browns" +
              "\n" +
              "\n Passing Offense:  Rec: 11 \t Rec Yds:182 \t Rec TD: 0 " +
              "\n  ",
                ImageUrl = "AntonioBrownFantasy.jpg"
            });

            fantasyplayer.Add(new FantasyTeam
            {
                Name = "Austin Hooper",
                Position = "TE For Atlanta Falcons",
                Details = "2017/2018 Season " +
              "\n Oppenent: Arizona Cardinals" +
              "\n" +
              "\n Offense:  Rec: 2 \t Rec Yds:128 \t Rec TD: 1" +
              "\n  ",
                ImageUrl = "AustinHooperFantasy.jpg"
            });

            fantasyplayer.Add(new FantasyTeam
            {
                Name = "LeSean McCoy",
                Position = "RB For Buffalo Bills",
                Details = "2017/2018 Season " +
              "\n Oppenent: Arizona Cardinals" +
              "\n" +
              "\n Offense:   Att:22  \t Yds:110 \t TD: 0 \t Rec: 5 \t Rec Yards: 49" +
              "\n  ",
                ImageUrl = "LeseanMcCoyFantasy.jpg"
            });

            fantasyplayer.Add(new FantasyTeam
            {
                Name = "Los Angeles Rams",
                Position = "Defense",
                Details = "2017/2018 Season " +
             "\n Oppenent: Indianapolis Colts" +
             "\n" +
             "\n Defense:  FF: 2  \t INT: 2 \t TD: 2 \t Tackles: 36" +
             "\n  ",
                ImageUrl = "RamsDefenseFantasy.jpg"
            });




        }
    }
}
