using Capstone.NFLPlayersByTeam;
using Capstone.TeamProfilePageData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Capstone
{
	public class NFLAllStarPlayers : ContentPage
	{
        public  ListView nflstarlineup = new ListView();

        public ObservableCollection<NFLPlayer> player { get; set; }

        public static ArrayList a;

        public NFLAllStarPlayers ()
		{
            

            player = new ObservableCollection<NFLPlayer>();
            a = new ArrayList();
            a.Add("Julio Jones");

            nflstarlineup.RowHeight = 125;
            nflstarlineup.ItemsSource = a; //{ "Julio Jones", "Von Miller", "Antonio Brown" };
            nflstarlineup.ItemTemplate = new DataTemplate(typeof(CustomPlayersLineupCell));



           

            nflstarlineup.ItemTapped += (sender, e) =>
            {
                switch (e.Item)
                {
                    //case "Julio Jones":
                    //    //// MyLineup.playerlineupp.Add(new NFLPlayer{Name = "Julio Jones", Description = "\n 2017-2018 Season  \n REC: 88 \t YDS: 1,444 \t AVG : 16.4 \t TDS: 3" +
                    //    //                                                                                                                      "\n Career VS. Own Division TDS: 1 " +
                    //    //                                                                                                                      "\n Career VS. NFC Teams TDS : 2 " +
                    //    //                                                                                                                      "\n Career VS. AFC Teams TDS : 0", Image = "Jones_Julio_card.jpg"});
                    //    MyLineup.addedlineup.Add("Julio Jones Two");
                    //    MyLineup.playerlineup.ItemsSource = MyLineup.addedlineup;
                    //    DisplayAlert("Tapped", e.Item.ToString() + " row was tapped", "OK");

                       

                    //    Navigation.PushModalAsync(new MyLineup());

                    //    break;
                }
                //await DisplayAlert("Tapped", e.Item + " row was tapped", "OK");
                ((ListView)sender).SelectedItem = null; // de-select the row
            };


            this.Content = nflstarlineup;
        }
	}
}