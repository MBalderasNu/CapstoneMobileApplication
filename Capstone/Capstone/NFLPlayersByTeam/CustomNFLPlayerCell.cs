using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace Capstone.NFLPlayersByTeam
{
     public class CustomNFLPlayerCell : ViewCell
    {

        public CustomNFLPlayerCell()
        {
            //instantiate each of our views
            var image = new Image();
            var nameLabel = new Label();
            var descriptionLabel = new Label();
            var verticaLayout = new StackLayout();
            var horizontalLayout = new StackLayout() { BackgroundColor = Color.FromHex("#323339") };

            //set bindings
            nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
            descriptionLabel.SetBinding(Label.TextProperty, new Binding("Description"));
            image.SetBinding(Image.SourceProperty, new Binding("Image"));

            //Set properties for desired design
            horizontalLayout.Orientation = StackOrientation.Horizontal;
            horizontalLayout.HorizontalOptions = LayoutOptions.Fill;
            image.HorizontalOptions = LayoutOptions.End;
            nameLabel.FontSize = 24;
            nameLabel.TextColor = Color.White;
            descriptionLabel.TextColor = Color.White;

            //add views to the view hierarchy
            verticaLayout.Children.Add(nameLabel);
            verticaLayout.Children.Add(descriptionLabel);
            horizontalLayout.Children.Add(verticaLayout);
            horizontalLayout.Children.Add(image);
           

            // add to parent view
            View = horizontalLayout;
        }

    }
}
