
using Capstone.Database;
using Capstone.DatabaseModels;
using Capstone.NFLPlayersByTeam;
using Capstone.TeamProfilePageData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

using Xamarin.Forms;
using static Capstone.TeamProfilePageData.PlayerStatsModel;

namespace Capstone
{
	public class ProfilePage : ContentPage
	{
        Button sports, players, editbtn,simbtn, logout;
        Label userName = new Label();
        Label playerlabel = new Label();

        Label FavoriteTeam = new Label();

        AzureMobileService azure = new AzureMobileService();


        List<string> lineupPlayers = new List<string>();

        ListView test = new ListView();

        public ProfilePage (string userId)
		{

            GetUserDetail(userId);


            Title = " Draft Zone";

            Label profileLabel = new Label
            {
                Text = " Profile ",
                FontSize = 40,
                TextColor = Color.White
            };

           
            

            userName.FontSize = 30;
            userName.TextColor = Color.White;
            FavoriteTeam.TextColor = Color.White;



            playerlabel.FontSize = 20;

            FavoriteTeam.FontSize = 20;


            

            sports = new Button
            {
                Text = "SPORTS",
                // BackgroundColor = Color.FromHex("#"),
                //TextColor = Color.FromHex("#00CFFA")
            };


            players = new Button
            {
                Text = "PLAYERS",
                //BackgroundColor = Color.FromHex("#020509"),
                //TextColor = Color.FromHex("#00CFFA")


            };

            


            simbtn = new Button
            {
                Text = "Simulation"
            };

            editbtn = new Button
            {
                Text = " Edit Profile",
                //BackgroundColor = Color.FromHex("#020509"),
                
            };

            logout = new Button
            {
                Text = "Logout"
            };

           

            sports.Clicked += Sports_Clicked;
            editbtn.Clicked += Editbtn_Clicked;
            players.Clicked += Players_Clicked;
            test.ItemSelected += Test_ItemSelected;
            simbtn.Clicked += Simbtn_Clicked;
            logout.Clicked += Logout_Clicked;

          


            var stacklayout = new StackLayout
            {
                Children = { profileLabel,userName, FavoriteTeam, test, sports, players, simbtn, editbtn,logout}
            };

           
            this.Content = stacklayout;
            this.BackgroundColor = Color.FromHex("#323339");

            DCUsers testing = new DCUsers();
            void Editbtn_Clicked(object sender, EventArgs e)
            {
                testing = HomeSignInPage.data.GetUserName(userId);
                Navigation.PushModalAsync(new EditProfilePage(testing.Username.ToString()));

            }

        }

        private void Logout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HomeSignInPage());
        }

        private void Simbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SimYearSelection());
        }

        private void Test_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }

            switch (e.SelectedItem)
            {
                case "Deshaun Watson":
                    DeshaunWatson();
                    break;

                case "Drew Brees":
                    DrewBrees();
                    break;

                case "Aaron Rodgers":
                    AaronRodgers();
                    break;

                case "Levon Bell":
                    LevonBell();
                    break;

                case "Todd Gurley":
                    ToddGurley();
                    break;

                case "Ezekiel Elliot":
                    EzekielElliot();
                    break;

                case "Antonio Brown":
                    AntonioBrown();
                    break;

                case "Alshon Jeffery":
                    AlshonJeffery();
                    break;


                case "Odell Beckham Jr":
                    OdellBeckhamJr();
                    break;


                case "Julio Jones":
                    JulioJones();
                    break;

                case "Evan Engram":
                    EvanEngram();
                    break;


                case "Rob Gronkowski":
                    RobGronkowski();
                    break;


                case "Travis Kelce":
                    TravisKelce();
                    break;







            }
        }

        private async void DeshaunWatson()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=deshaun-watson&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Deshaun Watson Stats", " 2017/2018 Season " +
                        "\n Pass Completion: " + k.playerstatsentry[0].stats.PassPct.text +
                        "\n Pass Yards: " + k.playerstatsentry[0].stats.PassYards.text +
                        "\n Pass TDs: " + k.playerstatsentry[0].stats.PassTD.text +
                        "\n Pass Yard Per Attempt: " + k.playerstatsentry[0].stats.PassYardsPerAtt.text +
                        "\n Last Updated: " + k.lastUpdatedOn +
                        "\n QBR" +  k.playerstatsentry[0].stats.QBRating.text , "ok");
                }
            }
        }

        private async void DrewBrees()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=drew-brees&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Drew Brees Stats", " 2017/2018 Season " +
                        "\n Pass Completion: " + k.playerstatsentry[0].stats.PassPct.text +
                        "\n Pass Yards: " + k.playerstatsentry[0].stats.PassYards.text +
                        "\n Pass TDs: " + k.playerstatsentry[0].stats.PassTD.text +
                        "\n Pass Yard Per Attempt: " + k.playerstatsentry[0].stats.PassYardsPerAtt.text +
                        "\n QBR" + k.playerstatsentry[0].stats.QBRating.text, "ok");
                }
            }
        }
        private async void AaronRodgers()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=aaron-rodgers&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Aaron Rodgers Stats", " 2017/2018 Season " +
                        "\n Pass Completion: " + k.playerstatsentry[0].stats.PassPct.text +
                        "\n Pass Yards: " + k.playerstatsentry[0].stats.PassYards.text +
                        "\n Pass TDs: " + k.playerstatsentry[0].stats.PassTD.text +
                        "\n Pass Yard Per Attempt: " + k.playerstatsentry[0].stats.PassYardsPerAtt.text +
                        "\n QBR" + k.playerstatsentry[0].stats.QBRating.text, "ok");
                }
            }
        }
        private async void LevonBell()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=levon-bell&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Levon Bell Stats", " 2017/2018 Season " +
                        "\n Rec Yards: " + k.playerstatsentry[0].stats.RecYards.text +
                        "\n Rush Yards: " + k.playerstatsentry[0].stats.RushYards.text +
                        "\n Rush TDs: " + k.playerstatsentry[0].stats.RushTD.text +
                        "\n Rec TDs: " + k.playerstatsentry[0].stats.RecTD.text, "ok");
                }
            }
        }
        private async void ToddGurley()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=todd-gurley&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Todd Gurley Stats", " 2017/2018 Season " +
                        "\n Rec Yards: " + k.playerstatsentry[0].stats.RecYards.text +
                        "\n Rush Yards: " + k.playerstatsentry[0].stats.RushYards.text +
                        "\n Rush TDs: " + k.playerstatsentry[0].stats.RushTD.text +
                        "\n Rec TDs: " + k.playerstatsentry[0].stats.RecTD.text, "ok");
                }
            }
        }
        private async void EzekielElliot()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=ezekiel-elliott&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Ezekiel Elliot", " 2017/2018 Season " +
                        "\n Rec Yards: " + k.playerstatsentry[0].stats.RecYards.text +
                        "\n Rush Yards: " + k.playerstatsentry[0].stats.RushYards.text +
                        "\n Rush TDs: " + k.playerstatsentry[0].stats.RushTD.text +
                        "\n Rec TDs: " + k.playerstatsentry[0].stats.RecTD.text, "ok");
                }
            }
        }
        private async void AntonioBrown()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=antonio-brown&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Antonio Brown Stats", " 2017/2018 Season " +
                        "\n Rec Yards: " + k.playerstatsentry[0].stats.RecYards.text +
                        "\n Rec TDs: " + k.playerstatsentry[0].stats.RecTD.text +
                        "\n Targets: " + k.playerstatsentry[0].stats.Targets.text +
                        "\n Rec Average: " + k.playerstatsentry[0].stats.RecAverage._text, "ok");
                }
            }
        }
        private async void OdellBeckhamJr()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=odell-beckham&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Odell Beckham Jr Stats", " 2017/2018 Season " +
                        "\n Rec Yards: " + k.playerstatsentry[0].stats.RecYards.text +
                        "\n Rec TDs: " + k.playerstatsentry[0].stats.RecTD.text +
                        "\n Targets: " + k.playerstatsentry[0].stats.Targets.text +
                        "\n Rec Average: " + k.playerstatsentry[0].stats.RecAverage._text, "ok");
                }
            }
        }
        private async void JulioJones()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=julio-jones&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Julio Jones Stats", " 2017/2018 Season " +
                        "\n Rec Yards: " + k.playerstatsentry[0].stats.RecYards.text +
                        "\n Rec TDs: " + k.playerstatsentry[0].stats.RecTD.text +
                        "\n Targets: " + k.playerstatsentry[0].stats.Targets.text +
                        "\n Rec Average: " + k.playerstatsentry[0].stats.RecAverage._text, "ok");
                }
            }
        }
        private async void AlshonJeffery()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=alshon-jeffery&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Alshon Jeffery Stats", " 2017/2018 Season " +
                        "\n Rec Yards: " + k.playerstatsentry[0].stats.RecYards.text +
                        "\n Rec TDs: " + k.playerstatsentry[0].stats.RecTD.text +
                        "\n Targets: " + k.playerstatsentry[0].stats.Targets.text +
                        "\n Rec Average: " + k.playerstatsentry[0].stats.RecAverage._text, "ok");
                }
            }
        }
        private async void EvanEngram()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=evan-engram&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Evan Engaram Stats", " 2017/2018 Season " +
                        "\n Rec Yards: " + k.playerstatsentry[0].stats.RecYards.text +
                        "\n Rec TDs: " + k.playerstatsentry[0].stats.RecTD.text +
                        "\n Targets: " + k.playerstatsentry[0].stats.Targets.text +
                        "\n Rec Average: " + k.playerstatsentry[0].stats.RecAverage._text, "ok");
                }
            }
        }
        private async void TravisKelce()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=travis-kelce&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Travis Kelce Stats", " 2017/2018 Season " +
                        "\n Rec Yards: " + k.playerstatsentry[0].stats.RecYards.text +
                        "\n Rec TDs: " + k.playerstatsentry[0].stats.RecTD.text +
                        "\n Targets: " + k.playerstatsentry[0].stats.Targets.text +
                        "\n Rec Average: " + k.playerstatsentry[0].stats.RecAverage._text, "ok");
                }
            }
        }
        private async void RobGronkowski()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=rob-gronkowski&playerstats";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    await DisplayAlert("Rob Gronkowski Stats", " 2017/2018 Season " +
                        "\n Rec Yards: " + k.playerstatsentry[0].stats.RecYards.text +
                        "\n Rec TDs: " + k.playerstatsentry[0].stats.RecTD.text +
                        "\n Targets: " + k.playerstatsentry[0].stats.Targets.text +
                        "\n Rec Average: " + k.playerstatsentry[0].stats.RecAverage._text, "ok");
                }
            }
        }

        private void Players_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SportSelection());
        }


      

        DCUsers userDetail;
        public void GetUserDetail(string userId)
        {
            userDetail = HomeSignInPage.data.GetUserName(userId);
            userName.Text = userDetail.Username;

            FavoriteTeam.Text = userDetail.FavTeam;

            lineupPlayers.Add(userDetail.PlayerOne);
            lineupPlayers.Add(userDetail.PlayerTwo);
            lineupPlayers.Add(userDetail.PlayerThree);
            lineupPlayers.Add(userDetail.PlayerFour);
            lineupPlayers.Add(userDetail.PlayerFive);
            lineupPlayers.Add(userDetail.PlayerSix);
            lineupPlayers.Add(userDetail.PlayerSeven);


            test.ItemsSource = lineupPlayers;

           
        }

        
        private async void Sports_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new SportTeamsPage());

        }
    }
}