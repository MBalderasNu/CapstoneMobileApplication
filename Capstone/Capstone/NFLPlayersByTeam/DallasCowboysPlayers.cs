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
using static Capstone.TeamProfilePageData.PlayerStatsModel;

namespace Capstone.NFLPlayersByTeam
{
	public class DallasCowboysPlayers : ContentPage
	{
        string username = "";
        string password = "";

        public ObservableCollection<NFLPlayer> players { get; set; }

        SearchBar search = new SearchBar();
        ListView lstView;

        public DallasCowboysPlayers ()
		{
            Dallas_Cowboys_Offense();

            Task.Delay(950).Wait();

            players = new ObservableCollection<NFLPlayer>();
            lstView = new ListView();
            lstView.RowHeight = 120;
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

        private async void Dallas_Cowboys_Offense()
        {
            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?team=dallas-cowboys&playerstats=Att,Comp,Yds,TD";
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

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[0].player.FirstName + k.playerstatsentry[0].player.LastName,
                        Description = "Position:" + k.playerstatsentry[0].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[0].player.JerseyNumber


                    });

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[1].player.FirstName + k.playerstatsentry[1].player.LastName,
                        Description = "Position:" + k.playerstatsentry[1].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[1].player.JerseyNumber


                    });

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[2].player.FirstName + k.playerstatsentry[2].player.LastName,
                        Description = "Position:" + k.playerstatsentry[2].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[2].player.JerseyNumber


                    });

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[3].player.FirstName + k.playerstatsentry[3].player.LastName,
                        Description = "Position:" + k.playerstatsentry[3].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[3].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[4].player.FirstName + k.playerstatsentry[4].player.LastName,
                        Description = "Position:" + k.playerstatsentry[4].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[4].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[5].player.FirstName + k.playerstatsentry[5].player.LastName,
                        Description = "Position:" + k.playerstatsentry[5].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[5].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[6].player.FirstName + k.playerstatsentry[6].player.LastName,
                        Description = "Position:" + k.playerstatsentry[6].player.Position +
                       "\nJersey Number:" + k.playerstatsentry[6].player.JerseyNumber


                    });

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[7].player.FirstName + k.playerstatsentry[7].player.LastName,
                        Description = "Position:" + k.playerstatsentry[7].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[7].player.JerseyNumber


                    });

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[8].player.FirstName + k.playerstatsentry[8].player.LastName,
                        Description = "Position:" + k.playerstatsentry[8].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[8].player.JerseyNumber


                    });

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[9].player.FirstName + k.playerstatsentry[9].player.LastName,
                        Description = "Position:" + k.playerstatsentry[9].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[9].player.JerseyNumber


                    });

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[10].player.FirstName + k.playerstatsentry[10].player.LastName,
                        Description = "Position:" + k.playerstatsentry[10].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[6].player.JerseyNumber


                    });

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[11].player.FirstName + k.playerstatsentry[11].player.LastName,
                        Description = "Position:" + k.playerstatsentry[11].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[11].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[12].player.FirstName + k.playerstatsentry[12].player.LastName,
                        Description = "Position:" + k.playerstatsentry[12].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[11].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[13].player.FirstName + k.playerstatsentry[13].player.LastName,
                        Description = "Position:" + k.playerstatsentry[13].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[6].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[14].player.FirstName + k.playerstatsentry[14].player.LastName,
                        Description = "Position:" + k.playerstatsentry[14].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[14].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[15].player.FirstName + k.playerstatsentry[15].player.LastName,
                        Description = "Position:" + k.playerstatsentry[15].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[15].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[16].player.FirstName + k.playerstatsentry[16].player.LastName,
                        Description = "Position:" + k.playerstatsentry[16].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[16].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[17].player.FirstName + k.playerstatsentry[17].player.LastName,
                        Description = "Position:" + k.playerstatsentry[17].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[17].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[18].player.FirstName + k.playerstatsentry[18].player.LastName,
                        Description = "Position:" + k.playerstatsentry[18].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[18].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[19].player.FirstName + k.playerstatsentry[19].player.LastName,
                        Description = "Position:" + k.playerstatsentry[19].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[19].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[20].player.FirstName + k.playerstatsentry[20].player.LastName,
                        Description = "Position:" + k.playerstatsentry[20].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[20].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[21].player.FirstName + k.playerstatsentry[21].player.LastName,
                        Description = "Position:" + k.playerstatsentry[21].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[21].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[22].player.FirstName + k.playerstatsentry[22].player.LastName,
                        Description = "Position:" + k.playerstatsentry[22].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[22].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[23].player.FirstName + k.playerstatsentry[23].player.LastName,
                        Description = "Position:" + k.playerstatsentry[23].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[23].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[24].player.FirstName + k.playerstatsentry[24].player.LastName,
                        Description = "Position:" + k.playerstatsentry[24].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[24].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[25].player.FirstName + k.playerstatsentry[25].player.LastName,
                        Description = "Position:" + k.playerstatsentry[25].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[25].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[26].player.FirstName + k.playerstatsentry[26].player.LastName,
                        Description = "Position:" + k.playerstatsentry[26].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[26].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[27].player.FirstName + k.playerstatsentry[27].player.LastName,
                        Description = "Position:" + k.playerstatsentry[27].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[27].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[28].player.FirstName + k.playerstatsentry[28].player.LastName,
                        Description = "Position:" + k.playerstatsentry[28].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[28].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[29].player.FirstName + k.playerstatsentry[29].player.LastName,
                        Description = "Position:" + k.playerstatsentry[29].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[29].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[30].player.FirstName + k.playerstatsentry[30].player.LastName,
                        Description = "Position:" + k.playerstatsentry[30].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[30].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[31].player.FirstName + k.playerstatsentry[31].player.LastName,
                        Description = "Position:" + k.playerstatsentry[31].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[31].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[32].player.FirstName + k.playerstatsentry[32].player.LastName,
                        Description = "Position:" + k.playerstatsentry[32].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[32].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[33].player.FirstName + k.playerstatsentry[33].player.LastName,
                        Description = "Position:" + k.playerstatsentry[33].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[33].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[34].player.FirstName + k.playerstatsentry[34].player.LastName,
                        Description = "Position:" + k.playerstatsentry[34].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[34].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[35].player.FirstName + k.playerstatsentry[35].player.LastName,
                        Description = "Position:" + k.playerstatsentry[35].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[35].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[36].player.FirstName + k.playerstatsentry[36].player.LastName,
                        Description = "Position:" + k.playerstatsentry[36].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[36].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[37].player.FirstName + k.playerstatsentry[37].player.LastName,
                        Description = "Position:" + k.playerstatsentry[37].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[37].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[38].player.FirstName + k.playerstatsentry[38].player.LastName,
                        Description = "Position:" + k.playerstatsentry[38].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[38].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[39].player.FirstName + k.playerstatsentry[39].player.LastName,
                        Description = "Position:" + k.playerstatsentry[39].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[39].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[40].player.FirstName + k.playerstatsentry[40].player.LastName,
                        Description = "Position:" + k.playerstatsentry[40].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[40].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[41].player.FirstName + k.playerstatsentry[41].player.LastName,
                        Description = "Position:" + k.playerstatsentry[41].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[41].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[42].player.FirstName + k.playerstatsentry[42].player.LastName,
                        Description = "Position:" + k.playerstatsentry[42].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[42].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[43].player.FirstName + k.playerstatsentry[43].player.LastName,
                        Description = "Position:" + k.playerstatsentry[43].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[43].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[44].player.FirstName + k.playerstatsentry[44].player.LastName,
                        Description = "Position:" + k.playerstatsentry[44].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[44].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[45].player.FirstName + k.playerstatsentry[45].player.LastName,
                        Description = "Position:" + k.playerstatsentry[45].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[45].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[46].player.FirstName + k.playerstatsentry[46].player.LastName,
                        Description = "Position:" + k.playerstatsentry[46].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[46].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[47].player.FirstName + k.playerstatsentry[47].player.LastName,
                        Description = "Position:" + k.playerstatsentry[47].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[47].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[48].player.FirstName + k.playerstatsentry[48].player.LastName,
                        Description = "Position:" + k.playerstatsentry[48].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[48].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[49].player.FirstName + k.playerstatsentry[49].player.LastName,
                        Description = "Position:" + k.playerstatsentry[49].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[49].player.JerseyNumber


                    });

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[50].player.FirstName + k.playerstatsentry[50].player.LastName,
                        Description = "Position:" + k.playerstatsentry[50].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[50].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[51].player.FirstName + k.playerstatsentry[51].player.LastName,
                        Description = "Position:" + k.playerstatsentry[51].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[51].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[52].player.FirstName + k.playerstatsentry[52].player.LastName,
                        Description = "Position:" + k.playerstatsentry[52].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[52].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[53].player.FirstName + k.playerstatsentry[53].player.LastName,
                        Description = "Position:" + k.playerstatsentry[53].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[53].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[54].player.FirstName + k.playerstatsentry[54].player.LastName,
                        Description = "Position:" + k.playerstatsentry[54].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[54].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[55].player.FirstName + k.playerstatsentry[55].player.LastName,
                        Description = "Position:" + k.playerstatsentry[55].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[55].player.JerseyNumber


                    });

                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[56].player.FirstName + k.playerstatsentry[56].player.LastName,
                        Description = "Position:" + k.playerstatsentry[56].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[56].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[57].player.FirstName + k.playerstatsentry[57].player.LastName,
                        Description = "Position:" + k.playerstatsentry[57].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[57].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[58].player.FirstName + k.playerstatsentry[58].player.LastName,
                        Description = "Position:" + k.playerstatsentry[58].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[58].player.JerseyNumber


                    });
                    players.Add(new NFLPlayer
                    {
                        Name = k.playerstatsentry[59].player.FirstName + k.playerstatsentry[59].player.LastName,
                        Description = "Position:" + k.playerstatsentry[59].player.Position +
                      "\nJersey Number:" + k.playerstatsentry[59].player.JerseyNumber
                    });
                    //players.Add(new NFLPlayer
                    //{
                    //    Name = k.playerstatsentry[60].player.FirstName + k.playerstatsentry[60].player.LastName,
                    //    Description = "Position:" + k.playerstatsentry[60].player.Position +
                    // "\nJersey Number:" + k.playerstatsentry[60].player.JerseyNumber
                    //});


                    //players.Add(new NFLPlayer
                    //{
                    //    Name = k.playerstatsentry[61].player.FirstName + k.playerstatsentry[61].player.LastName,
                    //    Description = "Position:" + k.playerstatsentry[61].player.Position +
                    //  "\nJersey Number:" + k.playerstatsentry[61].player.JerseyNumber


                    //});
                    //players.Add(new NFLPlayer
                    //{
                    //    Name = k.playerstatsentry[62].player.FirstName + k.playerstatsentry[62].player.LastName,
                    //    Description = "Position:" + k.playerstatsentry[62].player.Position +
                    //  "\nJersey Number:" + k.playerstatsentry[62].player.JerseyNumber


                    //});
                    //players.Add(new NFLPlayer
                    //{
                    //    Name = k.playerstatsentry[63].player.FirstName + k.playerstatsentry[63].player.LastName,
                    //    Description = "Position:" + k.playerstatsentry[63].player.Position +
                    //  "\nJersey Number:" + k.playerstatsentry[63].player.JerseyNumber


                    //});
                    //players.Add(new NFLPlayer
                    //{
                    //    Name = k.playerstatsentry[64].player.FirstName + k.playerstatsentry[64].player.LastName,
                    //    Description = "Position:" + k.playerstatsentry[64].player.Position +
                    //  "\nJersey Number:" + k.playerstatsentry[64].player.JerseyNumber


                    //});
                    //players.Add(new NFLPlayer
                    //{
                    //    Name = k.playerstatsentry[65].player.FirstName + k.playerstatsentry[65].player.LastName,
                    //    Description = "Position:" + k.playerstatsentry[65].player.Position +
                    //  "\nJersey Number:" + k.playerstatsentry[65].player.JerseyNumber


                    //});

                    //players.Add(new NFLPlayer
                    //{
                    //    Name = k.playerstatsentry[66].player.FirstName + k.playerstatsentry[66].player.LastName,
                    //    Description = "Position:" + k.playerstatsentry[66].player.Position +
                    //    "\nJersey Number:" + k.playerstatsentry[66].player.JerseyNumber

                    //});





                    lstView.ItemsSource = players;
                }
            }

        }
    }
}