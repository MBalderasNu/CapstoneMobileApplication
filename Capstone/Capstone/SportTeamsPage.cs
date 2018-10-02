using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone
{
	public class SportTeamsPage : ContentPage
	{
        Button nflbutton;
		public SportTeamsPage ()
		{

            

            Label profileLabel = new Label
            {
                Text = " Sports ",
                FontSize = 40
            };

            nflbutton = new Button
            {
                Text = "NFL"
            };



            nflbutton.Clicked += Nflbutton_Clicked;



            var stacklayout = new StackLayout
            {
                Children = { profileLabel, nflbutton }
            };

            this.Content = stacklayout;

            this.BackgroundColor = Color.FromHex("#323339");


        }

        private  void Nflbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TeamPage());
        }
    }
}