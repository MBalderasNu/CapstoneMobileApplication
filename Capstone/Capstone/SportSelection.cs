using Capstone.NFLFantasyPerfectLineups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone
{
	public class SportSelection : ContentPage
	{

        Button NFl_Selection, NFL_FANTASY;
		public SportSelection ()
		{
          

            NFl_Selection = new Button
            {
                Text = " NFL PLAYERS "
            };

            NFL_FANTASY = new Button
            {
                Text = " NFL Fantasy Lineups"
            };

          


            NFl_Selection.Clicked += NFl_Selection_Clicked;

            NFL_FANTASY.Clicked += NFL_FANTASY_Clicked;

          

            var stacklayout = new StackLayout
            {
                Children = { NFl_Selection, NFL_FANTASY }
            };


            this.Content = stacklayout;

            this.BackgroundColor = Color.FromHex("#323339");



        }

        private void NFL_FANTASY_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NFLFantasyLineupSelectionPage());
        }

        private void NFl_Selection_Clicked(object sender, EventArgs e)
        {
          Navigation.PushModalAsync(new SportPlayerPage());
        }
    }
}