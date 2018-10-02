using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone
{
	public class StarPlayerSelection : ContentPage
	{
        Button Nflallstar;

		public StarPlayerSelection ()
		{
            Nflallstar = new Button
            {
                Text = "NFL Stars"

            };


            Nflallstar.Clicked += Nflallstar_Clicked;

            var stack = new StackLayout
            {
                Children = { Nflallstar }
            };

            this.Content = stack;
		}

        private async void Nflallstar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NFLAllStarPlayers());
        }
    }
}