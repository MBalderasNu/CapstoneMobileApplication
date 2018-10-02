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
using static Capstone.TeamProfilePageData.PlayerDataModel;

namespace Capstone.NFLPlayersByTeam
{
	public class AtlantaFalconsPlayers : ContentPage
	{
        string username = "";
        string password = "";
        public static  ObservableCollection<NFLPlayer> players { get; set; }

        SearchBar search = new SearchBar();
        ListView lstView;

        public AtlantaFalconsPlayers ()
		{

            Atlanta_Falcons_Offense();

            Task.Delay(950).Wait();

            players = new ObservableCollection<NFLPlayer>();
            lstView = new ListView();
            lstView.RowHeight = 125;
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
                    players.Add(new NFLPlayer { Name = k.playerentry[2].player.FirstName + "  " + k.playerentry[2].player.LastName, Description= "\n Position:  " + k.playerentry[2].player.Position + " \n 2017-2018 Season  \n TCKL: 68 \t SCK: 0.0 \t FF : 0 \t INT: 1" +
                                                                                                                                                                                                                                          "\n Career VS. Own Division INT: 2 " +
                                                                                                                                                                                                                                          "\n Career VS. NFC Teams INT : 2 " +
                                                                                                                                                                                                                                          "\n Career VS. AFC Teams INT : 0 "
                                                                                                                                                                                                                                          , Image = "Alford_Robert_card.jpg" });

                    //Ricardo Allen S
                    players.Add(new NFLPlayer { Name = k.playerentry[3].player.FirstName + k.playerentry[3].player.LastName, Description = "\n Position:  " + k.playerentry[3].player.Position + " \n 2017-2018 Season  \n TCKL: 54 \t SCK: 0.0 \t FF : 0 \t INT: 1" +
                                                                                                                                                                                                                                          "\n Career VS. Own Division INT: 0 " +
                                                                                                                                                                                                                                          "\n Career VS. NFC Teams INT : 2 " +
                                                                                                                                                                                                                                          "\n Career VS. AFC Teams INT : 1",Image = "Allen_Ricardo_card.jpg" });

                    //Vic Beasley OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[9].player.FirstName + k.playerentry[9].player.LastName, Description = "\n Position:  " + k.playerentry[9].player.Position + " \n 2017-2018 Season  \n TCKL: 29 \t SCK: 5.0 \t FF : 1 \t INT: 0" +
                                                                                                                                                                                                                                          "\n Career VS. Own Division SCK: 2.0 " +
                                                                                                                                                                                                                                          "\n Career VS. NFC Teams SCK : 4.0 " +
                                                                                                                                                                                                                                          "\n Carerr VS. AFC Teams SCK : 0.0", Image = "Beasley_Vic_card.jpg" });

                    //Matt Bosher P
                    players.Add(new NFLPlayer { Name = k.playerentry[12].player.FirstName + k.playerentry[12].player.LastName,Description = "\n Position:  " + k.playerentry[12].player.Position + " \n 2017-2018 Season  \n PUNTS: 53 \t AVG: 44.9 \t LNG : 62 \t IN 20: 19" +
                                                                                                                                                                                                                                          "\n Career VS. Own Division AVG: 45.8 " +
                                                                                                                                                                                                                                          "\n Career VS. NFC Teams AVG : 47.9 " +
                                                                                                                                                                                                                                          "\n Career VS. AFC Teams AVG 41.4", Image = "Bosher_Matt_card.jpg" });


                    //Matt Bryant K
                    players.Add(new NFLPlayer { Name = k.playerentry[16].player.FirstName + k.playerentry[16].player.LastName,Description = "\n Position:  " + k.playerentry[16].player.Position + " \n 2017-2018 Season  \n FGA: 39 \t FGM: 34 \t PCT : 87.2 \t LNG: 57" +
                                                                                                                                                                                                                                          "\n Career VS. Own Division PCT: 88.2 " +
                                                                                                                                                                                                                                          "\n Career VS. NFC Teams PCT : 88.9 " +
                                                                                                                                                                                                                                          "\n Career VS. AFC Teams PCT : 88.9 ", Image = "Bryant_Matt_card.jpg" });



                    //De'Vondre Campbell OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[18].player.FirstName + k.playerentry[18].player.LastName, Description = "\n Position:  " + k.playerentry[18].player.Position + " \n 2017-2018 Season  \n TCKL: 92 \t SCK: 2.0 \t FF : 1 \t INT: 0", Image = "Campbell_DeVondre_card.jpg" });


                    //Adrian Clayborn DE
                    players.Add(new NFLPlayer { Name = k.playerentry[22].player.FirstName + k.playerentry[22].player.LastName, Description = "\n Position:  " + k.playerentry[22].player.Position + " \n 2017-2018 Season  \n TCKL: 21 \t SCK: 9.5 \t FF : 2 \t INT: 0" +
                                                                                                                                                                                                                                          "\n Career VS. Own Division SCK: 1.0 " +
                                                                                                                                                                                                                                          "\n Career VS. NFC Teams SCK: 2.0 " +
                                                                                                                                                                                                                                          "\n Career VS. AFC Teams SCK: 1.0", Image = "Clayborn_Adrian_card.jpg" });

                    //Tevin Coleman RB
                    players.Add(new NFLPlayer { Name = k.playerentry[23].player.FirstName + k.playerentry[23].player.LastName, Description = "\n Position:  " + k.playerentry[23].player.Position + " \n 2017-2018 Season  \n CAR: 156 \t YDS: 628 \t AVG : 4 \t TDS: 5" , Image = "Coleman_Tevin_card.jpg" });

                    //Derrick Coleman FB
                    players.Add(new NFLPlayer { Name = k.playerentry[24].player.FirstName + k.playerentry[24].player.LastName, Description = "\n Position:  " + k.playerentry[24].player.Position + " \n 2017-2018 Season  \n NO DATA AVAILABLE \t  \t \t", Image = "Coleman_Derrick.jpg" });




                    //Devonta Freeman RB
                    players.Add(new NFLPlayer { Name = k.playerentry[33].player.FirstName + k.playerentry[33].player.LastName, Description = "\n Position:  " + k.playerentry[33].player.Position + " \n 2017-2018 Season  \n CAR: 196 \t YDS: 865 \t AVG : 4.4 \t TDS: 7" +
                                                                                                                                                                                                                                          "\n Career VS. Own Division TD: 2 " +
                                                                                                                                                                                                                                          "\n Career VS. NFC Teams TD : 3 " +
                                                                                                                                                                                                                                          "\n Career VS. Outside Division : 1 ", Image = "Freeman_Devonta_card.jpg" });



                    //Taylor Gabriel WR
                    players.Add(new NFLPlayer { Name = k.playerentry[35].player.FirstName + k.playerentry[35].player.LastName, Description = "\n Position:  " + k.playerentry[35].player.Position + " \n 2017-2018 Season  \n REC: 33 \t YDS: 378 \t AVG : 11.5 \t TDS: 1    ",Image = "bio_card_gabriel_taylor.jpg" });



                    //Ben Garland G
                    players.Add(new NFLPlayer { Name = k.playerentry[37].player.FirstName + k.playerentry[37].player.LastName, Description = "\n Position:  " + k.playerentry[37].player.Position + " \n 2017-2018 Season  \n TCKL: 1 \t SCK: 0.0 \t FF : 0 \t INT: 0    ", Image = "bio_card_garlanda_Ben.jpg" });



                    //Marvin Hall WR
                    players.Add(new NFLPlayer { Name = k.playerentry[47].player.FirstName + "   " + k.playerentry[47].player.LastName, Description = "\n Position:  " + k.playerentry[47].player.Position + " \n 2017-2018 Season  \n NO DATA AVAILABLE \t       \t     \t       ",Image = "Hall_Marvin.jpg" });




                    //Justin Hardy WR
                    players.Add(new NFLPlayer { Name = k.playerentry[49].player.FirstName + k.playerentry[49].player.LastName, Description = "\n Position:  " + k.playerentry[49].player.Position + " \n 2017-2018 Season  \n REC: 20 \t YDS: 221 \t AVG : 11 \t TDS: 3" , Image = "Hardy_Justin_card.jpg" });

                    //Sean Harlow OG
                    players.Add(new NFLPlayer { Name = k.playerentry[50].player.FirstName + k.playerentry[50].player.LastName,Description = "\n Position:  " + k.playerentry[50].player.Position + " \n 2017-2018 Season  \n NO DATA AVAILABLE \t          \t         \t         " , Image = "Harlow_Sean.jpg" });

                    //Josh Harris LS
                    players.Add(new NFLPlayer { Name = k.playerentry[51].player.FirstName + k.playerentry[51].player.LastName, Description = "\n Position:  " + k.playerentry[51].player.Position + " \n 2017-2018 Season  \n TCKL: 2 \t SCK: 0.0 \t FF : 0 \t INT: 0" , Image = "Harris_Josh_card.jpg" });


                    //Austin Hooper TE
                    players.Add(new NFLPlayer { Name = k.playerentry[54].player.FirstName + k.playerentry[54].player.LastName, Description = "\n Position:  " + k.playerentry[54].player.Position + " \n 2017-2018 Season  \n REC: 49 \t YDS: 526 \t AVG : 10.7 \t TDS: 3", Image = "Hooper_Austin_card.jpg" });



                    //Kemal Ishamel S
                    players.Add(new NFLPlayer { Name = k.playerentry[56].player.FirstName + k.playerentry[56].player.LastName, Description = "\n Position:  " + k.playerentry[56].player.Position + " \n 2017-2018 Season  \n TCKL: 29 \t SCK: 1.0 \t FF : 0 \t INT: 0" , Image = "Ishmael_Kemal_card.jpg" });



                    //Grady Jarrett DT
                    players.Add(new NFLPlayer { Name = k.playerentry[58].player.FirstName + k.playerentry[58].player.LastName, Description = "\n Position:  " + k.playerentry[58].player.Position + " \n 2017-2018 Season  \n TCKL: 55 \t SCK: 4.0 \t FF : 0 \t INT: 0",
                        Image = "Jarrett_Grady_card.jpg" });


                    //Julio Jones WR
                    players.Add(new NFLPlayer { Name = k.playerentry[59].player.FirstName + k.playerentry[59].player.LastName, Description = "\n Position:  " + k.playerentry[59].player.Position + " \n 2017-2018 Season  \n REC: 88 \t YDS: 1,444 \t AVG : 16.4 \t TDS: 3" +
                                                                                                                                                                                                                                          "\n Career VS. Own Division TDS: 1 " +
                                                                                                                                                                                                                                          "\n Career VS. NFC Teams TDS : 2 " +
                                                                                                                                                                                                                                          "\n Career VS. AFC Teams TDS : 0", Image = "Jones_Julio_card.jpg" });




                    //Deion Jones LB
                    players.Add(new NFLPlayer { Name = k.playerentry[61].player.FirstName + k.playerentry[61].player.LastName, Description = "\n Position:  " + k.playerentry[61].player.Position + " \n 2017-2018 Season  \n TCKL: 138 \t SCK: 1.0 \t FF : 0 \t INT: 3", Image = "Jones_Deion_card.jpg" });




                    //Damontee Kazee CB
                    players.Add(new NFLPlayer { Name = k.playerentry[63].player.FirstName + k.playerentry[63].player.LastName, Description = "\n Position:  " + k.playerentry[63].player.Position + " \n 2017-2018 Season  \n TCKL: 22 \t SCK: 0.0 \t FF : 2 \t INT: 0", Image = "bio_card_kazee_damontae.jpg" });




                    //Alex Mack C
                    players.Add(new NFLPlayer { Name = k.playerentry[70].player.FirstName + k.playerentry[70].player.LastName, Description = "\n Position:  " + k.playerentry[70].player.Position + " \n 2017-2018 Season  \n G:16 \t GS: 16     \t       \t        \t       ", Image = "Mack_Alex_card.jpg" });




                    //Jake Matthews T
                    players.Add(new NFLPlayer { Name = k.playerentry[73].player.FirstName + k.playerentry[73].player.LastName, Description = "\n Position:  " + k.playerentry[73].player.Position + " \n 2017-2018 Season  \n G: 16 \t GS: 16     \t       \t         \t      ", Image = "Matthews_Jake_card.jpg" });



                    //Takkarist McKinely DE 
                    players.Add(new NFLPlayer { Name = k.playerentry[76].player.FirstName + k.playerentry[76].player.LastName, Description = "\n Position:  " + k.playerentry[76].player.Position + " \n 2017-2018 Season  \n TCKL: 20 \t SCK: 6.0 \t FF : 2 \t INT: 0", Image = "McKinley_Takk_Bio_Card.jpg" });



                    //Keanu Neal S
                    players.Add(new NFLPlayer { Name = k.playerentry[81].player.FirstName + k.playerentry[81].player.LastName, Description = "\n Position:  " + k.playerentry[81].player.Position + " \n 2017-2018 Season  \n TCKL: 116 \t SCK: 0.0 \t FF : 3 \t INT: 1", Image = "Neal_Keanu_card.jpg" });

                    //Sharrod Neasman S
                    players.Add(new NFLPlayer { Name = k.playerentry[82].player.FirstName + k.playerentry[82].player.LastName, Description = "\n Position:  " + k.playerentry[82].player.Position + " \n 2017-2018 Season  \n NO DATA AVAILABLE", Image = "Neasman_Sharrod.jpg" });



                    //Dontari Poe NT
                    players.Add(new NFLPlayer { Name = k.playerentry[84].player.FirstName + k.playerentry[84].player.LastName, Description = "\n Position:  " + k.playerentry[84].player.Position + " \n 2017-2018 Season  \n TCKL: 39 \t SCK: 2.5 \t FF : 0 \t INT: 0", Image = "Poe_Dontari.jpg" });

                    //Brian Poole CB
                    players.Add(new NFLPlayer { Name = k.playerentry[85].player.FirstName + k.playerentry[85].player.LastName, Description = "\n Position:  " + k.playerentry[85].player.Position + " \n 2017-2018 Season  \n  NO DATA AVAILABLE", Image = "Poole_Brian.jpg" });


                    //Brooks Reed DE
                    players.Add(new NFLPlayer { Name = k.playerentry[87].player.FirstName + k.playerentry[87].player.LastName, Description = "\n Position:  " + k.playerentry[87].player.Position + " \n 2017-2018 Season  \n TCKL: 41 \t SCK: 4.0 \t FF : 0 \t INT: 0", Image = "Reed_Brooks_card.jpg" });




                    //LaRoy Reynolds LB
                    players.Add(new NFLPlayer { Name = k.playerentry[91].player.FirstName + k.playerentry[91].player.LastName, Description = "\n Position:  " + k.playerentry[91].player.Position + " \n 2017-2018 Season  \n TCKL: 7 \t SCK: 0.0 \t FF : 0 \t INT: 0", Image = "Reynolds_Laroy.jpg" });

                    //Duke Riley OLB
                    players.Add(new NFLPlayer { Name = k.playerentry[92].player.FirstName + k.playerentry[92].player.LastName, Description = "\n Position:  " + k.playerentry[92].player.Position + " \n 2017-2018 Season  \n TCKL: 30 \t SCK: 0.0 \t FF : 0 \t INT: 0" , Image = "Riley_Duke.jpg" });

                    //Andre Roberts WR
                    players.Add(new NFLPlayer { Name = k.playerentry[93].player.FirstName + k.playerentry[93].player.LastName, Description = "\n Position:  " + k.playerentry[93].player.Position + " \n 2017-2018 Season  \n REC: 1 \t YDS: 12 \t AVG : 12 \t TDS: 0", Image = "Roberts_Andre.jpg" });


                    //Ahtyba Rubin DT
                    players.Add(new NFLPlayer { Name = k.playerentry[95].player.FirstName + k.playerentry[95].player.LastName, Description = "\n Position:  " + k.playerentry[95].player.Position + " \n 2017-2018 Season  \n TCKL: 15 \t SCK: 0.0 \t FF : 0 \t INT: 0", Image = "nophotofalcon.jpg" });

                    //Matt Ryan QB
                    players.Add(new NFLPlayer { Name = k.playerentry[96].player.FirstName + k.playerentry[96].player.LastName, Description = "\n Position:  " + k.playerentry[96].player.Position + " \n 2017-2018 Season  \n TDS: 20 \t INT: 12 \t YDS : 4,095  \t RTG: 91.4", Image = "Ryan_Matt_card.jpg" });

                    //Ty Sambrailo OT
                    players.Add(new NFLPlayer { Name = k.playerentry[97].player.FirstName + k.playerentry[97].player.LastName, Description = "\n Position:  " + k.playerentry[97].player.Position + " \n 2017-2018 Season  \n G: 16 \t GS: 2     \t        \t           \t       ", Image = "nophotofalcon.jpg" });

                    //Mohamed Sanu WR
                    players.Add(new NFLPlayer { Name = k.playerentry[98].player.FirstName + k.playerentry[98].player.LastName, Description = "\n Position:  " + k.playerentry[98].player.Position + " \n 2017-2018 Season  \n REC: 67 \t YDS: 703 \t AVG : 10.5 \t TDS: 5", Image = "Sanu_Mohamed_card.jpg" });

                    //Eric Saubert TE
                    players.Add(new NFLPlayer { Name = k.playerentry[99].player.FirstName + k.playerentry[99].player.LastName, Description = "\n Position:  " + k.playerentry[99].player.Position + " \n 2017-2018 Season  \n NO DATA AVAILABLE   \t          \t           \t        ", Image = "Saubert_Eric.jpg" });

                    //Matt Schaub QB
                    players.Add(new NFLPlayer { Name = k.playerentry[100].player.FirstName + k.playerentry[100].player.LastName, Description = "\n Position:  " + k.playerentry[100].player.Position + " \n 2017-2018 Season  \n NO DATA AVAILABLE   \t          \t           \t        ", Image = "Schaub_Matt_card.jpg" });




                    //Ryan Schraeder T
                    players.Add(new NFLPlayer { Name = k.playerentry[102].player.FirstName + k.playerentry[102].player.LastName,Description = "\n Position:  " + k.playerentry[102].player.Position + " \n 2017-2018 Season  \n G: 14 \t GS: 14   \t             \t           \t         ", Image = "Schraeder_Ryan_card.jpg" });

                    //Wes Schweitzer G
                    players.Add(new NFLPlayer { Name = k.playerentry[103].player.FirstName + k.playerentry[103].player.LastName, Description = "\n Position:  " + k.playerentry[103].player.Position + " \n 2017-2018 Season  \n G: 16 \t GS: 16  \t           \t            \t          ", Image = "Schweitzer_Wes.jpg" });

                    //Derrick Shelby  DE
                    players.Add(new NFLPlayer { Name = k.playerentry[104].player.FirstName + k.playerentry[104].player.LastName,Description = "\n Position:  " + k.playerentry[104].player.Position + " \n 2017-2018 Season  \n TCKL: 30 \t SCK: 1.0 \t FF : 0 \t INT: 0", Image = "Shelby_Derrick.jpg" });




                    //Levine Toilolo TE
                    players.Add(new NFLPlayer { Name = k.playerentry[113].player.FirstName + k.playerentry[113].player.LastName, Description = "\n Position:  " + k.playerentry[113].player.Position + " \n 2017-2018 Season  \n REC: 12 \t YDS: 122 \t AVG : 10.2 \t TDS: 1", Image = "Toilolo_Levine_card.jpg" });



                    //Desmond Trufant CB
                    players.Add(new NFLPlayer { Name = k.playerentry[116].player.FirstName + k.playerentry[116].player.LastName, Description = "\n Position:  " + k.playerentry[116].player.Position + " \n 2017-2018 Season  \n TCKL: 41 \t SCK: 1.0 \t FF : 0 \t INT: 2", Image = "Trufant_Desmond_card.jpg" });




                    //Courtney Upshaw DT
                    players.Add(new NFLPlayer { Name = k.playerentry[119].player.FirstName + k.playerentry[119].player.LastName, Description = "\n Position:  " + k.playerentry[119].player.Position + " \n 2017-2018 Season  \n TCKL: 9 \t SCK: 1.0 \t FF : 1 \t INT: 0", Image = "Upshaw_Courtney.jpg" });




                    //Terron Ward RB
                    players.Add(new NFLPlayer { Name = k.playerentry[121].player.FirstName + k.playerentry[121].player.LastName, Description = "\n Position:  " + k.playerentry[121].player.Position + " \n 2017-2018 Season  \n CAR: 30 \t YDS: 129 \t AVG: 4.3 \t TDS: 0", Image = "Ward_Terron_card.jpg" });




                    //Sean Weatherspoon LB
                    players.Add(new NFLPlayer { Name = k.playerentry[123].player.FirstName + k.playerentry[123].player.LastName, Description = "\n Position:  " + k.playerentry[123].player.Position + " \n 2017-2018 Season  \n TCKL: 1 \t SCK: 0.0 \t FF : 0 \t INT: 0", Image = "Sean_Weatherspoon.jpg" });




                    //Nick Williams WR
                    players.Add(new NFLPlayer { Name = k.playerentry[125].player.FirstName + k.playerentry[125].player.LastName, Description = "\n Position:  " + k.playerentry[125].player.Position + " \n 2017-2018 Season  \n REC: 3 \t YDS: 30 \t AVG : 10 \t TDS: 0" , Image = "Williams_Nick_card.jpg" });

                    //Blidi Wreh-Wilson CB
                    players.Add(new NFLPlayer { Name = k.playerentry[126].player.FirstName + k.playerentry[126].player.LastName, Description = "\n Position:  " + k.playerentry[126].player.Position + " \n 2017-2018 Season  \n NO DATA AVAILABLE  \t          \t         \t         ", Image = "Wreh_Wilson_Blidi.jpg" });



                    lstView.ItemsSource = players;
                }
            }

        }
    }
}