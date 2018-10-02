using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.TeamProfilePageData
{
    public class NFLTeamData
    {


        public static IList<NFLTeam> team { get; private set; }

        static NFLTeamData()
        {
            team = new List<NFLTeam>();

            team.Add(new NFLTeam
            {
                Name = "Arizona Cardinals",
                Location = "Phoenix, AZ",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 18.4  \t Yds/G: 314.1 \t Yds/P : 4.7 \t    3rd Down Pct: 35 "  +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18" +
                "\n  " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6 " +
                "\n  " +
                "\n Total Defense:    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = "cardslogo.jpg"
            });

            team.Add(new NFLTeam
            {
                Name = "Atlanta Falcons",
                Location = "Atlanta,GA",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 22.1  \t Yds/G: 364.8 \t Yds/P : 5.9 \t  3rd Down Pct: 45 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defense:    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Baltimore Ravens",
                Location = "Central and East Africa",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 24.7  \t Yds/G: 305.4 \t Yds/P : 4.6 \t  3rd Down Pct: 34 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Buffalo Bills",
                Location = "Central & South America",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 18.9  \t Yds/G: 302.6 \t Yds/P : 4.8 \t  3rd Down Pct: 42 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Carolina Panthers",
                Location = "Brazil",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 22.7  \t Yds/G: 323.7 \t Yds/P : 5.0 \t  3rd Down Pct: 42 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Chicago Bears",
                Location = "South America",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 16.5  \t Yds/G: 287.4 \t Yds/P : 4.9 \t  3rd Down Pct: 35 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Cincinnati Bengals",
                Location = "Japan",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 18.1  \t Yds/G: 280.5 \t Yds/P : 4.8 \t  3rd Down Pct: 34 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Cleveland Browns",
                Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 14.6  \t Yds/G: 308.9 \t Yds/P : 4.9 \t  3rd Down Pct: 34 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Dallas Cowboys",
                Location = "Borneo",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 22.1  \t Yds/G: 331.9 \t Yds/P : 5.3 \t  3rd Down Pct: 43 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Denver Broncos",
                Location = "Vietnam, Laos",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 18.1  \t Yds/G: 324.1 \t Yds/P : 4.8 \t  3rd Down Pct: 39 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Detroit Lions",
                Location = "Vietnam",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 25.6  \t Yds/G: 337.8 \t Yds/P : 5.5 \t  3rd Down Pct: 39 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Green Bay Packers",
                Location = "China",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 20 \t Yds/G: 305.7 \t Yds/P : 4.6 \t  3rd Down Pct: 39 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Houston Texans",
                Location = "China",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 21.1  \t Yds/G: 320.0 \t Yds/P : 5.0 \t  3rd Down Pct: 36 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Indianapolis Colts",
                Location = "Vietnam",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 16.4  \t Yds/G: 284.6 \t Yds/P : 4.6 \t  3rd Down Pct: 38 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Jacksonville Jaguars",
                Location = "Indonesia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 26.1  \t Yds/G: 365.9 \t Yds/P : 5.4 \t  3rd Down Pct: 37 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Kansas City Chiefs",
                Location = "Sri Lanka",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 25.9  \t Yds/G: 375.4 \t Yds/P : 6.1 \t  3rd Down Pct: 39 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Los Angeles Chargers",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 22.2  \t Yds/G: 376.6 \t Yds/P : 5.9 \t  3rd Down Pct: 40 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Los Angeles Rams",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 29.9  \t Yds/G: 361.5 \t Yds/P : 5.8 \t  3rd Down Pct: 41 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Miami Dolphins",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 17.6  \t Yds/G: 307.7 \t Yds/P : 4.9 \t  3rd Down Pct: 32 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Minnesota Vikings",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 23.9  \t Yds/G: 356.9 \t Yds/P : 5.4 \t  3rd Down Pct: 44 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });


            team.Add(new NFLTeam
            {
                Name = "New England Patriots",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 28.6  \t Yds/G: 394.2 \t Yds/P : 5.9 \t  3rd Down Pct: 41 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });


            team.Add(new NFLTeam
            {
                Name = "New Orleans Saints ",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 28  \t Yds/G: 391.2 \t Yds/P : 6.3 \t  3rd Down Pct: 38 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });


            team.Add(new NFLTeam
            {
                Name = "New York Giants",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 15.4  \t Yds/G: 314.2 \t Yds/P : 4.9 \t  3rd Down Pct: 33 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });


            team.Add(new NFLTeam
            {
                Name = "New York Jets",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 18.6  \t Yds/G: 305.2 \t Yds/P : 5.0 \t  3rd Down Pct: 36 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });


            team.Add(new NFLTeam
            {
                Name = "Oakland Raiders",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 18.8  \t Yds/G: 324.1 \t Yds/P : 5.4 \t  3rd Down Pct: 40 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });


            team.Add(new NFLTeam
            {
                Name = "Philadelphia Eagles",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 28.6  \t Yds/G: 365.8 \t Yds/P : 5.5 \t  3rd Down Pct: 42 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Pittsburgh Steelers",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 25.4  \t Yds/G: 377.9 \t Yds/P : 5.8 \t  3rd Down Pct: 44 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });


            team.Add(new NFLTeam
            {
                Name = "San Francisco 49ers",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 20.7  \t Yds/G: 349.2 \t Yds/P : 5.3 \t  3rd Down Pct: 39 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });

            team.Add(new NFLTeam
            {
                Name = "Seattle Seahawks",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 22.9  \t Yds/G: 330.4 \t Yds/P : 5.2 \t  3rd Down Pct: 37 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });


            team.Add(new NFLTeam
            {
                Name = "Tampa Bay Buccaneers",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 20.9  \t Yds/G: 363.5 \t Yds/P : 5.6 \t  3rd Down Pct: 43 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });


            team.Add(new NFLTeam
            {
                Name = "Tennesse Titans",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 20.9  \t Yds/G: 314.0 \t Yds/P : 5.2 \t  3rd Down Pct: 35 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });


            team.Add(new NFLTeam
            {
                Name = "Washington Redskins",
                Location = "Ethiopia",
                Details = "2017/2018 Season " +
                "\n Team Record 8-8 " +
                "\n" +
                "\n Total Offense:    Pt/G : 21.4  \t Yds/G: 324.9 \t Yds/P : 5.3 \t  3rd Down Pct: 32 " +
                "\n Passing Offense:  Comp: 339 \t Att:598  \t Pct: 56.7 \t Yds:3,640 \t Avg: 6.7  \t Yds/G: 227.5 \t TD: 21 \t Int: 18 " +
                "\n Rushing Offense:  Att: 409   \t Yds: 1,386  \t Avg:3.4   \t Yds/G : 86.6  \t TD: 6   " +
                "\n Total Defens:e    Pt/G : 22.6  \t Yds/G: 310.9  \t Yds/P : 4.9 " +
                "\n Passing Defense:  Pct: 60.8 \t Rate: 83.9 " +
                "\n Rushing Defense:  YD/G: 89.6  \t TD: 12",
                ImageUrl = ""
            });
        }



    }
}
