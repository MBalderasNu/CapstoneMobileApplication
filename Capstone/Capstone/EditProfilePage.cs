using Capstone.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone
{
	public class EditProfilePage : ContentPage
	{
        Entry UserName = new Entry();
        Entry Password = new Entry();

        Picker PlayerOne = new Picker();
        Picker PlayerTwo = new Picker();
        Picker PlayerThree = new Picker();
        Picker PlayerFour = new Picker();
        Picker PlayerFive = new Picker();
        Picker PlayerSix = new Picker();
        Picker PlayerSeven = new Picker();
        Picker FavTeam = new Picker();

        Button UpdateProile, HomeProfile;

        public EditProfilePage(string userId)
        {
           

            GetUserDetail(userId);

            var teams = new List<string>();
            teams.Add("Arizona Cardinals");
            teams.Add("Atlanta Falcons");
            teams.Add("Baltimore Ravens");
            teams.Add("Buffalo Bills");
            teams.Add("Carolina Panthers");
            teams.Add("Chicago Bears");
            teams.Add("Cincinnati Bengals");
            teams.Add("Cleveland Browns");
            teams.Add("Dallas Cowboys");
            teams.Add("Denver Broncos");
            teams.Add("Detroit Lions");
            teams.Add("Green Bay Packers");
            teams.Add("Houston Texans");
            teams.Add("Indianapolis Colts");
            teams.Add("Jacksonville Jaguars");
            teams.Add("Kansas City Chiefs");
            teams.Add("Los Angeles Chargers");
            teams.Add("Los Angeles Rams");
            teams.Add("Miami Dolphins");
            teams.Add("Minnesota Vikings");
            teams.Add("New England Patriots");
            teams.Add("New Orleans Saints");
            teams.Add("New York Giants");
            teams.Add("New York Jets");
            teams.Add("Oakland Raiders");
            teams.Add("Philadelphia Eagles");
            teams.Add("Pittsburgh Steelers");
            teams.Add("San Francisco 49ers");
            teams.Add("Seattle Seahawks");
            teams.Add("Tampa Bay Buccaneers");
            teams.Add("Tennessee Titans");
            teams.Add("Washington Redskins");

            var lineupPlayers = new List<string>();
            lineupPlayers.Add("Drew Brees");
            lineupPlayers.Add("Aaron Rodgers");
            lineupPlayers.Add("Deshaun Watson");
            lineupPlayers.Add("Levon Bell");
            lineupPlayers.Add("Todd Gurley");
            lineupPlayers.Add("	Ezekiel Elliott");
            lineupPlayers.Add("Alshon Jeffery");
            lineupPlayers.Add("Julio Jones");
            lineupPlayers.Add("Antonio Brown");
            lineupPlayers.Add("Odell Beckham Jr");
            lineupPlayers.Add("Rob Gronkowski");
            lineupPlayers.Add("Travis Kelce");
            lineupPlayers.Add("Evan Engram");



            UserName.Placeholder = "Username";
            UserName.PlaceholderColor = Color.White;
            UserName.TextColor = Color.White;


            Password.Placeholder = "Password";
            Password.PlaceholderColor = Color.White;
            Password.TextColor = Color.White;

           
            PlayerOne.TextColor = Color.White;
            PlayerTwo.TextColor = Color.White;
            PlayerThree.TextColor = Color.White;
            PlayerFour.TextColor = Color.White;
            PlayerFive.TextColor = Color.White;
            PlayerSix.TextColor = Color.White;
            PlayerSeven.TextColor = Color.White;
            FavTeam.TextColor = Color.White;

            PlayerOne.ItemsSource = lineupPlayers;
            PlayerTwo.ItemsSource = lineupPlayers;
            PlayerThree.ItemsSource = lineupPlayers;
            PlayerFour.ItemsSource = lineupPlayers;
            PlayerFive.ItemsSource = lineupPlayers;
            PlayerSix.ItemsSource = lineupPlayers;
            PlayerSeven.ItemsSource = lineupPlayers;
            FavTeam.ItemsSource = teams;






            UpdateProile = new Button()
            {
                Text = "Update Profile"
            };

            HomeProfile = new Button()
            {
                Text = "Profile"
            };

            UpdateProile.Clicked += Click_UpdateProfile;
            HomeProfile.Clicked += HomeProfile_Clicked;

            this.BackgroundColor = Color.FromHex("#323339");

            StackLayout stackLayout = new StackLayout
            {
                Children = { UserName, Password, PlayerOne, PlayerTwo, PlayerThree, PlayerFour, PlayerFive, PlayerSix, PlayerSeven, FavTeam, UpdateProile, HomeProfile}
            };

            this.Content = stackLayout;

        }



        DCUsers userDetail;
        public void GetUserDetail(string userId)
        {
            userDetail = HomeSignInPage.data.GetUserName(userId);
            UserName.Text = userDetail.Username;
            Password.Text = userDetail.Password;
            PlayerOne.Title = userDetail.PlayerOne;
            PlayerTwo.Title = userDetail.PlayerTwo;
            PlayerThree.Title = userDetail.PlayerThree;
            PlayerFour.Title= userDetail.PlayerFour;
            PlayerFive.Title = userDetail.PlayerFive;
            PlayerSix.Title = userDetail.PlayerSix;
            PlayerSeven.Title = userDetail.PlayerSeven;
            FavTeam.Title= userDetail.FavTeam;
        }
        async void Click_UpdateProfile(object sender, EventArgs e)
        {
            int i = -1;
            if (UserName.Text != "" && Password.Text != "")
            {
                
                userDetail.Username = UserName.Text;
                userDetail.Password = Password.Text;
                userDetail.PlayerOne = PlayerOne.SelectedItem.ToString();
                userDetail.PlayerTwo = PlayerTwo.SelectedItem.ToString(); 
                userDetail.PlayerThree = PlayerThree.SelectedItem.ToString();
                userDetail.PlayerFour = PlayerFour.SelectedItem.ToString();
                userDetail.PlayerFive = PlayerFive.SelectedItem.ToString();
                userDetail.PlayerSix = PlayerSix.SelectedItem.ToString();
                userDetail.PlayerSeven = PlayerSeven.SelectedItem.ToString();


                i = HomeSignInPage.data.SaveUser(userDetail);
            }


            if (i < 0)
            {
                await DisplayAlert("Update Profile", "Update Fail .. Please try again ", "OK");
            }
            else
            {
                await DisplayAlert("Update Profile", "Profile update Success . ", "OK");
            }
        }

        private void HomeProfile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProfilePage(userDetail.Username));
        }


       
    }
}