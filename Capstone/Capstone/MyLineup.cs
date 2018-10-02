using Capstone.DatabaseModels;
using Capstone.NFLPlayersByTeam;
using Capstone.TeamProfilePageData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone
{
	public class MyLineup : ContentPage
	{

        public static ObservableCollection<NFLPlayer> playerlineupp { get; set; }

        

        
         public static ListView playerlineup;

         public static NFLPlayer nFlPlayer;

        List<string> lineupPlayers = new List<string>();


        public MyLineup (string username)
		{

            GetUserDetail(username);

        

            Label playerline = new Label
            {
                Text = "Player Lineup",
                FontSize = 30
            };

          
            playerlineup = new ListView();
            playerlineupp = new ObservableCollection<NFLPlayer>();

            

            playerlineup.RowHeight = 125;

            
            playerlineup.ItemTemplate = new DataTemplate(typeof(CustomPlayersLineupCell));
           

            playerlineup.ItemTapped += (sender, e) => {

                //switch(e.Item.ToString())
                //{
                //    case "a":
                //        await DisplayAlert("Tapped", e.Item + " row was tapped", "OK");

                //        break;
                //}


                ((ListView)sender).SelectedItem = null; // de-select the row
            };

            Padding = new Thickness(0, 20, 0, 0);

            //dplayers.Clicked += Addplayers_Clicked;


            var stack = new StackLayout
            {
                Children = {playerline, playerlineup}
            };

            this.Content = stack;
        }

        private void Addplayers_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new StarPlayerSelection());
        }

        DCUsers userDetail;
        public void GetUserDetail(string username)
        {
            userDetail = HomeSignInPage.data.GetUserName(username);
            //serName.Text = " Username: " + userDetail.Username

            lineupPlayers = new List<string>();
            lineupPlayers.Add(userDetail.PlayerOne);
            //lineupPlayers.Add("Deshaun Watson - QB");
            //lineupPlayers.Add("Levon Bell - HB");
            //lineupPlayers.Add("Todd Gurley - HB");
            //lineupPlayers.Add("	Ezekiel Elliott - HB");
            //lineupPlayers.Add("Alshon Jeffery - WR");
            //lineupPlayers.Add("Julio Jones - WR");
            //lineupPlayers.Add("Antonio Brown - WR");
            //lineupPlayers.Add("Rob Gronkowski - TE");
            //lineupPlayers.Add("Travis Kelce - TE");

            playerlineup.ItemsSource = lineupPlayers;


        }
    }
}