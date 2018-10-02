using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone.NFLFantasyPerfectLineups
{
	public class NFLFantasyLineupSelectionPage : ContentPage
	{

        Button Year_Selected;
		public NFLFantasyLineupSelectionPage ()
		{
            Title = "NFL Fantasy";

            Year_Selected = new Button
            {
                Text = "2017 Lineups "
            };

            Year_Selected.Clicked += Year_Selected_Clicked;

            var stacklayout = new StackLayout
            {
                Children = { Year_Selected }
            };


            this.Content = stacklayout;

            this.BackgroundColor = Color.FromHex("#323339");


        }

        private void Year_Selected_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PerfectNFLineupTwentySeventeen());
        }
    }
}