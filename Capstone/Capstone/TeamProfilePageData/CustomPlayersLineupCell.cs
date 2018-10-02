using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone.TeamProfilePageData
{
	public class CustomPlayersLineupCell : ViewCell
	{
       

        public CustomPlayersLineupCell ()
		{
            var label1 = new Label
            {
                Text = "Label 1",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };
            label1.SetBinding(Label.TextProperty, new Binding("."));

            var label2 = new Label
            {
                Text = "Label 2",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };

            View = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(15, 5, 5, 15),
                Children = {
                    new StackLayout {
                        Orientation = StackOrientation.Vertical,
                        Children = { label1, label2 }
                    },
                    
                }
            };
        }
	}
}