using Capstone.NFLPlayersByTeam;
using Capstone.TeamProfilePageData;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;

using Xamarin.Forms;
using static Capstone.TeamProfilePageData.PlayerDataModel;

namespace Capstone
{
    public class SportDetailPlayerPage : ContentPage
	{
        string username = "";
        string password = "";

        public ObservableCollection<NFLPlayer> players { get; set; }

        SearchBar search = new SearchBar();
        ListView lstView;

        public SportDetailPlayerPage ()
		{


            players = new ObservableCollection<NFLPlayer>();
            lstView = new ListView();
            lstView.RowHeight = 120;
            this.Title = "NFL Players";
            lstView.ItemTemplate = new DataTemplate(typeof(CustomNFLPlayerCell));


            Washington_Redskins_Offense();

            search.Placeholder = "Search";
            search.TextChanged += Search_TextChanged;

            var stack = new StackLayout
            {
                Children = {search, lstView}
            };

            this.Content = stack;
        }

        private async void Arizona_Cardinals_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=arizona-cardinals";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;


                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName,
                        Description = "Position:" + k.playerentry[7].player.Position +
                        "\nJersey Number:" + k.playerentry[7].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[7].player.Height +
                        "\nWeight:" + k.playerentry[7].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName,
                        Description = "Position:" + k.playerentry[12].player.Position +
                         "\nJersey Number:" + k.playerentry[12].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[12].player.Height +
                        "\nWeight:" + k.playerentry[12].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName,
                        Description = "Position:" + k.playerentry[13].player.Position +
                         "\nJersey Number:" + k.playerentry[13].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[13].player.Height +
                        "\nWeight:" + k.playerentry[13].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName,
                        Description = "Position:" + k.playerentry[24].player.Position +
                         "\nJersey Number:" + k.playerentry[24].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[24].player.Height +
                        "\nWeight:" + k.playerentry[24].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName,
                        Description = "Position:" + k.playerentry[32].player.Position +
                         "\nJersey Number:" + k.playerentry[32].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[32].player.Height +
                        "\nWeight:" + k.playerentry[32].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName,
                        Description = "Position:" + k.playerentry[36].player.Position +
                         "\nJersey Number:" + k.playerentry[36].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[36].player.Height +
                        "\nWeight:" + k.playerentry[36].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName,
                        Description = "Position:" + k.playerentry[38].player.Position +
                         "\nJersey Number:" + k.playerentry[38].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[38].player.Height +
                        "\nWeight:" + k.playerentry[38].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName,
                        Description = "Position:" + k.playerentry[39].player.Position +
                         "\nJersey Number:" + k.playerentry[39].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[39].player.Height +
                        "\nWeight:" + k.playerentry[39].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName,
                        Description = "Position:" + k.playerentry[43].player.Position +
                         "\nJersey Number:" + k.playerentry[43].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[43].player.Height +
                        "\nWeight:" + k.playerentry[43].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName,
                        Description = "Position:" + k.playerentry[46].player.Position +
                         "\nJersey Number:" + k.playerentry[46].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[46].player.Height +
                        "\nWeight:" + k.playerentry[46].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName,
                        Description = "Position:" + k.playerentry[47].player.Position +
                         "\nJersey Number:" + k.playerentry[47].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[47].player.Height +
                        "\nWeight:" + k.playerentry[47].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName,
                        Description = "Position:" + k.playerentry[48].player.Position +
                         "\nJersey Number:" + k.playerentry[48].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[48].player.Height +
                        "\nWeight:" + k.playerentry[48].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName,
                        Description = "Position:" + k.playerentry[50].player.Position +
                         "\nJersey Number:" + k.playerentry[50].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[50].player.Height +
                        "\nWeight:" + k.playerentry[50].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName,
                        Description = "Position:" + k.playerentry[51].player.Position +
                         "\nJersey Number:" + k.playerentry[51].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[51].player.Height +
                        "\nWeight:" + k.playerentry[51].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName,
                        Description = "Position:" + k.playerentry[52].player.Position +
                         "\nJersey Number:" + k.playerentry[52].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[52].player.Height +
                        "\nWeight:" + k.playerentry[52].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName,
                        Description = "Position:" + k.playerentry[60].player.Position +
                         "\nJersey Number:" + k.playerentry[60].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[60].player.Height +
                        "\nWeight:" + k.playerentry[60].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName,
                        Description = "Position:" + k.playerentry[68].player.Position +
                         "\nJersey Number:" + k.playerentry[68].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[68].player.Height +
                        "\nWeight:" + k.playerentry[68].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName,
                        Description = "Position:" + k.playerentry[69].player.Position +
                         "\nJersey Number:" + k.playerentry[69].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[69].player.Height +
                        "\nWeight:" + k.playerentry[69].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName,
                        Description = "Position:" + k.playerentry[70].player.Position +
                         "\nJersey Number:" + k.playerentry[70].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[70].player.Height +
                        "\nWeight:" + k.playerentry[70].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName,
                        Description = "Position:" + k.playerentry[72].player.Position +
                         "\nJersey Number:" + k.playerentry[72].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[72].player.Height +
                        "\nWeight:" + k.playerentry[72].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName,
                        Description = "Position:" + k.playerentry[73].player.Position +
                         "\nJersey Number:" + k.playerentry[73].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[73].player.Height +
                        "\nWeight:" + k.playerentry[73].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName,
                        Description = "Position:" + k.playerentry[74].player.Position +
                         "\nJersey Number:" + k.playerentry[74].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[74].player.Height +
                        "\nWeight:" + k.playerentry[74].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName,
                        Description = "Position:" + k.playerentry[86].player.Position +
                         "\nJersey Number:" + k.playerentry[86].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[86].player.Height +
                        "\nWeight:" + k.playerentry[86].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName,
                        Description = "Position:" + k.playerentry[89].player.Position +
                         "\nJersey Number:" + k.playerentry[89].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[89].player.Height +
                        "\nWeight:" + k.playerentry[89].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName,
                        Description = "Position:" + k.playerentry[93].player.Position +
                         "\nJersey Number:" + k.playerentry[93].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[93].player.Height +
                        "\nWeight:" + k.playerentry[93].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName,
                        Description = "Position:" + k.playerentry[96].player.Position +
                         "\nJersey Number:" + k.playerentry[96].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[96].player.Height +
                        "\nWeight:" + k.playerentry[96].player.Weight,
                        Image = "PatTomBrady.png"
                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName,
                        Description = "Position:" + k.playerentry[97].player.Position +
                         "\nJersey Number:" + k.playerentry[97].player.JerseyNumber +
                        "\nHeight:" + k.playerentry[97].player.Height +
                        "\nWeight:" + k.playerentry[97].player.Weight,
                        Image = "PatTomBrady.png"
                    });


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Atlanta_Falcons_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=atlanta-falcons";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    
                  
                    //Robert Alford CB
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + " " +  k.playerentry[2].player.LastName , Image = "Alford_Robert_card.jpg" });

                    //Ricardo Allen S
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName , Image = "Allen_Ricardo_card.jpg" });
                  
                   //Vic Beasley OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName , Image = "Beasley_Vic_card.jpg" });
                 
                   //Matt Bosher P
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName, Image = "Bosher_Matt_card.jpg" });
                 

                   //Matt Bryant K
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName , Image = "Bryant_Matt_card.jpg" });

                 

                    //De'Vondre Campbell OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName, Image = "Campbell_DeVondre_card.jpg" });
                 

                    //Adrian Clayborn DE
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName, Image = "Clayborn_Adrian_card.jpg" });

                    //Tevin Coleman RB
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName, Image = "Coleman_Tevin_card.jpg" });

                    //Derrick Coleman FB
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName , Image = "Coleman_Derrick.jpg" });


                   

                    //Devonta Freeman RB
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName, Image = "Freeman_Devonta_card.jpg" });

                 

                   //Taylor Gabriel WR
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName , Image = "bio_card_gabriel_taylor.jpg" });

                   

                    //Ben Garland G
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName, Image = "bio_card_garlanda_Ben.jpg" });

                

                    //Marvin Hall WR
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName , Image = "Hall_Marvin.jpg" });


                 

                    //Justin Hardy WR
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName , Image = "Hardy_Justin_card.jpg" });

                    //Sean Harlow OG
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName , Image = "Harlow_Sean.jpg" });

                    //Josh Harlow LS
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName , Image = "Harris_Josh_card.jpg" });


                    //Austin Hooper TE
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName , Image = "Hooper_Austin_card.jpg" });


                 
                    //Kemal Ishamel S
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName , Image = "Ishmael_Kemal_card.jpg" });


                   
                    //Grady Jarrett DT
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName , Image = "Jarrett_Grady_card.jpg" });

                    //Julio Jones WR
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName , Image = "Jones_Julio_card.jpg" });

                    
                  

                    //Deion Jones LB
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName , Image = "Jones_Deion_card.jpg" });


                    

                    //Damontee Kazee CB
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName , Image = "bio_card_kazee_damontae.jpg" });


                    

                    //Alex Mack C
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName , Image = "Mack_Alex_card.jpg" });


                    

                    //Jake Matthews T
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName , Image = "Matthews_Jake_card.jpg" });

                  

                    //Takkarist McKinely DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName , Image = "McKinley_Takk_Bio_Card.jpg" });



                    //Keanu Neal S
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName , Image = "Neal_Keanu_card.jpg" });

                    //Sharrod Neasman S
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName , Image = "Neasman_Sharrod.jpg" });

                  

                    //Dontari Poe NT
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName , Image = "Poe_Dontari.jpg" });

                    //Brian Poole CB
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName ,Image = "Poole_Brian.jpg" });
                  

                    //Brooks Reed DE
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName, Image = "Reed_Brooks_card.jpg" });


                   

                    //LaRoy Reynolds LB
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName , Image = "Reynolds_Laroy.jpg" });

                    //Duke Riley OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName , Image = "Riley_Duke.jpg" });

                    //Andre Roberts WR
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName , Image = "Roberts_Andre.jpg" });


                    //Ahtyba Rubin DT
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName , Image = "nophotofalcon.jpg" });

                    //Matt Ryan QB
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName , Image = "Ryan_Matt_card.jpg" });

                    //Ty Sambrailo OT
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName, Image = "nophotofalcon.jpg" });

                    //Mohamed Sanu WR
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName , Image= "Sanu_Mohamed_card.jpg"});

                    //Eric Saubert TE
                    players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName , Image = "Saubert_Eric.jpg" });

                    //Matt Schaub QB
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName , Image = "Schaub_Matt_card.jpg" });

                    
                    

                    //Ryan Schraeder T
                    players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName , Image = "Schraeder_Ryan_card.jpg" });

                    //Wes Schweitzer G
                    players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName , Image = "Schweitzer_Wes.jpg" });

                    //Derrick Shelby  DE
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName , Image = "Shelby_Derrick.jpg" });


                  

                    //Levine Toilolo TE
                    players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName , Image = "Toilolo_Levine_card.jpg" });

                 

                    //Desmond Trufant CB
                    players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName , Image = "Trufant_Desmond_card.jpg" });


                  

                    //Courtney Upshaw DT
                    players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName , Image = "Upshaw_Courtney.jpg" });


                  

                    //Terron Ward RB
                    players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName , Image = "Ward_Terron_card.jpg" });


                 

                    //Sean Weatherspoon LB
                    players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName , Image = "Sean_Weatherspoon.jpg" });


                 

                    //Nick Williams WR
                    players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName , Image = "Williams_Nick_card.jpg" });

                    //Blidi Wreh-Wilson CB
                    players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName, Image = "Wreh_Wilson_Blidi.jpg" });
                    


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Baltimore_Ravens_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=baltimore-ravens";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //Javorius Allen RB

                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });
                

                    //Tyus Bowser OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                 

                    //Nick Boyle TE
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                   

                    //Maurice Canady CB
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });


                    //Brandon Carr CB
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                 

                    //Chuck Clark S
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });


                    //Kamalei Correa LB
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Morgan Cox LS
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //Carl Davis DT
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //Kenneth Dixon RB
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });
                 

                    //Jermaine Eluemunor G/T
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //Joe Flacco QB
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
               

                    //Crockett Gillmore TE
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });
               

                    //Willie Henry DT
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                

                    //Jaylen Hill CB
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                 

                    //Austin Howard OT
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //Marlon Humphrey CB
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                  
                    //Tony Jefferson S
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });
                

                    //Matthew Judon OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Bronson Kaufusi DE
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Sam Koch P 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Anthony Levine Sr. DB/LB
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Alex Lewis G/T
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                  

                    //Jeremy Maclin WR
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Ryan Mallet QB
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });
                 

                    //Albert McClellan LB
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                  

                    //Chris Moore WR
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                 

                    //C.J. Mosley ILB
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                  

                    //Stephane Nembot T
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
               

                    //Breshad Perriman WR
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });

                    //Michael Pierce DT
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                  

                   //Patrick Ricard DL/FB
                    players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                

                    //Za'Darius Smith OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Jimmy Smith CB
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                 

                    //Ronnie Stanley T
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Terrell Suggs OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
               

                    //Justin Tucker K
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                 

                    //Mike Wallace WR
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                 

                    //Benjamin Watason TE
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Lardarius Webb DB
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //Eric Weddle S
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Terrance West RB
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                   

                    //Max Williams TE
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //Brandon Williams DT
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Tim Williams OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //Danny Woodhead RB
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });

                    //Chris Wormley DE
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Marshal Yanda G
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //Tavon Young CB
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                   


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Buffalo_Bills_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=buffalo-bills";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //Lorenzo Alexander LB
                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Colt Anderson S
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                 
                    //Kelvin Benjamin WR
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                   
                    //Preston Brown LB
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    
                    //Nordly Capi DE ?
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });
                  
                    //Charles Clay TE
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //Ryan Davis DE
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Dion Dawkins T
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });
                  

                    //Patrick DiMarco DB
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Vladimir Ducasse G
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });

                    //Reid Ferguson LS
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //E.J. Gaines CB
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                 
                    //Ryan Groy G
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Rickey Hatley DT
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Steven Hauschka K 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Seantrel Henderson T
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Andre Holmes WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Jerry Hughes DE
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Ramon Humber LB
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //Micah Hyde S 
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Richie Incongnito G
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Leonard Johnson CB
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Zay Jones WR
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Deon Lacy LB
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Khari Lee TE
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Jordan Matthews WR
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //LeSean McCoy RB
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });

                    //Matt Milano LB
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //John Miller G
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Jordan  Mills T 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Marcus Murphy RB
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });


                    //Nick O'Leary TE
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //Nathan Peterman QB
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });

                    //Lafayette Pitts CB
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });


                   // players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Jordan Poyer S 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //Brandon Reilly WR
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                 
                    //Colton Schmidt P 
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                
                    //Brandon Tate WR
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });

                    //Tyrod Taylor QB
                    players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //Logan Thomas TE
                    players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });

                    //Shamarko Thomas S 
                    players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });

                    //Deonte Thompson WR
                    players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });

                    //Cedric Thornton DT
                    players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });

                    //Mike Tolbert FB
                    players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });

                    //Tanner Vallejo LB
                    players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });

                    //Adolphus Washington DT
                    players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });

                    //JOE WEBB QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });

                    //Tre'Davious White CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[124].player.FirstName + k.playerentry[124].player.LastName });

                    //Kyle Williams DT
                    players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName });

                   // players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[127].player.FirstName + k.playerentry[127].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[128].player.FirstName + k.playerentry[128].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[129].player.FirstName + k.playerentry[129].player.LastName });

                    //Eric Wood  C
                    players.Add(new NFLPlayer { Name = k.playerentry[130].player.FirstName + k.playerentry[130].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[131].player.FirstName + k.playerentry[131].player.LastName });

                    //Shareece Wright 
                    players.Add(new NFLPlayer { Name = k.playerentry[132].player.FirstName + k.playerentry[132].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[133].player.FirstName + k.playerentry[133].player.LastName });

                    //Eddie Yarbrough
                    players.Add(new NFLPlayer { Name = k.playerentry[134].player.FirstName + k.playerentry[134].player.LastName });

                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Carolina_Panthers_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=carolina-panthers";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //Mike Adams S
                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Mario Addison DE
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Derek Anderson QB
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Alex Armah FB
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //Cameron Artis-Payne  RB
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });

                    //Brenton Bersin WR
                   players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //James Bradberry CB
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Vernon Bulter DT
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Damiere Byrd WR
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Jairus Byrd DB
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //Kaelin Clay WR
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Kurt Coleman S 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //Bryan Cox DE
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Demetrious Cox S
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Thomas Davis LB
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });

                    //Ed Dickson TE
                    players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                  //  players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //Austin Duke WR
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });


                   // players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Corn Elder CB
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Dan France T
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Mose Frazier WR
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Devin Funchess WR
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Andrew Gachkar LB
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Gano Graham K 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Garrett Gilbert QB
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Daeshon Hall DE
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Wes Horton DE
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Drew Iddings DT
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Ben Jacobs LB
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });

                    //J.J. Jansen LS
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Charles Johnson
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //Charles Johnson
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //Colin Jones S 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });


                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //Ryan Kalil C
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Matt Kalil T
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });

                    //Luke Kuechly LB
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //Tyler Larsen C 
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });

                    //Star lotulelei DT
                    players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Kyle Love DT
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Cole Luke CB
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });

                    //Chris Manhertz TE
                    players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //David Mayo LB
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Christian McCaffrey RB
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Zach Moore DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Taylor Moton T
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Captain Munnerlyn CB
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //Cam Newton QB
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //Jared Norris LB
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //Andrew Norwell G 
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });

                    //Efe Obada  DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Greg Olsen TE
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Michael Palardy P 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //Damian Parms S 
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Julius Peppers DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });

                    //Fred Ross WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Curtis Samuel WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //Zack Sanchez CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //Kevon Seymour CB
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });

                    //Russell Shepard WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });

                    //Kawann Short DT
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });

                    //Amini Silatolu T 
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[99].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });

                    //Scott Simonson TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[101].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });

                    //Dezmen Southward S 
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });

                    //Jonthan Stewart RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });

                    //Kent Taylor TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //Shaq Thompson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });

                    //Trai Turner G 
                    players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });

                    //GregVan Roten C 
                    players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });

                    //Fozzy Whittaker RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });

                     
                   // players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });

                    //Daryl Willams T 
                    players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });

                    //Teddy Williams CB
                    players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });

                    //David Worley CB
                    players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });

                    //David Yankey G 
                    players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[124].player.FirstName + k.playerentry[124].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName });


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Chicago_Bears_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=chicago-bears";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //Sam Acho OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });

                    //Adrian Amos S 
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Prince Amukamara CB
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Jonathan Anderson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Josh Bellamy WR
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //Ben Braunecker TE
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });


                  //  players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Daniel Brown TE
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Jonathan Bullard DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Michael Burton FB
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Deon Bush S 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //Bryce Callahan CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Tarik Cohen RB
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Tom Compton RT 
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //Marcus Cooper CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Victor Cruz WR
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Benny Cunningham RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Quintin Demps S 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //Andrew DePaola LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[32].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[33].player.LastName });

                    //Kyle Fuller CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //Mike Glennon QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Eddie Goldman NT 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Hroniss Grasu C 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                   // players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Deiondre Hall DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Akiem Hicks DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Lamarr Houston LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //DeAndre Houston-Carson S 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Jordan Howard RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Dontrelle Inman WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Eddie Jackson S 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //John Jenkins NT 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Howard Jones LB 
                   players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //Christian Jones ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Nick Kwiatkoski ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });

                    //Jeremy Langford RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Crevon Leblanc CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });

                    //Charles Leno Jr. LT 
                    players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });


                    //Kyle Long LG
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //Bobby Massie RT 
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Sherrick McManis CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Pernell McPhee OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //Cameron Meredith WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //Zach Miller TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Mike Nugent K 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Pat O Donnell P 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //March Sanchez QB
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });

                    //Adam Shaheen TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });

                    //Dion Siems TE
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });

                    //Josh Sitton RG 
                    players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });

                    //Brady Sowell LT 
                    players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });

                    //John Timu LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });

                    //Danny Trevathan INL 
                    players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });

                    //Mitchell Trubisky QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });

                    //Markus Wheaton Wr 
                    players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });

                    //Cody Whitehair OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[124].player.FirstName + k.playerentry[124].player.LastName });

                   //Kendall Wright WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName });

                    //Willie Young OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName });

                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Cincinnati_Bengals_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=cincinnati-bengals";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //Geno Atkins DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Brandon Bell LB
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //Giovani Bernard HB
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });

                    //Andrew Billings DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Russell Bodine C 
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Clint Boling G 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //Tyler Boyd WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Randy Bullock K 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //Vontaze Burfict LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Cethan Carter HB 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });

                    //Cody Core WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Andy Dalton QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });

                    //Darqueze Dennard CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Carlos Dunlap DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Tyler Eifert TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //Alex Erickson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //Jordan Evans LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Clayton Fejedelem S 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Jake Fisher 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });


                   // players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Ryan Glasgow DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //A.J. Green WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Clark Harris LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Ryan Hewitt HB 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //Jeremy Hill RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });

                    //Trey Hopkins G 
                    players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Kevin Huber P 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //George Iloka S 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //William Jackson CB
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Michael Johnson DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //Adam Jones CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Dre Kirkpatrick CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Tyler Kroft TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Bradon LaFell WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Carl Lawson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Josh Malone WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //AJ McCarron QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Tony McRae CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Joe Mixon HB 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Hardy Nickerson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Cedric Ogbuehi OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Alex Redmond G 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Vincent Rey LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //John Ross WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });

                    //KeiVarae Russell CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    
                   // players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Josh Shaw CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });

                    //Pat Sims  DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //Chris Smith DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });

                    //Andre Smith OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });

                    //CJ Uzomah TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[67].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Shawn Williams S 
                   // players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Shawn Williams S 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                    //Jordan Willis DE
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                    //Branond Wilson S 
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Eric Winston OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
            



                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Cleveland_Browns_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=cleveland-browns";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;



                    //players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Dominique Alexander LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Chris Barker OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Gary Barnidge TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //BJ BELLO LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Joel Bitonio OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Briean Boddy-Calhoun DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Caleb Brantley DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //James Burgess LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                    //Tank Carder LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Sammie Coates WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Corey Coleman WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Shon Coleman OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //Trevon Coley DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //Jamie Collins LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Britton Colquitt P 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Isaiah Crowell RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Justin Currie DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //Matthew Dayes RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Seth Devalve TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Spencer Drango OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Lavar Edwards DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });

                    //Myles Garrett DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Zane Gonzalez K 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Josh Gordon WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Rashard Higgins WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Kevin Hogan QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Duke Johnson RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //Michael Jordan DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Cody Kessler QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Josh Keyes LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Derrick Kindred DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Chris Kirksey LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Deshone Kizer QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //Ricardo Louis WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Marcus Martin OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //Jason McCourty DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Jamie Meder DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });

                    //Kai Nacua DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Carl Nassib DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //David Njoku TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Emmanuel Ogbah DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //Larry Ogunjobi DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Nate Orchard DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //Jabrill Peppers DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //Austin Reiter OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });

                    //Joe Schobert LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Danny Shelton DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //CJ Smith DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });

                    //Derron Smith DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //Jamar Taylor DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });

                    //Randall Telfer TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Joe Thomas OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //JC Tretter OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //Dan Vitale FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });

                    //Kasen Willimas WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });

                    //Kevin Zeitler OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[124].player.FirstName + k.playerentry[124].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName });


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Dallas_Cowboys_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=dallas-cowboys";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //Richard Ash  DT
                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Chidobe Awuzie CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //Dan Bailey K 
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Cole Beasley WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Byron Bell T 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //Bene Benwikere CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //Noah Brown WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Anthony Brown CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });

                    //Dez Bryant WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Brice Butler WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Taco Charlton DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //La'el Collins T 
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Maliek Collins DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Jonathan Cooper G 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Tyrone Crawford DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Kadeem Edwards G 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Ezekiel Elliot RB
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Kavon Frazier S 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //Travis Frederick C 
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Chaz Green T 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Randy Gregory 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //James Hanna TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //Jeff Heath S 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Anthony Hitchens LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //David Irving DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Datone Jones DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Byron Jones S 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //Chris Jones P 
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //LP LAdouceur LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Demarcus Lawrence DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Sean Lee LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Lance Lenoir WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });

                    //Jourdan Lewis CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Joe Looney OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Justin March Lillard LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Zack Martin OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //Benson Mayowa De 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });

                    //Darren McFadden RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Alfred Morris RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });

                    //Lewis Neal DE
                    players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });

                    //Dak Prescott QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Daniel Ross DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //Cooper Rush QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Orlando Scandrick QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Rod Smith RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Tyron Smith OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //Keith Smith FB 
                   // players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });

                    //Geoff Swaim TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });

                    //Ryan Switzer WR 
                   // players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Kyle Wilber LB
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //Terrance Williams WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Damien Wilson LB
                   
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                    //Jason Witten TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                    //Xavier Woods S 
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                 
                


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Denver_Broncos_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=denver-broncos";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //CJ Anderson RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Zaire Anderson ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Allen Barbre G 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //Shaquil Barrrett OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Garett Bolles T 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Devontae Booker RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                 //   players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Jamal Carter S 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Jamaal Charles RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Todd Davis ILB
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Riley Dixon P 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Bennie Fowler WR -27
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //Max Garcia G 
                    players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Jerrol Garcia-Williams ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Adam Gotsis DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //Virgil Green TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Shelby Harris DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });

                    //Chris Harris CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //DeAngelo Henderson RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Jeff Heuerman TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Andy Janovich FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Joe Jones LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Zach Kerr DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Casey Kreiter LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Brendan Langley CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //Cody Latimer WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Ronald Leary 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Paxton Lynch QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Brandon Marshall ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Connor McGovern G 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //Isaiah McKenzie WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Brandon McManusj K 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Von Miller OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });

                    //Deiontrez Mount LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //Brock Osweiler QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });

                    //Matt Paradis C 
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });

                    //Will Parks S 
                    players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Domata Peko NT 
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Kyle Peko NT 
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });

                    //Shane Ray OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Marcus Rios CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Bradley Roby CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Emmanuel sanders WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //Trevor Siemian QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Justin Simmons S 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //Donald Stephenson T 
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //Darian Stewart S 
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });

                    //Aqib Talib CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });

                    //Jordan Taylor WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                    //Demaryius Thomas WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Juwan Thompson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Austin Traylor TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });

                    //Demarcus Walker DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[124].player.FirstName + k.playerentry[124].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName });


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Detroit_Lions_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=detroit-lions";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                  

                    //Ameer Abdullah RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //Jamal Agnew CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });

                    //Ezekiel Ansah DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                 

                    //Nick Bellore LB
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                  
                    //Jace Billingsley WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });
               

                    //Don Carey S 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Emmett Cleary T 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                 

                    //Jarrad Davis LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Taylor Decker T 
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //Quandre Diggs DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Eric Ebron TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });
                  

                    //Darren Fells TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                 
                    //Graham Glasgow G 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //Kenny Golladay WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //Tion Green RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //DJ Hayden CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                

                   
                   //Marvin Jones JR. WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                  

                    //Miles Killebrew  S 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                  
                    //TJ LANG  G 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Nevin Lawson CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Jermiah Ledbetter DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });

                    //DeAndre Levy OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });
                   

                    //Steve Longa LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                  


                    //Sam Martin P
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                  

                    //Brian Mihalik T 
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                

                    //Don Muhlbach LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
              

                    //Matt Prater K 
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Glover Quin S 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                

                    //Jalen Reeves Maybin LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Theo Riddick RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Christian Ringo DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //Michael Roberts TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //Corey Robinson T 
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });

                    //A'Shawn Robinson DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });

                    //Jake Rudock QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                 

                    //Darius Slay CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                   
                    //Akeem Spence DT
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });

                    //Matthew Stafford QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                  

                    //Teez Tabor CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Golden Tate WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                  

                    //Ricky Wagner T 
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //Dwayne Washington RB
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //Cornelius Washingtion DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });

                    //Charles Washington S 
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });

                    //Tahir Whitehead LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                

                    //Paul Worrilow LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                

                    //Zach Zenner RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });

                    //Anthony Zettel DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });
                   



                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Green_Bay_Packers_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=greenbay-packers";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //Davante Adams WR
                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Gernimo Allison WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //David Bakhtiari T
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });

                    //Vince Biegel LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Kentrell Brice S 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //Ahmad Brooks LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });

                    //Donatello Brown CB
                    players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Bryan Bulaga T 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Morgan Burnett S 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //Emanuel Byrd  TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Joe Callahan QB
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });

                    //Michael Clark WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Kenny Clark DT
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });

                    //Ha Ha clinton Dix S 
                    players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Randall Cobb WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Mason Crosby K 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //Mike Daniels DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //Trevor Davis WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Quinton Dial DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Jahri Evans G 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Evans Marwin S 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Kyler Fackrell LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //Reggie Gilbert LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });

                    //Brett Goode LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Demetri Goodson CB
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //Josh Hawkins CB
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Davon House CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Brett Hundley QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Jeff Janis WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Aaron Jones RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Lance Kendricks TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //Joe Kerridge FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Kevin King CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Corey Linsley C 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Dean Lowry DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Blake martinez LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });

                    //Clay Matthews LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Devante Mays RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //Justin McCray G 
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Ty Montogomery RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Kyle Murphy T 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });

                    //Jordy Nelson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //Chris Odom LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Lucas Patrick G 
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });

                    //Taybor Pepper 
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });

                    //Nick Perry LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });

                    //Lenzy Pipkins CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });

                    //Damarious Randall CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Aaron Ripkowski FB
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Aaron Rodgers QB
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //Richard Rodgers TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Quinten Rollins CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Jake Ryan LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Jacob Schum P 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //Jason Spriggs T 
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });

                    //James Starks RB
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });

                    //lane Taylor G 
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                    //Joe Thomas LB
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Justin Vogel P 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Herb Waters CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //Jermaine Whitehead S 
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Jamaal Williams RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                   



                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Houston_Texans_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=houston-texans";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //Jeff Allen G 
                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Stephen Anderson TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //Angelo Blackson DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Alfred Blue 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Ibraheim Campbell S 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });

                    //Chunky Clements NT 
                    players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Jadeveon Clowney DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Dylan Cole ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //Zach Cunningham ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Brian Cushing ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Julien Davenport OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Treston Decoud DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Kurtis Drummond  S 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Brandon Dunn DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Andre ellignton RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Kaimi fairbairn K 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //CJ Fiedorowicz TE
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //Donta Foreman RB
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //Will Fuller WR
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Breno Giacomini T 
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //Marcus Gilchrist S 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Andre hal S 
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Cobi Hamilton WR
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Joel Heath DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Taylor Heinicke QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //DeAndre Hopkins WR
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //Kareem Jackson CB
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Jelani Jenkins ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Kevin Johnson CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });


                   // players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Johnathan Joseph CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });

                    //Ufomba Kamalu DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Kendall Lamm T 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //Shane Lechler P 
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //LaTroy Lewis OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //Ryan Malleck TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });

                    //Greg Mancz C 
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //Benardrick McKinney ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });

                    //Whitney Mercilus OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });

                    //Lamar Miller RB
                    players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Braxton Miller WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Brian Peters ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });


                    //players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //Eddie Pleasant S 
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Gimel President OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //Jay Prosch FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //David Quessenberry OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Tom Savage QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Chad Slade G 
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });

                    //Xavier Su'a-Filo G 
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Chris Thompson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //Jordan Todamn  RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //Carlos Watkins DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //Deshaun Watson Qb
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //JJ WATT DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });

                    //Jonathan Weeks LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });

                    //De Andrew White WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });

                    //Marcus Williams CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });

                    //TJ Yates QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                    players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });



                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Indianapolis_Colts_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=indianapolis-colts";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                  //  players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });
                    //Kamar Aiken
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                    //Tarell Basham OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                   //  players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //KJ Brent WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //Jacoby Brissett QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Darius Bulter S 
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Anthony Castonzo T 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //Le Raven Clark T 
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Darrell Daniels TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Vontae Davis CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Jack Doyle TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Matthias Farley S 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //Josh ferguson RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Clayton Geathers S 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Jeremiah George ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //Denzelle Good T 
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    
                    //players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Frank Gore RB
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });

                    //Jermaine Grace ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //TJ Green S 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                   
                   // players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Joe Haeg  T 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Nate Hairston CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Johnathan Hankins DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //TY Hilton WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Malik Hooker S 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Margus Hunt DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Anthony Johnson DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Matt Jones RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Andrew Luck QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Marlon Mack RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });

                    //Joey Mbu NT 
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Chris Milton CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Barkevious Mingo OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Donte Moncrief WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //Kenny Moore ll CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //Antonio Morrison ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //Luke Rhodes  LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //Hassan Ridgeway DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Chester Rogers WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //Rigoberto Sanchez P
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //Jabaal Sheard OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });

                    //Grover Stewart DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });

                    //Scott Tolzien QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //Ross Travis TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });

                    //Jason Vander Laan TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });

                    //Adam Vinatieri K 
                    players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });

                    //Jeremy Vujnovich G 
                    players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });

                    //Anthony Walker ILB 
                    players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });

                    //DJ White CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });

                    //Quincy Wllson CB
                    players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });
                    //George Winn RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });
               


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Jacksonville_Jaguars_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=jacksonville-jaguars";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                   // players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                    //Eli Ankou DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });

                    //Tommy Bohanon FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Blake Bortles QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //AJ Bouye CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Blair Brown LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Calais Campbell DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //AJ Cann OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Barry Church S 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //Keelan Cole WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Aaron Colvin CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Marcell Dareus DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Leonard Fournette RB
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //Dante Fowler JR DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Tashaun Gipson S 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Corey Grant RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Chad Henne QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Colin Holba LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Allen Hurns WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //Chris Ivory RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Myles Jack 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Malik Jackson DE
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });

                    //Abry Jones DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });

                    //Ben Koyack TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });

                    //Josh Lambo K 
                    players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Marqise Lee WR
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Marcedes Lewis TE
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });

                    //Brandon Linder OL
                    players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Lerentee Mccray OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Jaydon Mickens WR
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //Jalen Myrick CB
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //Yannick Ngakoue DE
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //Brad Nortman P 
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                    //Patrick Omameh 
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //James O Shaughnessy TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //Jeremy parnel OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Tyler Patmon CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });

                    //Donald Payne LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });

                    //Carroll Phillips DE
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Paul Posluszny LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Jalen Ramsey CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //Chris Reed OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });

                    //Allen Robinson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });

                    //Cam Robinson OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });

                    //Tyler Shatley OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //Telvin Smith LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });

                    //Dawuane Smoot DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });

                    //Jalen Strong WR
                    players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });

                    //Peyton Thompson S 
                    players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });

                    //Josh Wells OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });

                    //Dede WestBrook WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });

                    //Jarrod Wilson S 
                    players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });

                    //TJ Yeldon RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });
                  


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Kansas_City_Chiefs_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=kansascity-chiefs";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                 //   players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //Kenneth Acker
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[2].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Eric Berry S 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //Allen Bailey DL
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //tyler bray qb
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });

                    //harrison butker K
                    players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Orson Charles TE
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Jehu Chesson WR
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Dustin Colquitt P 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //jordan devey OL
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Laurent Duvernay-Tardif OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //Parker Ehinger OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Ukeme Eligwe LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Cameron Erving OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Eric Fisher OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Zach Fulton OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //Tamba Hali LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Justin Hamilton DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Demetrius Harris TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Tyreek Hill WR  
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Justin Houston LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Akeem Hunt RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //Kareem Hunt RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Jarvis Jenkins DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Derrick Johnson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Chris Jones DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //Travis Kelce TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Marcus kemp WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Tanoh Kpassagnon LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //Bennie Logan DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Patrick Mahomes QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Leon MCQuay DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });

                    //Terrance Mitchell DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Eric Murray DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //Steven Nelson DB
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Rakeem Nunez Roches DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //Ron Parker DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });

                    //Marcus Peters DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });

                    //Kevin Pierre Loois LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                    //Reggie Ragland LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Keith Reaser DB
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                   //players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });

                    //Demarcus Robinson
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Mitchell Schwartz OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });

                    //Anthony Sherman RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Alex Smith QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //Terrance Smith LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //Daniel Sorensen DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //CJ Spiller RB
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });


                   // players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });

                    //Charcandrck West RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });

                    //Albert Wilson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });

                    //Ramik Wilson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });

                    //James Winchester SP 
                    players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });

                    //Bryan Witzmn OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });

                    //Frank Zombo LB
                    players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Los_Angeles_Chargers_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=losangeles-chargers";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //jahleel addae s
                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //keenan allen wr
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });

                    //jeremiah attaochu de
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //joe barksdale t
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //travis benjamin wr
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });

                    //joey bosa de
                    players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //tre boston s
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //jatavis brown olb
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });
                    //.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //jeff cumberland te
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //geremy davis wr
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //michael davis cb
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //nick dzubnar ilb
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //austin ekeler rb
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //kyle emanuel olb
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //dan feeney g
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //antonio gates te
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //melvin gordon rb
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //casey hayward cb
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //hunter henry te
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                    //.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //melvin ingram de
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //rayshawn jenkins s
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //cardale jones qb 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //drew kaser p
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //desmond king cb
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //corey liuget dt
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //craig mager cb
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });

                    //chris mccain de
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //sean mcgarth te
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    // brandon mebane nt
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //russell okung t
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //branden oliver rb
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //tenny palepoi dt
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //denzel perryman ilb
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //adrian phillips s
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //darius philon de
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //hayes pullard lb
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //spencer pulley c
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //phillip rivers qb
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //isaac rochell de
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //nick rose k
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });

                    //michael schofield ol
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //damion square dt
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //sam tevi t
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //korey toomer ilb
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //Jason verrett cb
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                   

                    //kenny wiggins g
                    players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                   

                    //tyrell williams wr
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });


                    //mike williams wr
                    players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                   

                    //mike windt ls
                    players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                  

                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Los_Angeles_Rams_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=losangeles-rams";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    
                   // players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Tavon Austin WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });

                    //Mark Barron LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Connor Barwin OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //Austin Blythe C 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });

                    //Michael Brockers DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Malcolm Brown RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Jamon Brown G 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //Omarius Bryant DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Derek Carrier TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });

                    //Marqui Christian DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });

                    //Pharoh Cooper WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Blake Countess DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Justin davis RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //Cody Davis S 
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Aaron Donald DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Lance Dunbar RB  
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Dominique Easley DT  
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Samson Ebukam LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Jake Eldrenkamp C 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Gerald Evertt TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //Sam Ficken K 
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });

                    //Morgan Fox DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Jared Goff QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //Todd Gurley RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //Bryce hager LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });

                    //Dominique Hatfield DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //Robert havenstein T 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Johnny Hekker P 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Temarrick Hemingway TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Tyler Higbee TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Troy Hill CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Isaiah Johnson DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //John Johnson s 
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Trumaine Johnson CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Lamarcus Joyner S 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Cooper Kupp WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Zach Laskey FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Corey Littleton OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });

                    //Matt Longacre DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Cornellius Lucas T 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //Cameron Lynch LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Sean Mannion QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Jake McQuaide LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });

                    //Johnny Mundt TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Aaron Neary C 
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Alec Ogletree LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Kevin Peterson CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //Ejuan Price OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Robert Quinn OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //Josh Reynolds WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });

                    //Nickell Robey-Cooleman DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });

                    //Sam Rogers FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Rodger Saffold G 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //John Sullivan C 
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Mike Thomas WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });

                    //Carlos Thompson OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Lenard Tillery RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });

                    //Tyrunn Walker DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });

                    //Sammy watkins WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });

                    //Kayvon Webster CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });

                    //Ethan Westbrooks DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });

                    //Andrew Whitworth T 
                    players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //Darrell Williams T 
                    players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });

                    //Robert Woods WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });

                    //Greg Zuerlin K 
                    players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Miami_Dolphins_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=miami-dolphins";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Walt Alkens CB
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //Chase Allen LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Kiko Alonso LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });
                    //Stephone Anthony LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Andre Branch DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Jake Brendel C 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Jay Culter QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Jesse Davis G 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //John Denney LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //AJ Derby TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Kenyan Drake RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //David Fales QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Anthony Fasano TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Terrence Fede DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Davon Godchaux DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //Jakeem Grant WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //MarQueis Gray TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Matt Haack P 
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });

                    //Charles Harris DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Neville Hewitt LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Xavien Howard CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Mike Hull LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Reshad Jones S 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Jarvis Landry WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Ted Larsen C 
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Jordan Lucas CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Cameron Malveaux DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //Bobby MCCain CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });

                    //TJ MCDonald S 
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //Torry MCTyer CB
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });

                    //Matthew Moore QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });

                    //Devante parker WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });

                    //Cody Parkey K 
                    players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Senorise Perry RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Jordan Phillips DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Mike Pouncey C 
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Rashawn Scott WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //DeVeon Smith RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                    //Zach Sterup T 
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Kenny Stills WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //Ndamukong Suh DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Cordrea Tankersley CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });

                    //Ryan Tannehil QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //Julius Thomas TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Michael Thomas S 
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //Lawrence Timmons LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });

                    //Laremy Tunsil T 
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //Alterraun Verner CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //Cameron Wake DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });

                    //Damien Williams RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });

                    //Gabe Wright DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });

                    //Sam Young T 
                    players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });



                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Minnesota_Vikings_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=minnesota-vikings";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;


                    //players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Mackensie Alexander CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //Anthony Barr LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Blake Bell TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Joe Berger C
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });

                    //Tashawn Bower DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Sam  Bradford QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Dylan Bradley DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //Teddy Bridgewater QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //Tramaine Brock DB  
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Kentrell Brother LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });

                    //Mack Brown RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Stacy Coley WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Aviante Collins OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Dalvin Cook RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Stefon Diggs WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Nicholas Easton C 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Pat Elflein C 
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Michael Floyd WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Sharrif Floyd DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Kai Forbath K 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Ben Gedeon LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //Everson Griffen DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //CJ Ham FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //Anthony Harris S 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Rashod Hill T 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Danielle Hunter DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Danny Isidora OG 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });


                    //Tom Johnson DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Jaleel Johnson DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Cayleb Jones WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //Linval Joseph DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Jayron Kearse S 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Case Keenum QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Eric Kendricks LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Emmanuel Lamur LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Kevin McDermott LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //Jerick McKinnon RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });

                    //David Morgan TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //Latavius Murray RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });

                    //Terence Newman CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //Ifeadi Odenigbo DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });

                    //Jeff Overbaugh LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });

                    //Ryan Quigley  P 
                    players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });

                    //Riley Reiff T 
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Mike Remmeers T 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Xavier Rhodes CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Horace Richardson CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Brian Robison DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Kyle Rudolph TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Bishop Sankey RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //Andrew Sendejo S 
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });

                    //Marcus Sherels CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Jeremiah Sirles G 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Kyle Sloter QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //Harrison Smith S 
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Shamar Stephen DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Adam Thielen WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //Jack Tocho S 
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });

                    //Laquon Treadwell WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Nick Truesdell TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //Shaan Washington LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //Trae Waynes CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });

                    //Stephen Weatherly DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });

                    //Eric Wilson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });

                    //Jarius Wright WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
               


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void New_England_Patriots_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=newengland-patriots";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //Dwayne Allen TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Ryan Allen P 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //Danny Amendola Wr 
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });

                    //David Andrews C 
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Johnson Bademosi CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Brandon Bolden RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Tom Brady QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //Alan Branch DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //Kenny Britt WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Malcom Brown DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });

                    //Rex Burkhead RB  
                    players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Adam Butler DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Malcolm Butler CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //Joe Cardona LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Patrick Chung S 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Brandin Cooks WR  
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Cole Croston OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //James Develin RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Phillip Dorsett WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Cameron Fleming OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Trey Flowers DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Marquis Flowers LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Mike Gillislee RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Stephon Gillmore CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Stephen Gostkowski K 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Nlcholas Grigsby LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Geneo Grissom DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Rob Gronkowski TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Lawrence Guy DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Duron Harmon DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //David Harris LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //James Harrison LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });

                    //Donta Hightower ILB
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });


                    //Chris Hogan WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Jacob Hollister TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Brian Hoyer  QB  
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Ricky Jean Francois DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Ted Karras G 
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Brandon King DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //Eric Lee DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Dion Lewis RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });


                    //Shaq Mason OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Devin McCourty DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });

                    //Bernard Reedy WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //Jordan Richards DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Elandon Roberts LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //Eric Rowe DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //Matt Slater WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //Nate Solder OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });

                    //Joe Thuney G 
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });

                    //Kyle Van Noy LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //LaAdrian Waddle OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });

                    //James White RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });

                    //Deatrich Wise DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                  


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void New_Orleans_Saints_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=neworleans-saints";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;


                   // players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });

                    //Terron Armstead T 
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //Chris Banjo S 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Vonn Bell S 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Drew Brees QB
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Rafeel Bush S 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Austin Carr WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //Brandon Coleman WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Ken Crawley CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Chase Daniel QB  
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Tyeler Davison DT
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Trey Edmunds RB  
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });

                    //Coby Fleener TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Jonathan Freeny LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //John Fullington OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Tedd Ginn WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Woodrow Hamilton DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Justin Hardee DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Bryce Harris T 
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //Trey Hendrickson DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Taysom Hill QB  
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Josh Hill TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });

                    //Gerald Hodges  LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //Michael Hoomanawanui TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //Mark Ingram RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });

                    //George Johnson DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Cameron Jordan DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });

                    //Alvin Kamara RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });

                    //Senio Kelemete C 
                    players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });


                    //Marshon Lattimore CB
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Josh LeRibeus G 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Tommylee Lewis WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Zach Line RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //Wil Lutz K 
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //Arthur Maulet CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });

                    //Michael Mauti LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });

                    //Sterling Moore CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });

                    //Thomas Morstead P 
                    players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });

                    //Al-Quadin Muhammad DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });

                    //David Onyemata DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //John Phillips TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });

                    //Ryan Ramczyk T 
                    players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });

                    //Sheldon Rankins DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });

                    //Craig Roberston LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });

                    //Willie Snead WR  
                    players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });

                    //Manti Teo 
                    players.Add(new NFLPlayer { Name = k.playerentry[124].player.FirstName + k.playerentry[124].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName });

                    //Michael Thomas WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName });

                    //Cameron Tom C 
                    players.Add(new NFLPlayer { Name = k.playerentry[127].player.FirstName + k.playerentry[127].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[128].player.FirstName + k.playerentry[128].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[129].player.FirstName + k.playerentry[129].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[130].player.FirstName + k.playerentry[130].player.LastName });

                    //Max Unger C 
                    players.Add(new NFLPlayer { Name = k.playerentry[131].player.FirstName + k.playerentry[131].player.LastName });

                    //Kenny Vaccaro S
                    players.Add(new NFLPlayer { Name = k.playerentry[132].player.FirstName + k.playerentry[132].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[133].player.FirstName + k.playerentry[133].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[134].player.FirstName + k.playerentry[134].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[135].player.FirstName + k.playerentry[135].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[136].player.FirstName + k.playerentry[136].player.LastName });

                    //Larry Warford G 
                    players.Add(new NFLPlayer { Name = k.playerentry[137].player.FirstName + k.playerentry[137].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[138].player.FirstName + k.playerentry[138].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[139].player.FirstName + k.playerentry[139].player.LastName });

                    //PJ Williams CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[140].player.FirstName + k.playerentry[140].player.LastName });

                    //Marcus Williams S 
                    players.Add(new NFLPlayer { Name = k.playerentry[141].player.FirstName + k.playerentry[141].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[142].player.FirstName + k.playerentry[142].player.LastName });

                    //Zach Wood LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[143].player.FirstName + k.playerentry[143].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[144].player.FirstName + k.playerentry[144].player.LastName });


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void New_York_Giants_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=newyork-giants";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //jerell adams te
                    players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //andrew admas S 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });

                    //eli apple cb
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //ray ray armstrong olb
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //akeem ayers lb
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //odell beckham wr
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //nate berhe s
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //adam bisonowaty  t
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });

                    //jay bromley dt
                    players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //marquis bundy wr
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Jonathan casillas LB
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //ross cockrell cb
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //landon collins s
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //orleans darkwa rb
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //donte deayon cb
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Zak Deossie LS
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //Brandon Dixon CB
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //rhett ellison te
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Evan engram te
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //erck flowers T
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //dj fluker G
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //wayne gallman RB
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //BJ Goodson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Curtis Grant LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //John Greco OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Jon Halapio G 
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //Dwayne Harris WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Damon Harrison DT
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });

                    //Mark Herzlich LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //Janoris Jenkins CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //John Jerry G 
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });

                    //Brett Jones C 
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });

                    //Devon Kennard LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Tavarres King WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });

                    //Roger lewis WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Eli Manning QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Brandon Marshall WR
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //darryl morris db
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });

                    //avery moss de
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });

                    //calvin  munson lb
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                    //ryan murphy s
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });

                    //Romeo Okwara DE
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Paul perkins RB
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //Jason pierre paul DE
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Darius Powe WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //Justin Pugh G 
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //Kalif Raymond WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });

                    //Weston Richburg C 
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });

                    //Keenan Robinson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });

                    //Dominique Roders Cromarite CB
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });

                    //Aldrick Rosas K 
                    players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });

                    //Travis Rudolph WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });

                    //Hunter Sharp WR
                    players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });

                    //Sterling Shepard WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //Kelvin Sheppard MLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });

                    //Deontae Skinner LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });

                    //Geno smith QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });

                    //Shane Smith TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });
                     //layers.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });

                    //Robert Thomas DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });

                    //Darian THompson S 
                    players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });

                    //Dalvin Tomlinson DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });


                    //Shane vereen RB
                    players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });

                    //Olivier Vernon DE
                    players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[124].player.FirstName + k.playerentry[124].player.LastName });

                    //Davis  Webb QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName });

                    //Chad Wheeler T 
                    players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[127].player.FirstName + k.playerentry[127].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[128].player.FirstName + k.playerentry[128].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[129].player.FirstName + k.playerentry[129].player.LastName });

                    //Brad wring P 
                    players.Add(new NFLPlayer { Name = k.playerentry[130].player.FirstName + k.playerentry[130].player.LastName });

                    //Kerry Wynn DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[131].player.FirstName + k.playerentry[131].player.LastName });


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void New_York_Jets_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=newyork-jets";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;


                    //players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Jamal Adams S
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });

                    //robby anderson wr 
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });

                    //david bass lb 
                    players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //kevin beachum t 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //freddie bishop lb 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Terrence Brooks S 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });

                    //Juston Burris CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //James Carpenter G 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Bruce Carter LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Chandler Catanzaro K 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Morris Claiborne CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Jeremy Clark CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Xavier Cooper DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //Demario Davis LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Dakota Dozier G
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Kony Ealy DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //Lachlan Edwards P 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Quincy Enuwa WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Obum Gwacham LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Christian Hackenberg QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Chad Hansen WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Jonotthan Harrison OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Thomas Hennessy LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Ben ljalana T 
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Jordan Jenkins LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //Wesley Johnson C 
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Derrick Jones CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //Jermaine kearse WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                    //.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //Darron Lee LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Josh Martin LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //Marcus Maye S  
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Elijah McGuire RB
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Steve McLendon DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //Rontez Miles S 
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });

                    //JoJo Natson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });

                    //Mike Pennel DL  
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //Bryce Petty QB  
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Bilal Powell RB  
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });

                    //Brent Qvale OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Darryl Roberts CB
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //Rashard  Robinson CB
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });

                    //Austin Seferian-Jenkins TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });

                    //Brandon Shell T 
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });

                    //Deon Simon DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });

                    //Buster Skrine CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                    players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                   // //players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });

                    //Lawerence Thomas FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });

                    //Eric tomlinson TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });

                    //Lucky Whitehead WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });

                    //Muhammad Wilkerson DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });

                    //Leonard Williams DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                  


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Oakland_Raiders_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=oakland-raiders";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;


                    //players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Alexander Vadal G 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //Denico Autry DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Navorro Bowman LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //Shilique Calhoun LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Derek Carr QB  
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });

                    //TJ Carrie CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Jon Condo LS  
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Connor Cook QB
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //Jared Cook TE  
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //Amari Cooper WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //James Cowser LB/DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Michael Crabtree WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Mario Edwards DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Justin Ellis DT  
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Antonio Hamilton CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //Erik Harris S 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //Treyvon Hester DT  
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Johnny Holton WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Rodney Hudson C 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Bruce Irvin LB  
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Gabe jackson G 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //karl Joseph S 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Marquette King P 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //Darius latham DT  
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });

                    //Marquel Lee LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //Shalom Luani S 
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Marshawn Lynch RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //Khalil Mack DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //EJ Manuel QB  
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //Dexter McDonald CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });

                    //Keith McGill DB
                    players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });

                    //Nicholas Morrow LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });

                    //Reggie Nelson S 
                    players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });

                    //Marshall Newhouse OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Jamize Olawale FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Kelechi Osemele OL  
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Cordarrelle Patterson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Jalen Richard RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Seth Roberts WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //David Sharpe T 
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });

                    //Lee Smith TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Sean Smith CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Giorgio Tavecchio K 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Eddie Vanderdoes DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });

                    //Jihad Ward DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //Jylan Ware T 
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //DeAndre Washington RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //Isaac Whitney WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Philadelphia_Eagles_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=philadelphia-eagles";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;



                    //players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //Jay Ajayi RB
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Beau allen dt
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Kenjon barner rb
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //derek barnett de
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //will beatty T 
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    
                    //players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Legarrette blount rb 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });

                    //nigel bradham lb 
                    players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //bryan braman de
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });

                    //brandon brooks g 
                    players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //trey burton te
                   // players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //brent celek te
                    //players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //corey clement rb
                    //players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //fletcher cox dt
                    //players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                  
                   // players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //vinny curry de 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //ronald  darby cb 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //Rasul Douglas cb 
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //dannell ellerbe lb 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //jake elliott k
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });

                    //zach ertz te 
                    players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });


                   // players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //nick foles Qb 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //nate gerry lb 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //shelton gibson wr 
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //najee goode lb 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //brandon graham de 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //corey graham s 
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Kamu Grugier-Hill lb 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //mack hollins wr
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //alshon jeffery wr 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //malcolm jenkins 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //timmy jernigan dt
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });

                    //marcus johnson wr
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //lane johnson t
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //sidney jones cb
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });

                    //donnie jones p
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });

                    //jason kelce C
                    players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //mychal kendricks LB
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //chris long de
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });

                    //rick lovato ls
                    players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //rodney mcleod s
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //steven means de
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //jalen mills cb
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //elijah quallls dt
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //patrick robinson cb
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //isaac seumalo g
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //wendell smallwood rb
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //torrey smith WR
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //nate sudfield qb
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });

                    //destiny vaeao dt
                    players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });

                    //halapoulivaati  vaitai t
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //chance warmack g
                    players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });

                    //jaylen watkins s
                    players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });

                    //carson wentz QB
                    players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });

                    //stefen wisniewski g
                    players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });
               


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Pittsburgh_Steelers_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=pittsburgh-steelers";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Brian Allen CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Tsyon Alualu DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });

                    //Le Veon Bell RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Jordan Berry P 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Chris Boswell K 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //Antonio Brown WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Martavis Bryant WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });

                    //Artie Burns CB  
                    players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Kameron Canaday LS
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Anthony Chickillo LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Sean Davis S 
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //David DeCastro G  
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Joshua Dobbs QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Bud Dupreee LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Matt Feiler OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //BJ Finney C 
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });

                    //LJ Fort LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Ramon Foster G 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //William Gay CB
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Marcus Gilbert OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Robert Golden S 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Xavier Grimble TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Joe Haden CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Javon Hargrave NT 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Jerald Hawkins OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Cameron Heyward DT
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Darrius Heyward Bey WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Mike Hilton CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Chris Hubbard C 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Justin Hunter WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Jesse James TE
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //Landry Jones QB
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Tyler Matakevich LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });

                    //Daniel McCullers DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Vance McDonald TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Mike Mitchell S 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Arthur Moats lB 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //Roosevelt Nix FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                    //Maurkice Pouncey C 
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Stevan Ridley RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Ben Roethlisberger QB
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });

                    //Eli Rogers WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //Coty Sensabaugh CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });

                    //JuJu Smith Schuster WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //Sean Spence LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //Cameron Sutton CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });

                    //Fitzgerlad Toussaint RB
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });

                    //Stephon Tuitt DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });

                    //Alejandro Villanueva OT 
                    players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });

                    //LT Walton DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });

                    //TJ Watt LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });

                    //JJ Wilcox S 
                    players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });

                    //Vince Williams LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });



                    lstView.ItemsSource = players;
                }
            }

        }

        private async void SanFrancisco_49ers_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=sanfrancisco-49ers";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;


                   // players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Tim barnes c 
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Zane Beadles G
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //CJ Beathard QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Ronald Blair DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //Kendrick Bourne WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Matt Breida RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //DeForest Buckner DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Tank Carradine DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Garrett Celek TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Adrian Colbert DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });

                    //Brock Coyle LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //Sheldon Day DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Leger Douzable DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });

                    //Elvis Dumervil LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Antone Exum JR DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });

                    //Reuben Foster LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Brandon Fusco OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Pierre Garcon WR
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Jimmy Garoppolo QB  
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });


                    //players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Marquise Goodwin WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Robbie Gould K 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Leon Hall CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Eli Harold LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Carlos Hyde RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Dontae Johnson CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Kyle Juszczyk FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });

                    //Daniel Kilgore C 
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //George Kittle TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Elijah Lee LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });

                    //Aaron Lynch LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });

                    //Greg Mabin CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });

                    //Cassius Marsh DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });

                    //Dexter McCoil DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Jeremy McNichols RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //Earl Mitchell NT 
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Louis Murphy WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Kyle Nelson TE
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //Mark Nzeocha OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                    //Logan Paulsen TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Bradley Pinion P 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //Tyvis Powell DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });

                    //Eric Reid S 
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //Aldrick Robinson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //Joe Staley T 
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });

                    //Trent Taylor WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });

                    //Solomon Thomas DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });

                    //Laken Tomlinson OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //Dekoda Watason LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });

                    //K Waun Williams CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });

                    //Ahkello Witherspoon CB
                    players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[124].player.FirstName + k.playerentry[124].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName });


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Seattle_Seahawks_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=seattle-seahawks";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //DJ Alexander LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //Cliff Avril DE
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });

                    //Doug Baldwin WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Michael Bennett DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    
                    //players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //Justin Britt C 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Duanae Brown T 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //Kam Chancellor S 
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Frank Clark DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Justin Coleman CB
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Amara Darboh WR
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Austin Davis QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Mike Davis RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //Jimmy Graham TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Shaquill Griffin CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Delano Hill SS 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //Joey Hunt C 
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //Germain Ifedi G 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //Branden Jackson DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Quinton Jefferson DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Luke Joeckel G 
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Dion Jordan DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Eddie Lacy RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Jeremy Lane DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });

                    //Tyler Lockett WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Byron Maxwell CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });

                    //Bradely McDougald FS 
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Tanner McEvoy WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //JD McKissic RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //Tyler Ott LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Ethan Pocic G 
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });

                    //Thomas Rawls RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });

                    //Jarran Reed DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Paul Richardson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Sheldon Richardson DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });

                    //Jon Ryan P 
                    players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //DeShawn Shead CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Richard Sherman CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Marcus Smith DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Garrison Smith DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Earl Thomas DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //Tedric Thompson FS 
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //Neiko Thorpe CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //Matt Tobin T 
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });

                    //Nick Vannett TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                    //Bobby Wagner LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Blair Walsh K 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //Michael Wilhoite LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });

                    //Luke Wilson TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });

                    //Russell Wilson QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });

                    //KJ Wright LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                    // players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });
                    // players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });
                    // players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                    // players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[124].player.FirstName + k.playerentry[124].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName });



                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Tampa_Bay_Buccaneers_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=tampabay-buccaneers";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;


                    //players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });

                    //Kwon Alexander LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });

                    //Bryan Anger P 
                    players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Antony Auclair TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //Robert Ayers DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });

                    //Chris Baker DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });

                    //Peyton Barber RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });

                    //Kendell Beckwith LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //Caleb Benenoch OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });

                    //Devante Bond LB
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Cameron Brate TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });

                    //Riley Bullough LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //Will Clarke DE
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Chris Conte S 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });

                    //Alan Cross TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Lavonte David LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Demar Dotson T 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });

                    //Javien Elliott CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });

                    //Mike Evans WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });

                    //Justin Evans S 
                    players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });

                    //Ryan Fitzpatrick QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //Nick Folk K
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //William Gholston DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Adarius Glanton LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //Chris Godwin WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Ryan Griffin QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });

                    //Brent Grimes CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Vernon Hargreaves CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Joe Hawley C 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //OJ Howard TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Adam Humphries WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });

                    //Vincent Jackson WR 
                    //players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });

                    //Desean Jackson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });

                    //Austin Johnson FB 
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //Isaiah Johnson S 
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });

                    //Davonte Lambert DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });

                    //Ali Marpet C 
                    players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });

                    //Doug Martin RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });

                    //Freddie Martino WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Robert McMClain CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Gerald McCoy DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Clinton McDonald DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Patrick Murray K 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });

                    //Eric Nzeocha LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //Kevin Pamphile G/T 
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                    //Josh Robinson CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Jacquizz Rodgers RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Ryan Russell DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //Garrison Sanbron LS
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });

                    //Sealver Siliga DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Charles Sims RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });

                    //Evan Smith C 
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });

                    //Donovan Smith T 
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //Ryan Smith DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //Noah Spence DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });

                    //JR Sweezy G 
                    players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });

                    //Keith Tandy S 
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });

                    //Justin Trattou DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });

                    //Channing Ward DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });

                    //TJ Ward SS
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });

                    //Leonard Wester T 
                    players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //Bobo Wilson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });

                    //Jameis Winston QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });
                   



                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Tennessee_Titans_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=tennessee-titans";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;

                    //players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Daren Bates LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Beau Brinkley LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //Jayon Brown LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });

                    //Kevin Byard S 
                    players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Josh Carraway OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });

                    //Jurrell Casey DT 
                    players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });

                    //Matt Cassel QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });

                    //Jack Conklin T 
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });

                    //Johnathan Cyprien S 
                    players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Corey Davis WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });

                    //Eric Decker WR
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });

                    //Kevin Dodd OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Harry Douglas WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //David Fluellen RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });

                    //Derrick Henry RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });

                    //Demontre Hurst CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });

                    //Adoree Jackson CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Austin Johnson DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });

                    //Ben Jones C 
                    players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Dennis Kelly G 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Brett Kern P 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });

                    //David King DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });

                    //Josh Kline G 
                    players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });

                    //Karl Klug DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });

                    //Corey Levin G 
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //Taylor Lewan T 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Marcus Mariota QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });

                    //Brice McCain CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                  //  players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });

                    //Derrick Morgan OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });

                    //Khalfani Muhammad RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });

                    //DeMarco Murray RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });

                    //Brian Orakpo OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });

                    //Nate Palmer LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Kalan Reed CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });

                    //Curtis Riley DB 
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });

                    //Logan Ryan CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });

                    //Da Norris Searcy S 
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //Jonnu Smith TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });

                    //Tye smith CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });

                    //Quinton Spain G 
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });

                    //Luke Stocker TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });

                    //Ryan Succop K 
                    players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });

                    //Phillip Supernaw TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });

                    //Taywan Taylor WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });

                    //Brynden Trawick S 
                    players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });

                    //Erik Walden OLB 
                    players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });

                    //Delanie Walker TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });

                    //Brandon Weeden QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });

                    //Eric Weems WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });

                    //Sylvester Williams NT 
                    players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });

                    //Avery Williamson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });

                    //Wesley Woodyard LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[124].player.FirstName + k.playerentry[124].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName });


                    lstView.ItemsSource = players;
                }
            }

        }

        private async void Washington_Redskins_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/active_players.json?team=washington-redskins";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).activeplayers;


                    //players.Add(new NFLPlayer { Name = k.playerentry[0].player.FirstName + k.playerentry[0].player.LastName });

                    //Ryan Anderson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[1].player.FirstName + k.playerentry[1].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + k.playerentry[2].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[4].player.FirstName + k.playerentry[4].player.LastName });

                    //Tony Bergstrorm OL 
                    players.Add(new NFLPlayer { Name = k.playerentry[5].player.FirstName + k.playerentry[5].player.LastName });

                    //Kapri Bibbs RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[6].player.FirstName + k.playerentry[6].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[7].player.FirstName + k.playerentry[7].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[8].player.FirstName + k.playerentry[8].player.LastName });

                    //Bashaud Breeland CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[10].player.FirstName + k.playerentry[10].player.LastName });

                    //Zach Brown LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[11].player.FirstName + k.playerentry[11].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[13].player.FirstName + k.playerentry[13].player.LastName });

                    //Tyler Catalina G 
                    players.Add(new NFLPlayer { Name = k.playerentry[14].player.FirstName + k.playerentry[14].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[15].player.FirstName + k.playerentry[15].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[17].player.FirstName + k.playerentry[17].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName });

                    //Kirk Cousins QB 
                    players.Add(new NFLPlayer { Name = k.playerentry[19].player.FirstName + k.playerentry[19].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[20].player.FirstName + k.playerentry[20].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[21].player.FirstName + k.playerentry[21].player.LastName });

                    //Jamison Crowder WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[25].player.FirstName + k.playerentry[25].player.LastName });

                    //Vernon Davis TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[26].player.FirstName + k.playerentry[26].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[27].player.FirstName + k.playerentry[27].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[28].player.FirstName + k.playerentry[28].player.LastName });

                    //Josh Doctson WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[29].player.FirstName + k.playerentry[29].player.LastName });

                    //Quinton Dunbar CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[30].player.FirstName + k.playerentry[30].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[31].player.FirstName + k.playerentry[31].player.LastName });

                    //Deshazor Everett S 
                    players.Add(new NFLPlayer { Name = k.playerentry[32].player.FirstName + k.playerentry[32].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName });

                    //Mason Foster LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[34].player.FirstName + k.playerentry[34].player.LastName });

                    //AJ Francis DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName });

                    //Kendall Fuller CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[36].player.FirstName + k.playerentry[36].player.LastName });

                    //Junior Galette LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[38].player.FirstName + k.playerentry[38].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[39].player.FirstName + k.playerentry[39].player.LastName });

                    //Ryan Grant WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[40].player.FirstName + k.playerentry[40].player.LastName });

                    //DeAngelo Hall S 
                    players.Add(new NFLPlayer { Name = k.playerentry[41].player.FirstName + k.playerentry[41].player.LastName });

                    //Maurice Harris WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[42].player.FirstName + k.playerentry[42].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[43].player.FirstName + k.playerentry[43].player.LastName });

                    //Josh Harvcery-Clemons LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[44].player.FirstName + k.playerentry[44].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[45].player.FirstName + k.playerentry[45].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[46].player.FirstName + k.playerentry[46].player.LastName });

                    //Joshua Holsey CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + k.playerentry[47].player.LastName });

                    //Ziggy Hood DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[48].player.FirstName + k.playerentry[48].player.LastName });

                    //Dustin Hopkins K 
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName });

                    //Matthew Ioannidis DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[52].player.FirstName + k.playerentry[52].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[53].player.FirstName + k.playerentry[53].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[55].player.FirstName + k.playerentry[55].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName });

                    //Ryan Kerrigan LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[57].player.FirstName + k.playerentry[57].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName });

                    //Arie Kouandjio G 
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName });

                    //Anthony Lanier DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[60].player.FirstName + k.playerentry[60].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[62].player.FirstName + k.playerentry[62].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[64].player.FirstName + k.playerentry[64].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[65].player.FirstName + k.playerentry[65].player.LastName });

                    //Terrell McClain DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[66].player.FirstName + k.playerentry[66].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[67].player.FirstName + k.playerentry[67].player.LastName });

                    //Colt McCoy QB
                    players.Add(new NFLPlayer { Name = k.playerentry[68].player.FirstName + k.playerentry[68].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[69].player.FirstName + k.playerentry[69].player.LastName });

                    //Stacy McGee DL 
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[71].player.FirstName + k.playerentry[71].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[72].player.FirstName + k.playerentry[72].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName });

                    //Fabian Moreau CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[74].player.FirstName + k.playerentry[74].player.LastName });

                    //Morgan Moses T 
                    players.Add(new NFLPlayer { Name = k.playerentry[75].player.FirstName + k.playerentry[75].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[77].player.FirstName + k.playerentry[77].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[78].player.FirstName + k.playerentry[78].player.LastName });

                    //Josh Norman CB 
                    players.Add(new NFLPlayer { Name = k.playerentry[79].player.FirstName + k.playerentry[79].player.LastName });

                    //Ty Nsekhe T 
                    players.Add(new NFLPlayer { Name = k.playerentry[80].player.FirstName + k.playerentry[80].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName });

                    //Niles Paul TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName });

                    //Samaje Perine RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[83].player.FirstName + k.playerentry[83].player.LastName });

                    //Otha Peters LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[86].player.FirstName + k.playerentry[86].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName });

                    //Brian Quick WR 
                    players.Add(new NFLPlayer { Name = k.playerentry[88].player.FirstName + k.playerentry[88].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[89].player.FirstName + k.playerentry[89].player.LastName });

                    //Jordan Reed TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[90].player.FirstName + k.playerentry[90].player.LastName });

                    //Pete Robertson LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName });

                    //Chase Roullier C 
                    players.Add(new NFLPlayer { Name = k.playerentry[94].player.FirstName + k.playerentry[94].player.LastName });

                    //Brandon Scherff G 
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName });

                    //Alex smith 
                    //players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName });

                    //Preston Smith  LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName });

                    //Fish Smithson S 
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName });

                    //Martrell Spaight LB 
                    players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName });

                    //Jeremy Sprinkle TE 
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName });

                    //Nick Sundberg LS 
                    players.Add(new NFLPlayer { Name = k.playerentry[101].player.FirstName + k.playerentry[101].player.LastName });

                    //DJ Swearinger S 
                    players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName 

                    //Chris Thompson RB 
                    players.Add(new NFLPlayer { Name = k.playerentry[105].player.FirstName + k.playerentry[105].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[106].player.FirstName + k.playerentry[106].player.LastName });
                   // players.Add(new NFLPlayer { Name = k.playerentry[107].player.FirstName + k.playerentry[107].player.LastName });

                    //Zach Vigil LB
                    players.Add(new NFLPlayer { Name = k.playerentry[108].player.FirstName + k.playerentry[108].player.LastName });

                    //Tress way P 
                    players.Add(new NFLPlayer { Name = k.playerentry[109].player.FirstName + k.playerentry[109].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[110].player.FirstName + k.playerentry[110].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[111].player.FirstName + k.playerentry[111].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[112].player.FirstName + k.playerentry[112].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[114].player.FirstName + k.playerentry[114].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[115].player.FirstName + k.playerentry[115].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[117].player.FirstName + k.playerentry[117].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[118].player.FirstName + k.playerentry[118].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[120].player.FirstName + k.playerentry[120].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[122].player.FirstName + k.playerentry[122].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[124].player.FirstName + k.playerentry[124].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName });
                    //players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName });


                    lstView.ItemsSource = players;
                }
            }

        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                lstView.ItemsSource = players;
            }

            else
            {
                lstView.ItemsSource = players.Where(x => x.Name.StartsWith(e.NewTextValue));
            }
        }

    }
}