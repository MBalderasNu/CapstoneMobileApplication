using Capstone.NFLPlayersByTeam;
using Capstone.TeamProfilePageData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone
{
	public class CustomPlayerLineupPage : ContentPage
	{
        public static ListView playerlineup;
        public CustomPlayerLineupPage ()
		{
            playerlineup = new ListView();

            playerlineup.ItemsSource = new[] { "a", "b", "c" };
            playerlineup.ItemTemplate = new DataTemplate(typeof(CustomPlayersLineupCell));

            playerlineup.ItemTapped += async (sender, e) => {
                await DisplayAlert("Tapped", e.Item + " row was tapped", "OK");
                ((ListView)sender).SelectedItem = null; // de-select the row
            };

            Padding = new Thickness(0, 20, 0, 0);
            Content = playerlineup;


        }
    }
}