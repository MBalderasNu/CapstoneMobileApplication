using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone
{
	public class SimYearSelection : ContentPage
	{
        Button Year_Selected;
        public SimYearSelection ()
		{
           

            Year_Selected = new Button
            {
                Text = "2017 NFL Simulation"
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
            Navigation.PushModalAsync(new SimGamePage());
        }
    }
}
