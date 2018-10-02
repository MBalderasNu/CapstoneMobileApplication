using Capstone.NFLPlayersByTeam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Capstone.TeamProfilePageData.PlayerDataModel;

namespace Capstone
{
	public class SportPlayerPage : ContentPage
	{
		public SportPlayerPage ()
		{
            

            ListView listView = new ListView();

            listView.ItemsSource = new string[]{
                      "Arizona Cardinals",
                      "Atlanta Falcons",
                      "Baltimore Ravens",
                      "Buffalo Bills",
                      "Carolina Panthers",
                      "Chicago Bears",
                      "Cincinnati Bengals",
                      "Cleveland Browns",
                      "Dallas Cowboys",
                      "Denver Broncos",
                      "Detroit Lions",
                      "Green Bay Packers",
                      "Houston Texans",
                      "Indianapolis Colts",
                      "Jacksonville Jaguars",
                      "Kansas City Chiefs",
                      "Los Angeles Chargers",
                      "Los Angeles Rams",
                      "Miami Dolphins",
                      "Minnesota Vikings",
                      "New England Patriots",
                      "New Orleans Saints",
                      "New York Giants",
                      "New York Jets",
                      "Oakland Raiders",
                      "Philadelphia Eagles",
                      "Pittsburgh Steelers",
                      "San Francisco 49ers",
                      "Seattle Seahawks",
                      "Tampa Bay Buccaneers",
                      "Tennessee Titans",
                      "Washington Redskins"
             };

            
            listView.ItemSelected += ListView_ItemSelected;


            var stacklayout = new StackLayout
            {
                Children = { listView }
            };

            this.Content = stacklayout;
            this.BackgroundColor = Color.FromHex("#323339");
        }

        
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }

            switch(e.SelectedItem)
            {
                case "Arizona Cardinals":
                   
                    await Navigation.PushModalAsync(new ArizonaCardinalPlayers());
                    break;

                case "Atlanta Falcons":
                   
                    await Navigation.PushModalAsync(new AtlantaFalconsPlayers());
                    break;

                case "Baltimore Ravens":
                   
                    await Navigation.PushModalAsync(new BaltimoreRavensPlayers());
                    break;

                case "Buffalo Bills":
                   
                    await Navigation.PushModalAsync(new BuffaloBillsPlayers());
                    break;
                case "Carolina Panthers":
                   
                    await Navigation.PushModalAsync(new CarolinaPanthersPlayers());
                    break;

                case "Chicago Bears":
                   
                    await Navigation.PushModalAsync(new ChicagoBearsPlayers());
                    break;
                case "Cincinnati Bengals":
                   
                    await Navigation.PushModalAsync(new CincinnatiBengalsPlayers());
                    break;

                case "Cleveland Browns":
                  
                    await Navigation.PushModalAsync(new ClevelandBrownsPlayers());
                    break;
                case "Dallas Cowboys":
                  
                    await Navigation.PushModalAsync(new DallasCowboysPlayers());
                    break;

                case "Denver Broncos":
                  
                    await Navigation.PushModalAsync(new DenverBroncosPlayers());
                    break;
                case "Detroit Lions":
                  
                    await Navigation.PushModalAsync(new DetroitLionsPlayers());
                    break;

                case "Green Bay Packers":
                   
                    await Navigation.PushModalAsync(new GreenBayPackersPlayers());
                    break;

                case "Houston Texans":
                   
                    await Navigation.PushModalAsync(new HoustonTexansPlayers());
                    break;

                case "Indianapolis Colts":
                   
                    await Navigation.PushModalAsync(new IndianapolisColtsPlayers());
                    break;
                case "Jacksonville Jaguars":
                   
                    await Navigation.PushModalAsync(new JacksonvilleJaguarsPlayers());
                    break;

                case "Kansas City Chiefs":
                  
                    await Navigation.PushModalAsync(new KansasCityChiefsPlayers());
                    break;
                case "Los Angeles Chargers":
                
                    await Navigation.PushModalAsync(new LosAngelesChargersPlayers());
                    break;

                case "Los Angeles Rams":
                  
                    await Navigation.PushModalAsync(new LosAngelesRamsPlayers());
                    break;

                case "Miami Dolphins":
                   
                    await Navigation.PushModalAsync(new MiamiDolphinsPlayers());
                    break;

                case "Minnesota Vikings":
                  
                    await Navigation.PushModalAsync(new MinnesotaVikingsPlayers());
                    break;
                case "New England Patriots":
                   
                    await Navigation.PushModalAsync(new NewEnglandPatriotsPlayers());
                    break;

                case "New Orleans Saints":
                    
                    await Navigation.PushModalAsync(new NewOrleansSaintsPlayers());
                    break;

                case "New York Giants":
                   
                    await Navigation.PushModalAsync(new NewYorkGiantsPlayers());
                    break;

                case "New York Jets":
                  
                    await Navigation.PushModalAsync(new NewYorkJetsPlayers());
                    break;

                case "Oakland Raiders":
                  
                    await Navigation.PushModalAsync(new OaklandRaidersPlayers());
                    break;
                case "Philadelphia Eagles":
                 
                   await Navigation.PushModalAsync(new PhiladelphlaEaglesPlayers());
                    break;

                case "Pittsburgh Steelers":
                   
                   await Navigation.PushModalAsync(new PittsburghSteelersPlayers());
                    break;
                case "San Francisco 49ers":
                  
                    await Navigation.PushModalAsync(new SanFrancisco49ersPlayers());
                    break;

                case "Seattle Seahawks":
                  
                   await Navigation.PushModalAsync(new SeattleSeahawksPlayers());
                    break;

                case "Tampa Bay Buccaneers":
                   
                    await Navigation.PushModalAsync(new TampaBayBuccaneersPlayers());
                    break;

                case "Tennessee Titans":
                   
                    await Navigation.PushModalAsync(new TennesseeTitansPlayers());
                    break;

                case "Washington Redskins":
                  
                    await Navigation.PushModalAsync(new WashingtonRedskinsPlayers());
                    break;

            }
            
        }
    }
}