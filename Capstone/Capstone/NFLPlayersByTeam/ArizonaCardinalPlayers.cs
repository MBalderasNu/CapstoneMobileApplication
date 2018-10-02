using Capstone.TeamProfilePageData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Capstone.SportDetailPlayerPage;
using static Capstone.TeamProfilePageData.PlayerStatsModel;

namespace Capstone.NFLPlayersByTeam
{

    public class ArizonaCardinalPlayers : ContentPage
    {

        string username = "";
        string password = "";
        public  ObservableCollection<NFLPlayer> players { get; set; }

        SearchBar search = new SearchBar();
        ListView lstView;
        public ArizonaCardinalPlayers()
        {
            Arizona_Cardinals();

            Task.Delay(950).Wait();

            players = new ObservableCollection<NFLPlayer>();
            lstView = new ListView();
            lstView.RowHeight = 140;
            this.Title = "NFL Players";
            lstView.ItemTemplate = new DataTemplate(typeof(CustomNFLPlayerCell));

            


           


            search.Placeholder = "Search";
            search.TextChanged += Search_TextChanged;

            var stack = new StackLayout
            {
                Children = { search, lstView }
            };

            this.Content = stack;
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

        private async void Arizona_Cardinals()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?team=arizona-cardinals&playerstats";
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

                    var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                    //Budda Baker SS
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[0].player.FirstName + k.playerstatsentry[0].player.LastName,
                        Description = "Position:" + k.playerstatsentry[0].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[0].player.JerseyNumber +
                       "\nInt " + k.playerstatsentry[0].stats.Interceptions.text +
                       "\nGames Played: " + k.playerstatsentry[0].stats.GamesPlayed.Text 
                       
                       

                      
                    });

                    //Antoine Bethea SS
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[1].player.FirstName + k.playerstatsentry[1].player.LastName,
                        Description = "Position:" + k.playerstatsentry[1].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[1].player.JerseyNumber +
                       "\nInt : " + k.playerstatsentry[1].stats.Interceptions.text +
                       "\nGames Played: " + k.playerstatsentry[1].stats.GamesPlayed.Text 
                      

                    });

                    //Justin Bethel CB 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[2].player.FirstName + k.playerstatsentry[2].player.LastName,
                        Description = "Position:" + k.playerstatsentry[2].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[2].player.JerseyNumber +
                       "\nInt : " + k.playerstatsentry[2].stats.Interceptions.text +
                       "\nGames Played: " + k.playerstatsentry[2].stats.GamesPlayed.Text 
                    


                    });

                    //Evan Boehm C 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[3].player.FirstName + k.playerstatsentry[3].player.LastName,
                        Description = "Position:" + k.playerstatsentry[3].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[3].player.JerseyNumber +
                       "\nGames Played: " + k.playerstatsentry[3].stats.GamesPlayed.Text 
                      


                    });

                    //Alex Boone T 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[4].player.FirstName + k.playerstatsentry[4].player.LastName,
                        Description = "Position:" + k.playerstatsentry[4].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[4].player.JerseyNumber +
                       "\nGames Played: " + k.playerstatsentry[4].stats.GamesPlayed.Text 
                      


                    });

                    //Tyvon Branch DB 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[5].player.FirstName + k.playerstatsentry[5].player.LastName,
                        Description = "Position:" + k.playerstatsentry[5].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[5].player.JerseyNumber +
                       "\nInt : " + k.playerstatsentry[5].stats.Interceptions.text +
                       "\nGames Played: " + k.playerstatsentry[5].stats.GamesPlayed.Text 
                       


                    });

                    //Aaron Brewer LS
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[6].player.FirstName + k.playerstatsentry[6].player.LastName,
                        Description = "Position:" + k.playerstatsentry[6].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[6].player.JerseyNumber +
                       "\nGames Played: " + k.playerstatsentry[6].stats.GamesPlayed.Text 
                    

                    });

                    //Jaron Brown WR 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[7].player.FirstName + k.playerstatsentry[7].player.LastName,
                        Description = "Position:" + k.playerstatsentry[7].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[7].player.JerseyNumber +
                      "\nRec TD:  " + k.playerstatsentry[7].stats.RecTD.text +
                      "\nRec Yards: " + k.playerstatsentry[7].stats.RecYards.text +
                      "\nGames Played: " + k.playerstatsentry[7].stats.GamesPlayed.Text 
                      


                    });

                    //John Brown WR 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[8].player.FirstName + k.playerstatsentry[8].player.LastName,
                        Description = "Position:" + k.playerstatsentry[8].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[8].player.JerseyNumber +
                      "\nRec TD:  " + k.playerstatsentry[8].stats.RecTD.text +
                      "\nRec Yards: " + k.playerstatsentry[8].stats.RecYards.text +
                      "\nGames Played: " + k.playerstatsentry[8].stats.GamesPlayed.Text 
                      



                    });

                    //Red Bryant DT
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[9].player.FirstName + k.playerstatsentry[9].player.LastName,
                        Description = "Position:" + k.playerstatsentry[9].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[9].player.JerseyNumber +
                      "\nSacks: " + k.playerstatsentry[9].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[9].stats.GamesPlayed.Text 
                      



                    });

                    //Deone Bucannon SS
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[10].player.FirstName + k.playerstatsentry[10].player.LastName,
                        Description = "Position:" + k.playerstatsentry[10].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[10].player.JerseyNumber +
                      "\nTotal Tackles :" + k.playerstatsentry[10].stats.TackleTotal.text +
                      "\nGames Played: " + k.playerstatsentry[10].stats.GamesPlayed.Text 
                       


                    });

                    //Drew Bulter P 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[11].player.FirstName + k.playerstatsentry[11].player.LastName,
                        Description = "Position:" + k.playerstatsentry[11].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[11].player.JerseyNumber +
                      "\nGames Played: " + k.playerstatsentry[11].stats.GamesPlayed.Text 
                     


                    });

                    //Josh Bynes LB 

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[12].player.FirstName + k.playerstatsentry[12].player.LastName,
                        Description = "Position:" + k.playerstatsentry[12].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[12].player.JerseyNumber +
                      "\nTackles :" + k.playerstatsentry[12].stats.TackleTotal.text +
                      "\nTackles for loss:" + k.playerstatsentry[12].stats.TacklesForLoss.text +
                      "\nGames Played: " + k.playerstatsentry[12].stats.GamesPlayed.Text 
                      




                    });

                    //Karlos Dansby LB 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[13].player.FirstName + k.playerstatsentry[13].player.LastName,
                        Description = "Position:" + k.playerstatsentry[13].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[3].player.JerseyNumber +
                      "\nTackles :" + k.playerstatsentry[13].stats.TackleTotal.text +
                      "\nTackles for loss:" + k.playerstatsentry[13].stats.TacklesForLoss.text +
                      "\nGames Played: " + k.playerstatsentry[13].stats.GamesPlayed.Text 
                      


                    });

                    //Phil Dawson K 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[14].player.FirstName + k.playerstatsentry[14].player.LastName,
                        Description = "Position:" + k.playerstatsentry[14].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[14].player.JerseyNumber +
                      "\nGames Played: " + k.playerstatsentry[14].stats.GamesPlayed.Text 
                      



                    });

                    //Justin Dreshcer LS 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[15].player.FirstName + k.playerstatsentry[15].player.LastName,
                        Description = "Position:" + k.playerstatsentry[15].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[15].player.JerseyNumber +
                      "\nGames Played: " + k.playerstatsentry[15].stats.GamesPlayed.Text


                    });

                    //Durell Eskridge FS
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[16].player.FirstName + k.playerstatsentry[16].player.LastName,
                        Description = "Position:" + k.playerstatsentry[16].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[16].player.JerseyNumber +
                      "\nTotal Tackles:" + k.playerstatsentry[16].stats.TackleTotal.text +
                      "\nInt:" + k.playerstatsentry[16].stats.Interceptions.text +
                      "\n Games Played: " + k.playerstatsentry[16].stats.GamesPlayed.Text


                    });

                    //Larry Fitzgerald WR 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[17].player.FirstName + k.playerstatsentry[17].player.LastName,
                        Description = "Position:" + k.playerstatsentry[17].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[17].player.JerseyNumber +
                      "\nRec Yards:" + k.playerstatsentry[17].stats.RecYards.text +
                      "\nRec TDs:" + k.playerstatsentry[17].stats.RecTD.text +
                      "\nGames Played: " + k.playerstatsentry[17].stats.GamesPlayed.Text


                    });

                    //Jacoby Ford WR
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[18].player.FirstName + k.playerstatsentry[18].player.LastName,
                        Description = "Position:" + k.playerstatsentry[18].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[18].player.JerseyNumber +
                      "\nRec Yards:" + k.playerstatsentry[18].stats.RecYards.text +
                      "\nRec TDs:" + k.playerstatsentry[18].stats.RecTD.text +
                      "\nGames Played: " + k.playerstatsentry[18].stats.GamesPlayed.Text


                    });

                    //Rudy Ford CB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[19].player.FirstName + k.playerstatsentry[19].player.LastName,
                        Description = "Position:" + k.playerstatsentry[19].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[19].player.JerseyNumber +
                      "\nTotal Tackles:" + k.playerstatsentry[19].stats.TackleTotal.text +
                      "\nInt:" + k.playerstatsentry[19].stats.Interceptions.text +
                      "\nGames Played: " + k.playerstatsentry[19].stats.GamesPlayed.Text


                    });

                    //DJ Foster RB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[20].player.FirstName + k.playerstatsentry[20].player.LastName,
                        Description = "Position:" + k.playerstatsentry[20].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[20].player.JerseyNumber +
                      "\nRush Average:" + k.playerstatsentry[20].stats.RushAverage.text +
                      "\nRush Yards:" + k.playerstatsentry[20].stats.RushYards.text +
                      "\nRush TDs:" + k.playerstatsentry[20].stats.RushTD.text +
                      "\nGames Played: " + k.playerstatsentry[20].stats.GamesPlayed.Text


                    });

                    //Blaine Gabbert QB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[21].player.FirstName + k.playerstatsentry[21].player.LastName,
                        Description = "Position:" + k.playerstatsentry[21].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[21].player.JerseyNumber +
                      "\nQBR:" + k.playerstatsentry[21].stats.QBRating.text +
                      "\nPass Yards:" + k.playerstatsentry[21].stats.PassYards.text +
                      "\nPass TDs:" + k.playerstatsentry[21].stats.PassTD.text +
                      "\nGames Played: " + k.playerstatsentry[21].stats.GamesPlayed.Text


                    });

                    //Brittan Golden WR
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[22].player.FirstName + k.playerstatsentry[22].player.LastName,
                        Description = "Position:" + k.playerstatsentry[22].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[22].player.JerseyNumber +
                      "\nRec Yards:" + k.playerstatsentry[22].stats.RecYards.text +
                      "\nRec TDs:" + k.playerstatsentry[22].stats.RecTD.text +
                      "\nGames Played: " + k.playerstatsentry[22].stats.GamesPlayed.Text


                    });

                    //Jermaine Gresham TE
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[23].player.FirstName + k.playerstatsentry[23].player.LastName,
                        Description = "Position:" + k.playerstatsentry[23].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[23].player.JerseyNumber +
                      "\nRec Yards:" + k.playerstatsentry[23].stats.RecYards.text +
                      "\nRec TDs:" + k.playerstatsentry[23].stats.RecTD.text +
                      "\nGames Played: " + k.playerstatsentry[23].stats.GamesPlayed.Text


                    });

                    //Rodney Gunter NT 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[24].player.FirstName + k.playerstatsentry[24].player.LastName,
                        Description = "Position:" + k.playerstatsentry[24].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[24].player.JerseyNumber +
                      "\nTacles:" + k.playerstatsentry[24].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[24].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[24].stats.GamesPlayed.Text


                    });

                    //Bronson Hill RB 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[25].player.FirstName + k.playerstatsentry[25].player.LastName,
                        Description = "Position:" + k.playerstatsentry[25].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[25].player.JerseyNumber +
                      "\nRush Yards:" + k.playerstatsentry[25].stats.RushYards.text +
                      "\nRush TDs:" + k.playerstatsentry[25].stats.RushTD.text +
                      "\nGames Played: " + k.playerstatsentry[25].stats.GamesPlayed.Text


                    });

                    //Will Holden T 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[26].player.FirstName + k.playerstatsentry[26].player.LastName,
                        Description = "Position:" + k.playerstatsentry[26].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[26].player.JerseyNumber +
                      "\nGames Played: " + k.playerstatsentry[26].stats.GamesPlayed.Text


                    });

                    //Gabe Holmes TE
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[27].player.FirstName + k.playerstatsentry[27].player.LastName,
                        Description = "Position:" + k.playerstatsentry[27].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[27].player.JerseyNumber +
                      "\nRec Yards:" + k.playerstatsentry[27].stats.RecYards.text +
                      "\nRec TDs:" + k.playerstatsentry[27].stats.RecTD.text +
                      "\nGames Played: " + k.playerstatsentry[27].stats.GamesPlayed.Text


                    });

                    //DJ Humphries OT
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[28].player.FirstName + k.playerstatsentry[28].player.LastName,
                        Description = "Position:" + k.playerstatsentry[28].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[28].player.JerseyNumber +
                      "\nGames Played: " + k.playerstatsentry[28].stats.GamesPlayed.Text


                    });

                    //Mike Lupati G 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[29].player.FirstName + k.playerstatsentry[29].player.LastName,
                        Description = "Position:" + k.playerstatsentry[29].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[29].player.JerseyNumber +
                      "\nGames Played: " + k.playerstatsentry[29].stats.GamesPlayed.Text


                    });

                    //Chris Johnson RB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[30].player.FirstName + k.playerstatsentry[30].player.LastName,
                        Description = "Position:" + k.playerstatsentry[30].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[30].player.JerseyNumber +
                      "\nRush Yards:" + k.playerstatsentry[30].stats.RushYards.text +
                      "\nRush TDs:" + k.playerstatsentry[30].stats.RushTD.text +
                      "\nGames Played: " + k.playerstatsentry[30].stats.GamesPlayed.Text


                    });

                    //David Johnson RB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[31].player.FirstName + k.playerstatsentry[31].player.LastName,
                        Description = "Position:" + k.playerstatsentry[31].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[31].player.JerseyNumber +
                      "\nRush Yards:" + k.playerstatsentry[31].stats.RushYards.text +
                      "\nRush TDs:" + k.playerstatsentry[31].stats.RushTD.text +
                      "\nGames Played: " + k.playerstatsentry[31].stats.GamesPlayed.Text


                    });

                    //TreVon Johnson LB 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[32].player.FirstName + k.playerstatsentry[32].player.LastName,
                        Description = "Position:" + k.playerstatsentry[32].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[32].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[32].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[32].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[32].stats.GamesPlayed.Text


                    });

                    //Chandler Jones DE
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[33].player.FirstName + k.playerstatsentry[33].player.LastName,
                        Description = "Position:" + k.playerstatsentry[33].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[33].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[33].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[33].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[33].stats.GamesPlayed.Text


                    });

                    //Andy lee P 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[34].player.FirstName + k.playerstatsentry[34].player.LastName,
                        Description = "Position:" + k.playerstatsentry[34].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[34].player.JerseyNumber +
                      "\nGames Played: " + k.playerstatsentry[34].stats.GamesPlayed.Text


                    });

                    //Gabe Martin LB 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[35].player.FirstName + k.playerstatsentry[35].player.LastName,
                        Description = "Position:" + k.playerstatsentry[35].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[35].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[35].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[35].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[35].stats.GamesPlayed.Text


                    });

                    //Kareem Martin DE
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[36].player.FirstName + k.playerstatsentry[36].player.LastName,
                        Description = "Position:" + k.playerstatsentry[36].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[36].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[36].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[36].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[36].stats.GamesPlayed.Text


                    });

                    //Tyrann Mathieu FS
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[37].player.FirstName + k.playerstatsentry[37].player.LastName,
                        Description = "Position:" + k.playerstatsentry[37].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[37].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[37].stats.TackleTotal.text +
                      "\nInt:" + k.playerstatsentry[37].stats.Interceptions.text +
                      "\nGames Played: " + k.playerstatsentry[37].stats.GamesPlayed.Text


                    });

                    //Evan Mathis G 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[38].player.FirstName + k.playerstatsentry[38].player.LastName,
                        Description = "Position:" + k.playerstatsentry[38].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[38].player.JerseyNumber +
                      "\nGames Played: " + k.playerstatsentry[38].stats.GamesPlayed.Text


                    });

                    //Josh Mauro DE
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[39].player.FirstName + k.playerstatsentry[39].player.LastName,
                        Description = "Position:" + k.playerstatsentry[39].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[39].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[39].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[39].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[39].stats.GamesPlayed.Text



                    });
                    //Harlan Miller CB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[40].player.FirstName + k.playerstatsentry[40].player.LastName,
                        Description = "Position:" + k.playerstatsentry[40].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[40].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[40].stats.TackleTotal.text +
                      "\nInt:" + k.playerstatsentry[40].stats.Interceptions.text +
                      "\nGames Played: " + k.playerstatsentry[40].stats.GamesPlayed.Text


                    });
                    //Ifeanyi Momah TE
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[41].player.FirstName + k.playerstatsentry[41].player.LastName,
                        Description = "Position:" + k.playerstatsentry[41].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[41].player.JerseyNumber +
                      "\nRec Yards:" + k.playerstatsentry[41].stats.RushAverage.text +
                      "\nRec TDs:" + k.playerstatsentry[41].stats.RushYards.text +
                      "\nGames Played: " + k.playerstatsentry[41].stats.GamesPlayed.Text


                    });

                    //JJ Nelson WR
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[42].player.FirstName + k.playerstatsentry[42].player.LastName,
                        Description = "Position:" + k.playerstatsentry[42].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[42].player.JerseyNumber +
                      "\nRec Yards:" + k.playerstatsentry[42].stats.RushAverage.text +
                      "\nRec TDs:" + k.playerstatsentry[42].stats.RushYards.text +
                      "\nGames Played: " + k.playerstatsentry[42].stats.GamesPlayed.Text


                    });

                    //Troy Nikias TE
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[43].player.FirstName + k.playerstatsentry[43].player.LastName,
                        Description = "Position:" + k.playerstatsentry[43].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[43].player.JerseyNumber +
                      "\nRec Yards:" + k.playerstatsentry[43].stats.RushAverage.text +
                      "\nRec TDs:" + k.playerstatsentry[43].stats.RushYards.text +
                      "\nGames Played: " + k.playerstatsentry[43].stats.GamesPlayed.Text


                    });

                    //Robert Nkemdiche DT
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[44].player.FirstName + k.playerstatsentry[44].player.LastName,
                        Description = "Position:" + k.playerstatsentry[44].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[44].player.JerseyNumber


                    });

                    //Carson Palmer QB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[45].player.FirstName + k.playerstatsentry[45].player.LastName,
                        Description = "Position:" + k.playerstatsentry[45].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[45].player.JerseyNumber +
                      "\nQBR:" + k.playerstatsentry[45].stats.QBRating.text +
                      "\nPass Yards:" + k.playerstatsentry[45].stats.PassYards.text +
                      "\nPass TDs:" + k.playerstatsentry[45].stats.PassTD.text +
                      "\nGames Played: " + k.playerstatsentry[45].stats.GamesPlayed.Text


                    });

                    //Elijhaa Penny RB 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[46].player.FirstName + k.playerstatsentry[46].player.LastName,
                        Description = "Position:" + k.playerstatsentry[46].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[46].player.JerseyNumber +
                      "\nRush Avg:" + k.playerstatsentry[46].stats.RushAverage.text +
                      "\nRush Yards:" + k.playerstatsentry[46].stats.RushYards.text +
                      "\nRush TDs:" + k.playerstatsentry[46].stats.RushTD.text +
                      "\nGames Played: " + k.playerstatsentry[46].stats.GamesPlayed.Text


                    });
                    //Corey Peters DT
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[47].player.FirstName + k.playerstatsentry[47].player.LastName,
                        Description = "Position:" + k.playerstatsentry[47].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[47].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[47].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[47].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[47].stats.GamesPlayed.Text



                    });
                    //Adrian Peterson RB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[48].player.FirstName + k.playerstatsentry[48].player.LastName,
                        Description = "Position:" + k.playerstatsentry[48].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[48].player.JerseyNumber +
                      "\nRush Avg:" + k.playerstatsentry[48].stats.RushAverage.text +
                      "\nRush Yards:" + k.playerstatsentry[48].stats.RushYards.text +
                      "\nRush TDs:" + k.playerstatsentry[48].stats.RushTD.text +
                      "\nGames Played: " + k.playerstatsentry[48].stats.GamesPlayed.Text


                    });
                    //Patrick Peterson CB 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[49].player.FirstName + k.playerstatsentry[49].player.LastName,
                        Description = "Position:" + k.playerstatsentry[49].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[49].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[49].stats.TackleTotal.text +
                      "\nInt:" + k.playerstatsentry[49].stats.Interceptions.text +
                      "\nGames Played: " + k.playerstatsentry[49].stats.GamesPlayed.Text


                    });

                    //Olsen Pierre DE 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[50].player.FirstName + k.playerstatsentry[50].player.LastName,
                        Description = "Position:" + k.playerstatsentry[50].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[50].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[50].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[50].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[50].stats.GamesPlayed.Text


                    });

                    //Hasson Reddick LB 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[51].player.FirstName + k.playerstatsentry[51].player.LastName,
                        Description = "Position:" + k.playerstatsentry[51].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[51].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[51].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[51].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[51].stats.GamesPlayed.Text


                    });

                    //Shaquille Riddick LB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[52].player.FirstName + k.playerstatsentry[52].player.LastName,
                        Description = "Position:" + k.playerstatsentry[52].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[52].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[52].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[52].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[52].stats.GamesPlayed.Text


                    });

                    //Jumal Rolle CB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[53].player.FirstName + k.playerstatsentry[53].player.LastName,
                        Description = "Position:" + k.playerstatsentry[53].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[53].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[53].stats.TackleTotal.text +
                      "\nInt:" + k.playerstatsentry[53].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[53].stats.GamesPlayed.Text


                    });
                    //Frostee Rucker DE
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[54].player.FirstName + k.playerstatsentry[54].player.LastName,
                        Description = "Position:" + k.playerstatsentry[54].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[54].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[54].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[54].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[54].stats.GamesPlayed.Text


                    });
                    //Ricky Seals-Jones TE
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[55].player.FirstName + k.playerstatsentry[55].player.LastName,
                        Description = "Position:" + k.playerstatsentry[55].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[55].player.JerseyNumber +
                      "\nRec Yards:" + k.playerstatsentry[55].stats.TackleTotal.text +
                      "\nRec TDs:" + k.playerstatsentry[55].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[55].stats.GamesPlayed.Text


                    });
                    //AQ Shipley C
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[56].player.FirstName + k.playerstatsentry[56].player.LastName,
                        Description = "Position:" + k.playerstatsentry[56].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[56].player.JerseyNumber +
                      "\nGames Played: " + k.playerstatsentry[56].stats.GamesPlayed.Text


                    });

                    //Drew Stanton QB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[57].player.FirstName + k.playerstatsentry[57].player.LastName,
                        Description = "Position:" + k.playerstatsentry[57].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[57].player.JerseyNumber +
                      "\nQBR:" + k.playerstatsentry[57].stats.QBRating.text +
                      "\nGames Played: " + k.playerstatsentry[57].stats.GamesPlayed.Text


                    });

                    //Jared Veldheer T
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[58].player.FirstName + k.playerstatsentry[58].player.LastName,
                        Description = "Position:" + k.playerstatsentry[58].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[58].player.JerseyNumber


                    });
                    //Earl Watford G 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[59].player.FirstName + k.playerstatsentry[59].player.LastName,
                        Description = "Position:" + k.playerstatsentry[59].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[59].player.JerseyNumber +
                      "\nGames Played: " + k.playerstatsentry[59].stats.GamesPlayed.Text


                    });
                    //John Wetzel T 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[60].player.FirstName + k.playerstatsentry[60].player.LastName,
                        Description = "Position:" + k.playerstatsentry[60].player.Position +
                     "\nJersey Number:" + k.playerstatsentry[60].player.JerseyNumber +
                     "\nGames Played: " + k.playerstatsentry[60].stats.GamesPlayed.Text


                    });

                    //Brandon Williams CB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[61].player.FirstName + k.playerstatsentry[61].player.LastName,
                        Description = "Position:" + k.playerstatsentry[61].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[61].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[61].stats.TackleTotal.text +
                      "\nInt:" + k.playerstatsentry[61].stats.Interceptions.text +
                      "\nGames Played: " + k.playerstatsentry[61].stats.GamesPlayed.Text


                    });

                    //Chad Williams  WR
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[62].player.FirstName + k.playerstatsentry[62].player.LastName,
                        Description = "Position:" + k.playerstatsentry[62].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[62].player.JerseyNumber +
                      "\nRec Yards:" + k.playerstatsentry[62].stats.RecYards.text +
                      "\nRec TDs:" + k.playerstatsentry[62].stats.RecTD.text +
                      "\nGames Played: " + k.playerstatsentry[62].stats.GamesPlayed.Text


                    });
                    //Kerwynn Williams RB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[63].player.FirstName + k.playerstatsentry[63].player.LastName,
                        Description = "Position:" + k.playerstatsentry[63].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[63].player.JerseyNumber +
                      "\nRush Yards:" + k.playerstatsentry[63].stats.RushYards.text +
                      "\nRush TDs:" + k.playerstatsentry[63].stats.RushTD.text +
                      "\nGames Played: " + k.playerstatsentry[63].stats.GamesPlayed.Text


                    });
                    //Tramon Williams CB
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[64].player.FirstName + k.playerstatsentry[64].player.LastName,
                        Description = "Position:" + k.playerstatsentry[64].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[64].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[64].stats.TackleTotal.text +
                      "\nInt:" + k.playerstatsentry[64].stats.Interceptions.text +
                      "\nGames Played: " + k.playerstatsentry[64].stats.GamesPlayed.Text


                    });
                    //Xavier Williams DT
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[65].player.FirstName + k.playerstatsentry[65].player.LastName,
                        Description = "Position:" + k.playerstatsentry[65].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[65].player.JerseyNumber +
                      "\nTackles:" + k.playerstatsentry[65].stats.TackleTotal.text +
                      "\nSacks:" + k.playerstatsentry[65].stats.Sacks.text +
                      "\nGames Played: " + k.playerstatsentry[65].stats.GamesPlayed.Text


                    });
                    //Scooby Wright ILB 
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[66].player.FirstName + k.playerstatsentry[66].player.LastName,
                        Description = "Position:" + k.playerstatsentry[66].player.Position +
                        "\nJersey Number:" + k.playerstatsentry[66].player.JerseyNumber +
                        "\nTackles:" + k.playerstatsentry[66].stats.TackleTotal.text +
                        "\nSacks:" + k.playerstatsentry[66].stats.Sacks.text +
                        "\nGames Played: " + k.playerstatsentry[66].stats.GamesPlayed.Text

                    });
                   

                   
                    lstView.ItemsSource = players;
                }
            }

        }

    }
}
