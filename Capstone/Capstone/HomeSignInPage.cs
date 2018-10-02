using Capstone.Database;
using Capstone.DatabaseModels;
using System;

using Xamarin.Forms;

namespace Capstone
{
    public class HomeSignInPage : ContentPage
	{
        Entry usernameEntry, passwordEntry;
        Button signinBTN , signupBTN;
        
        public  static DAHelper data = new DAHelper();

        AzureMobileService db = new AzureMobileService();

        public HomeSignInPage()
        {
            Title = "Draft Zone";

            usernameEntry = new Entry
            {
                Placeholder = "Username",
                PlaceholderColor = Color.White,
                TextColor  = Color.White

            };


            passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true,
                PlaceholderColor = Color.White,
                TextColor = Color.White
            };

            signinBTN = new Button
            {
                Text = "Sign In"
               
            };

            signupBTN = new Button
            {
                Text = "Sign Up"
            };

            signupBTN.Clicked += Click_Reg;
            signinBTN.Clicked += Click_Login;

            async void Click_Reg(object sender, EventArgs e)
            {
                await Navigation.PushModalAsync(new SignUpPage());
            }

            async void Click_Login(object sender, EventArgs e)
            {
                DCUsers userDetail = data.GetUsernamenPassword(usernameEntry.Text, passwordEntry.Text);

                if (userDetail != null)
                {
                    if (usernameEntry.Text != userDetail.Username && passwordEntry.Text != userDetail.Password)
                    {
                        await DisplayAlert("Login", "Login failed .. Please try again ", "OK");
                    }
                    else
                    {
                        await DisplayAlert("Login Successful", " Welcome!  ", "OK");
                        await Navigation.PushModalAsync(new ProfilePage(usernameEntry.Text));
                        //await Navigation.PushModalAsync(new CustomPlayerLineupPage());
                    }
                }
                else
                {
                    await DisplayAlert("Login", "Login failed .. Please try again ", "OK");
                }


            }

            this.BackgroundColor = Color.FromHex("#323339");

            StackLayout stackLayout = new StackLayout
            {
                Children = {usernameEntry, passwordEntry, signinBTN, signupBTN}
            };

            
            this.Content = stackLayout;
        }
    }
}