﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone.NFLFantasyPerfectLineups
{
	public class TwentySeventeenNFLWeekOne : ContentPage
	{
		public TwentySeventeenNFLWeekOne ()
		{
            var picker = new Picker { Title = "Select a Player" };
            picker.SetBinding(Picker.ItemsSourceProperty, "fantasyplayer");
            picker.SetBinding(Picker.SelectedItemProperty, "SelectedTeam");
            picker.ItemDisplayBinding = new Binding("Name");
            picker.TextColor = Color.White;

            var nameLabel = new Label { HorizontalOptions = LayoutOptions.Center };
            nameLabel.SetBinding(Label.TextProperty, "SelectedTeam.Name");
            nameLabel.SetDynamicResource(VisualElement.StyleProperty, "TitleStyle");

            nameLabel.TextColor = Color.White;

            var locationLabel = new Label { FontAttributes = FontAttributes.Italic, HorizontalOptions = LayoutOptions.Center };
            locationLabel.SetBinding(Label.TextProperty, "SelectedTeam.Position");

            locationLabel.TextColor = Color.White;

            var image = new Image { HeightRequest = 200, WidthRequest = 200, HorizontalOptions = LayoutOptions.CenterAndExpand };
            image.SetBinding(Image.SourceProperty, "SelectedTeam.ImageUrl");

            var detailsLabel = new Label();
            detailsLabel.SetBinding(Label.TextProperty, "SelectedTeam.Details");
            detailsLabel.SetDynamicResource(VisualElement.StyleProperty, "BodyStyle");

            detailsLabel.TextColor = Color.White;

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Margin = new Thickness(20),
                    Children =
                    {
                        new Label { Text = "Fantasy Lineups ", FontAttributes = FontAttributes.Bold, FontSize  = 24, HorizontalOptions = LayoutOptions.Center, TextColor = Color.White },
                        picker,
                        nameLabel,
                        locationLabel,
                        image,
                        detailsLabel
                    }
                }
            };

            BindingContext = new FantasyPageViewModel();

            this.BackgroundColor = Color.FromHex("#323339");


        }

    }
	
}