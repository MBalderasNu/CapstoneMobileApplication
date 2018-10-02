using Capstone.Database;
using Capstone.DatabaseModels;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone
{
	public class SignUpPage : ContentPage
	{

        Entry userName, passWord;

        Button reg, alreadyreg;

        Picker PlayerOne, PlayerTwo, PlayerThree, PlayerFour, PlayerFive, PlayerSix, PlayerSeven, FavTeam;

        List<TopNFLPlayers> Top = new List<TopNFLPlayers>();


        DAHelper data = new DAHelper();

       

        public ObservableCollection<TopNFLPlayers> players { get; set; }


        public SignUpPage()
        {
           


          

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

            var QBlineup = new List<string>();
            var HBlineup = new List<string>();
            var WRlineup = new List<string>();
            var TElineup = new List<string>();



           // Test();



            userName = new Entry()
            {
                Placeholder = "Username",
                TextColor = Color.White,
                PlaceholderColor = Color.White
            };

            passWord = new Entry()
            {
                Placeholder = "Password",
                IsPassword = true,
                PlaceholderColor = Color.White
            };

            PlayerOne = new Picker()
            {
                Title = "Select QB",
                TextColor = Color.White

            };

            PlayerTwo = new Picker()
            {
                Title = "Select RB",
                 TextColor = Color.White
            };

            PlayerThree = new Picker()
            {
                Title = "Select WR",
                TextColor = Color.White
            };

            PlayerFour = new Picker()
            {
                Title = "Select WR",
                TextColor = Color.White
            };

            PlayerFive = new Picker()
            {
                Title = "Select WR",
                TextColor = Color.White
            };

            PlayerSix = new Picker()
            {
                Title = "Select TE",
                TextColor = Color.White

            };

            PlayerSeven = new Picker()
            {
                Title = "Select FLEX",
                TextColor = Color.White
            };

            FavTeam = new Picker()
            {
                Title = "Select Favorite Team",
                TextColor = Color.White
            };

            reg = new Button
            {
                Text = "Register"
            };


            alreadyreg = new Button
            {
                Text = "Already Registered ? / SignIn"
            };

            reg.Clicked += Click_Reg;
            alreadyreg.Clicked += Click_Login;

            Test();

            //PlayerOne.ItemsSource = lineupPlayers;
            //PlayerTwo.ItemsSource = lineupPlayers;
            //PlayerThree.ItemsSource = lineupPlayers;
            //PlayerFour.ItemsSource = lineupPlayers;
            //PlayerFive.ItemsSource = lineupPlayers;
            //PlayerSix.ItemsSource = lineupPlayers;
            //PlayerSeven.ItemsSource = lineupPlayers;
            //FavTeam.ItemsSource = teams;




            async void Test()
            {
                var client = new MobileServiceClient("https://dconfidentlymobile.azurewebsites.net");

                IMobileServiceTable<TopNFLPlayers> TopTable = client.GetTable<TopNFLPlayers>();

                IMobileServiceTableQuery<TopNFLPlayers> query = TopTable.Take(3);
                List<TopNFLPlayers> items = await query.ToListAsync();

                //QB----------------------------------

                QBlineup.Add("Deshaun Watson");
                QBlineup.Add("Drew Brees");
                QBlineup.Add("Aaron Rodgers");

                PlayerOne.ItemsSource = QBlineup;

                ////HB-----------------------------------

                HBlineup.Add(items[0].FirstName + " " + items[0].LastName);
                HBlineup.Add("Todd Gurley");
                HBlineup.Add("Ezekiel  Elliot");
                //HBlineup.Add(items[3].FirstName + items[3].LastName);
                //HBlineup.Add(items[8].FirstName + items[8].LastName);


                PlayerTwo.ItemsSource = HBlineup;

                ////WR------------------------------------
                WRlineup.Add("Alshon Jeffery");
                WRlineup.Add("Juilo Jones");
                WRlineup.Add("Antonio Brown");
                WRlineup.Add("Odell Beckham Jr");


                PlayerThree.ItemsSource = WRlineup;
                PlayerFour.ItemsSource = WRlineup;
                PlayerFive.ItemsSource = WRlineup;

                ////TE-------------------------------------
                TElineup.Add("Evan Engram");
                TElineup.Add("Travis Kelce");
                TElineup.Add("Rob Gronkowski");

                PlayerSix.ItemsSource = TElineup;

                ////Flex-------------------------------------
                PlayerSeven.ItemsSource = lineupPlayers;


                FavTeam.ItemsSource = teams;



            }

            // PlayerOne.ItemsSource = QBlineup;


            async void Click_Reg(object sender, EventArgs e)
            {
                if (userName.Text != "")
                {
                    DCUsers fileexist = data.GetUserName(userName.Text);
                    if (fileexist == null)
                    {
                        if (userName.Text != "" && passWord.Text != "")
                        {
                            DCUsers OReg = new DCUsers();
                            OReg.Username = userName.Text;
                            OReg.Password = passWord.Text;
                            OReg.PlayerOne = PlayerOne.SelectedItem.ToString();
                            OReg.PlayerTwo = PlayerTwo.SelectedItem.ToString();
                            OReg.PlayerThree = PlayerThree.SelectedItem.ToString();
                            OReg.PlayerFour = PlayerFour.SelectedItem.ToString();
                            OReg.PlayerFive = PlayerFive.SelectedItem.ToString();
                            OReg.PlayerSix = PlayerSix.SelectedItem.ToString();
                            OReg.PlayerSeven = PlayerSeven.SelectedItem.ToString();
                            OReg.FavTeam = FavTeam.SelectedItem.ToString();
                            int i = data.SaveUser(OReg);
                            if (i > 0)
                            {
                                await DisplayAlert("Registration", "Registration Successful...Login ", "OK");
                                await Navigation.PushModalAsync(new HomeSignInPage());
                            }
                            else
                            {
                                await DisplayAlert("Registration", "Registration Fail .. Please try again ", "OK");
                            }
                        }
                    }
                    else
                    {
                        await DisplayAlert("Registration Failed", "username already exist .. Please try differnt user name ", "OK");
                        userName.Text = "";
                        userName.Focus();

                    }
                }
            }

            async void Click_Login(object sender, EventArgs e)
            {
                await Navigation.PushModalAsync(new ProfilePage(userName.Text));
            }

            this.BackgroundColor = Color.FromHex("#323339");

            StackLayout stackLayout = new StackLayout
            {
                Children = {userName, passWord, PlayerOne, PlayerTwo, PlayerThree, PlayerFour, PlayerFive, PlayerSix, PlayerSeven, FavTeam, reg, alreadyreg}
            };

            this.Content = stackLayout;

        }
        

    }
}