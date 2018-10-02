using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone.NFLFantasyPerfectLineups
{
	public class PerfectNFLineupTwentySeventeen : ContentPage
	{
		public PerfectNFLineupTwentySeventeen ()
		{
            ListView listView = new ListView();

            listView.ItemsSource = new string[]{
                      "Draftkings Week One",
                      "Draftkings Week Two",
                      "Draftkings Week Three",
                      "Draftkings Week Four",
                      "Draftkings Week Five",
                      "Draftkings Week Six",
                      "Draftkings Week Seven",
                      "Draftkings Week Eight",
                      "Draftkings Week Nine",
                      "Draftkings Week Ten",
                      "Draftkings Week Eleven",
                      "Draftkings Week Twelve",
                      "Draftkings Week Thirteen",
                      "Draftkings Week Fourteen",
                      "Draftkings Week Fifteen",
                      "Draftkings Week Sixteen",
                      "Draftkings Week Seventeen",

             };


            listView.ItemSelected += ListView_ItemSelected;


            var stacklayout = new StackLayout
            {
                Children = { listView }
            };

            this.Content = stacklayout;
            this.BackgroundColor = Color.FromHex("#323339");
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }

            switch (e.SelectedItem)
            {
                case "Draftkings Week One":
                   
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekOne());
                    break;

                case "Draftkings Week Two":
                  
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekTwo());
                    break;

                case "Draftkings Week Three":
                  
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekThree());
                    break;

                case "Draftkings Week Four":
                    
                     Navigation.PushModalAsync(new TwentySeventeenNFLWeekFour());
                    break;
                case "Draftkings Week Five":
                      
                      Navigation.PushModalAsync(new TwentySeventeenNFLWeekFive());
                    break;

                case "Draftkings Week Six":
                   
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekSix());
                    break;
                case "Draftkings Week Seven":
                   
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekSeven());
                    break;

                case "Draftkings Week Eight":
                    
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekEight());
                    break;
                case "Draftkings Week Nine":
                   
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekNine());
                    break;

                case "Draftkings Week Ten":
                    
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekTen());
                    break;
                case "Draftkings Week Eleven":
                   
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekEleven());
                    break;

                case "Draftkings Week Twelve":
                  
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekTwelve());
                    break;

                case "Draftkings Week Thirteen":
                  
                     Navigation.PushModalAsync(new TwentySeventeenNFLWeekThirteen());
                    break;

                case "Draftkings Week Fourteen":
                    
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekFourteen());
                    break;
                case "Draftkings Week Fifteen":
                  
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekFifteen());
                    break;

                case "Draftkings Week Sixteen":
                    
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekSixteen());
                    break;
                case "Draftkings Week Seventeen":
                   
                    Navigation.PushModalAsync(new TwentySeventeenNFLWeekSeventeen());
                    break;

             

            }

        }
    }
}