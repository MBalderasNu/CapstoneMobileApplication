using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone
{
	public class SimGamePage : ContentPage
	{
        //------------AZ Stats----------------
        int azPts = 18;
        int azPassYds = 227;
        int azRushYds = 86;
        int azPtsAllowed = 22;
        int azPassYdsAllowed = 221;
        int azRushYdsAllowed = 89;

        //------------ATL Stats---------------
        int atlPts = 22;
        int atlPassYds = 249;
        int atlRushYds = 115;
        int atlPtsAllowed = 19;
        int atlPassYdsAllowed = 214;
        int atlRushYdsAllowed = 104;

        //--------------Baltimore Stats--------

        int BaltPts;
        int BaltPassYds;
        int BaltRushYds;
        int BaltPtsAllowed;
        int BaltPassYdsAllowed;
        int BaltRushYdsAllowed;

        //--------------Buffalo Bills----------

        int BuffPts;
        int BuffPassYds;
        int BuffRushYds;
        int BuffPtsAllowed;
        int BuffPassYdsAllowed;
        int BuffRushYdsAllowed;

        //--------------Carolina Panthers-------

        int CaroPts;
        int CaroPassYds;
        int CaroRushYds;
        int CaroPtsAllowed;
        int CaroPassYdsAllowed;
        int CaroRushYdsAllowed;

        //--------------Chicago Bears-----------

        int ChiPts;
        int ChiPassYds;
        int ChiRushYds;
        int ChiPtsAllowed;
        int ChiPassYdsAllowed;
        int ChiRushYdsAllowed;
        //-------------Cincinnati Bengals-------

        int CinPts;
        int CinPassYds;
        int CinRushYds;
        int CinPtsAllowed;
        int CinPassYdsAllowed;
        int CinRushYdsAllowed;
        //-------------Cleveland Browns----------

        int ClePts;
        int ClePassYds;
        int CleRushYds;
        int ClePtsAllowed;
        int ClePassYdsAllowed;
        int CleRushYdsAllowed;
        //-------------Dallas Cowboys------------

        int DalPts;
        int DalPassYds;
        int DalRushYds;
        int DalPtsAllowed;
        int DalPassYdsAllowed;
        int DalRushYdsAllowed;
        //-------------Denver Broncos------------

        int DenPts;
        int DenPassYds;
        int DenRushYds;
        int DenPtsAllowed;
        int DenPassYdsAllowed;
        int DenRushYdsAllowed;
        //-------------Detroit Lions--------------

        int DetPts;
        int DetPassYds;
        int DetRushYds;
        int DetPtsAllowed;
        int DetPassYdsAllowed;
        int DetRushYdsAllowed;
        //------------Green Bay Packers------------

        int GrePts;
        int GrePassYds;
        int GreRushYds;
        int GrePtsAllowed;
        int GrePassYdsAllowed;
        int GreRushYdsAllowed;

        //------------Houston Texans--------------

        int HouPts;
        int HouPassYds;
        int HouRushYds;
        int HouPtsAllowed;
        int HouPassYdsAllowed;
        int HouRushYdsAllowed;

        //------------Indianapolis Colts-----------

        int IndPts;
        int IndPassYds;
        int IndRushYds;
        int IndPtsAllowed;
        int IndPassYdsAllowed;
        int IndRushYdsAllowed;

        //------------Jacksonville Jaguars----------

        int JJPts;
        int JJPassYds;
        int JJRushYds;
        int JJPtsAllowed;
        int JJPassYdsAllowed;
        int JJRushYdsAllowed;

        //------------Kansas City Chiefs------------

        int KCPts;
        int KCPassYds;
        int KCRushYds;
        int KCPtsAllowed;
        int KCPassYdsAllowed;
        int KCRushYdsAllowed;

        //------------Los Angeles Chargers-----------

        int LACPts;
        int LACPassYds;
        int LACRushYds;
        int LACPtsAllowed;
        int LACPassYdsAllowed;
        int LACRushYdsAllowed;

        //------------Los Angeles Rams---------------

        int LARPts;
        int LARPassYds;
        int LARRushYds;
        int LARPtsAllowed;
        int LARPassYdsAllowed;
        int LARRushYdsAllowed;

        //------------Miami Dolphins-----------------

        int MIAPts;
        int MIAPassYds;
        int MIARushYds;
        int MIAPtsAllowed;
        int MIAPassYdsAllowed;
        int MIARushYdsAllowed;

        //------------Minnesota Vikings-------------

        int MVPts;
        int MVPassYds;
        int MVRushYds;
        int MVPtsAllowed;
        int MVPassYdsAllowed;
        int MVRushYdsAllowed;

        //------------New England Patroits-----------

        int NEPPts;
        int NEPPassYds;
        int NEPRushYds;
        int NEPPtsAllowed;
        int NEPPassYdsAllowed;
        int NEPRushYdsAllowed;

        //------------New Orleans Saints--------------

        int NOSPts;
        int NOSPassYds;
        int NOSRushYds;
        int NOSPtsAllowed;
        int NOSPassYdsAllowed;
        int NOSRushYdsAllowed;

        //------------New York Giants-----------------

        int NYGPts;
        int NYGPassYds;
        int NYGRushYds;
        int NYGPtsAllowed;
        int NYGPassYdsAllowed;
        int NYGRushYdsAllowed;

        //------------New York Jets-------------------

        int NYJPts;
        int NYJPassYds;
        int NYJRushYds;
        int NYJPtsAllowed;
        int NYJPassYdsAllowed;
        int NYJRushYdsAllowed;

        //------------Oakland Raiders-----------------

        int OakPts;
        int OakPassYds;
        int OakRushYds;
        int OakPtsAllowed;
        int OakPassYdsAllowed;
        int OakRushYdsAllowed;
        //------------Philadelphia Eagles-------------

        int PhiPts;
        int PhiPassYds;
        int PhiRushYds;
        int PhiPtsAllowed;
        int PhiPassYdsAllowed;
        int PhiRushYdsAllowed;
        //------------Pittsburgh Steelers--------------

        int PittPts;
        int PittPassYds;
        int PittRushYds;
        int PittPtsAllowed;
        int PittPassYdsAllowed;
        int PittRushYdsAllowed;
        //------------San Francisco 49ers--------------

        int SanPts;
        int SanPassYds;
        int SanRushYds;
        int SanPtsAllowed;
        int SanPassYdsAllowed;
        int SanRushYdsAllowed;
        //------------Seattle Seahawks-----------------

        int SeaPts;
        int SeaPassYds;
        int SeaRushYds;
        int SeaPtsAllowed;
        int SeaPassYdsAllowed;
        int SeaRushYdsAllowed;
        //------------Tampa Bay Buccaneers--------------

        int TampPts;
        int TampPassYds;
        int TampRushYds;
        int TampPtsAllowed;
        int TampPassYdsAllowed;
        int TampRushYdsAllowed;
        //------------Tennessee Titans-----------------

        int TenPts;
        int TenPassYds;
        int TenRushYds;
        int TenPtsAllowed;
        int TenPassYdsAllowed;
        int TenRushYdsAllowed;
        //------------Washington Redskins--------------
        int WashPts;
        int WashPassYds;
        int WashRushYds;
        int WashPtsAllowed;
        int WashPassYdsAllowed;
        int WashRushYdsAllowed;



        Button runsim = new Button();

        Picker teamOne, teamTwo;

        Label Results = new Label();
       
        public SimGamePage ()
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


            runsim.Text = "Play";
            runsim.Clicked += Runsim_Clicked;

            teamOne = new Picker
            {
                Title = "Select NFL Team",
                TextColor = Color.White
              

            };

            teamTwo = new Picker
            {
                Title = "Select NFL Team",
                TextColor = Color.White
            };

            teamOne.ItemsSource = teams;

            teamTwo.ItemsSource = teams;

            Results.Text = "Final Score";

            this.BackgroundColor = Color.FromHex("#323339");


            async void Runsim_Clicked(object sender, EventArgs e)
            {
                //-----------------------Arizona Cardinals----------------------------------------------------------------------------------------
                if(teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    await DisplayAlert("Test", "omg", "cancel");

                    Results.Text = "Hey";
                   // SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);

                


                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                  

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                  
                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(azPts, azPassYds, azRushYds,azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    
                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, KCPts, KCPassYds, KCRushYds,KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                  
                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                  
                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                   
                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    
                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    
                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                  
                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Arizona Cardinals" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                   

                    SimGame(azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-----------------------------------------AtLANTA FALCONS-----------------------------------------------------------------------------------------------------------------

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);

                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    await DisplayAlert("Test", "omg", "cancel");

                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                  
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                  
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed,OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                  
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed,TampPts, TampPassYds, TampRushYds, TampPtsAllowed,TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Atlanta Falcons" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                { 
                   
                    SimGame(atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //------------------------------------Baltimore ravens-------------------------------

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                   

                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);

                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);


                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                   
                    //SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                  
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                  
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed,JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                  
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                   
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Baltimore Ravens" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    
                    SimGame(BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed,WashPts, WashPassYds, WashRushYds, WashPtsAllowed,WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-------------------------Buffalo Bills------------------------------------------------

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    //await DisplayAlert("Test", "omg", "cancel");
                    //SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, CinPts, CinPassYds, CinRushYds,CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                   
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                   
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, TampPts, TampPassYds, TampRushYds,TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Buffalo Bills" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //----------------------Carolina Panthers-----------------------------

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    //SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, Pts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Carolina Panthers" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //---------------------------------Chicago Bearss----------------

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Chicago Bears" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //------------------------------------------Cincinnati Bengals---------------------------

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    //SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);

                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cincinnati Bengals" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //---------------------------------Cleveland Browns-------------------

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    //SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(ClePts, ClePassYds,CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds,  NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Cleveland Browns" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //--------------------------------Dallas Cowboys---------------------------
                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, BuffPts, BuffPassYds,BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                   // SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, DalPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Dallas Cowboys" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //--------------------------------------Denver Broncos--------------------------------

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed,CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    //SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed); ;
                }


                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds,  NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Denver Broncos" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-----------------Detroit Lions----------------------------------------------------

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);

                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    //SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed  , LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Linos" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, OakPts,OakPassYds,OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Detroit Lions" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //--------------------------------Green Bay Packers-----------------------------------

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed,GreRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    //SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Green Bay Packers" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //--------------------------Houston Texans-----------------------------------------------------------

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);

                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    //SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed,KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed,  NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed,TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Houston Texans" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-----------------------------Indianapolis Colts-----------------------------------------
                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, CinPts, CinPassYds, CinRushYds,CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, ClePts, ClePassYds,CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);

                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    //SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Indianapolis Colts" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-----------------------Jackonville Jaguars----------------------------------------------------------------

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(JJPts,JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                   // SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                    if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonville Jaguars" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Jacksonvile Jaguars" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-----------------Kansas City Chiefs-----------------------------------------

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    //SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, MVPts,  MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, TenPts, TenPassYds, TenRushYds,TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Kansas City Chiefs" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-----------------------------Los Angeles Chargers-------------------

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, DalPts, DalPassYds, DalRushYds,DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, IndPts,IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                   // SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, LACPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed,SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Chargers" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-------------------------------Los Angeles Rams-----------------------------------------

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, TampPts,TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Los Angeles Rams" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //---------------------------------Miami Dolphins--------------------------

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, CinPts, CinPassYds, ChiRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, ClePts, ClePassYds,CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, DalPts,DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    //SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, MIAPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Miami Dolphins" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-----------------------------Minnesota Vikings----------------------

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, azPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, CaroPts, CaroPassYds,CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);

                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    //SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Minnesota Vikings" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //---------------------------New England Patriots-------------------------
                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    //SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New England Patriots" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-------------------------------New Orleans Saints-------------------

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed,NOSRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() ==  "New Orlean Saints" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, TampPts, TampPassYds, TampRushYds, azPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New Orleans Saints" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //---------------------------------New York Giants----------------------------------------

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants " && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }



                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed,TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Giants" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-------------------New York Jets-----------------------------
                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    //SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "New York Jets" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }

                //-----------------Oakland Raiders-----------------------------

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                   // SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Oakland Raiders" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }


                //----------------Philadelphia Eagles--------------------------

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed,CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                   // await DisplayAlert("Test", "omg", "cancel");
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Philadelphia Eagles" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }


                //----------------Pittsburgh Steelers--------------------------

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, BuffPts,BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds,  NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    //await DisplayAlert("Test", "omg", "cancel");
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Pittsburgh Steelers" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }


                //----------------San Francsisco 49ers--------------------------

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed,SanRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francisco 49ers" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed,PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    //SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed,TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "San Francsisco 49ers" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }


                //----------------Seattle Seahawks--------------------------------

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed,LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    //(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Seattle Seahawks" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }


                //---------------Tampa Bay Buccaneers ---------------------------

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed,LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                   // await DisplayAlert("Test", "omg", "cancel");
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tampa Bay Buccaneers" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }


                //--------------Tennessee Titans---------------------------------

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, CinPts, CinPassYds,CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed,PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    //SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Tennessee Titans" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                    SimGame(TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed, WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed);
                }


                //-----------------Washington Redskins-----------------------------

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Arizona Cardinals")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, azPts, azPassYds, azRushYds, azPtsAllowed, azPassYdsAllowed, azRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Atlanta Falcons")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, atlPts, atlPassYds, atlRushYds, atlPtsAllowed, atlPassYdsAllowed, atlRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Baltimore Ravens")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, BaltPts, BaltPassYds, BaltRushYds, BaltPtsAllowed, BaltPassYdsAllowed, BaltRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Buffalo Bills")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, BuffPts, BuffPassYds, BuffRushYds, BuffPtsAllowed, BuffPassYdsAllowed, BuffRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Carolina Panthers")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, CaroPts, CaroPassYds, CaroRushYds, CaroPtsAllowed, CaroPassYdsAllowed, CaroRushYdsAllowed);
                }
                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Chicago Bears")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, ChiPts, ChiPassYds, ChiRushYds, ChiPtsAllowed, ChiPassYdsAllowed, ChiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Cincinnati Bengals")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, CinPts, CinPassYds, CinRushYds, CinPtsAllowed, CinPassYdsAllowed, CinRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Cleveland Browns")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, ClePts, ClePassYds, CleRushYds, ClePtsAllowed, ClePassYdsAllowed, CleRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Dallas Cowboys")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, DalPts, DalPassYds, DalRushYds, DalPtsAllowed, DalPassYdsAllowed, DalRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Denver Broncos")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, DenPts, DenPassYds, DenRushYds, DenPtsAllowed, DenPassYdsAllowed, DenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Detroit Lions")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, DetPts, DetPassYds, DetRushYds, DetPtsAllowed, DetPassYdsAllowed, DetRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Green Bay Packers")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, GrePts, GrePassYds, GreRushYds, GrePtsAllowed, GrePassYdsAllowed, GreRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Houston Texans")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, HouPts, HouPassYds, HouRushYds, HouPtsAllowed, HouPassYdsAllowed, HouRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Indianapolis Colts")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, IndPts, IndPassYds, IndRushYds, IndPtsAllowed, IndPassYdsAllowed, IndRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Jacksonville Jaguars")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, JJPts, JJPassYds, JJRushYds, JJPtsAllowed, JJPassYdsAllowed, JJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Kansas City Chiefs")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, KCPts, KCPassYds, KCRushYds, KCPtsAllowed, KCPassYdsAllowed, KCRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Los Angeles Chargers")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, LACPts, LACPassYds, LACRushYds, LACPtsAllowed, LACPassYdsAllowed, LACRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Washignton Redskins" && teamTwo.SelectedItem.ToString() == "Los Angeles Rams")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, LARPts, LARPassYds, LARRushYds, LARPtsAllowed, LARPassYdsAllowed, LARRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Miami Dolphins")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, MIAPts, MIAPassYds, MIARushYds, MIAPtsAllowed, MIAPassYdsAllowed, MIARushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Minnesota Vikings")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, MVPts, MVPassYds, MVRushYds, MVPtsAllowed, MVPassYdsAllowed, MVRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "New England Patriots")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, NEPPts, NEPPassYds, NEPRushYds, NEPPtsAllowed, NEPPassYdsAllowed, NEPRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "New Orleans Saints")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, NOSPts, NOSPassYds, NOSRushYds, NOSPtsAllowed, NOSPassYdsAllowed, NOSRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "New York Giants")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, NYGPts, NYGPassYds, NYGRushYds, NYGPtsAllowed, NYGPassYdsAllowed, NYGRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "New York Jets")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, NYJPts, NYJPassYds, NYJRushYds, NYJPtsAllowed, NYJPassYdsAllowed, NYJRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Oakland Raiders")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, OakPts, OakPassYds, OakRushYds, OakPtsAllowed, OakPassYdsAllowed, OakRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Philadelphia Eagles")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, PhiPts, PhiPassYds, PhiRushYds, PhiPtsAllowed, PhiPassYdsAllowed, PhiRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Pittsburgh Steelers")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, PittPts, PittPassYds, PittRushYds, PittPtsAllowed, PittPassYdsAllowed, PittRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "San Francisco 49ers")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, SanPts, SanPassYds, SanRushYds, SanPtsAllowed, SanPassYdsAllowed, SanRushYdsAllowed);
                }


                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Seattle Seahawks")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, SeaPts, SeaPassYds, SeaRushYds, SeaPtsAllowed, SeaPassYdsAllowed, SeaRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Tampa Bay Buccaneers")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, TampPts, TampPassYds, TampRushYds, TampPtsAllowed, TampPassYdsAllowed, TampRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Tennessee Titans")
                {
                    SimGame(WashPts, WashPassYds, WashRushYds, WashPtsAllowed, WashPassYdsAllowed, WashRushYdsAllowed, TenPts, TenPassYds, TenRushYds, TenPtsAllowed, TenPassYdsAllowed, TenRushYdsAllowed);
                }

                if (teamOne.SelectedItem.ToString() == "Washington Redskins" && teamTwo.SelectedItem.ToString() == "Washington Redskins")
                {
                   // await DisplayAlert("Test", "omg", "cancel");
                }

            }

            void SimGame(int PtsOne, int PassYdsOne, int RushYdsOne, int PtsAllowedOne, int PassYdsAllowedOne, int RushYdsAllowedOne, int PtsTwo, int PassYdsTwo, int RushYdsTwo, int PtsAllowedTwo, int PassYdsAllowedTwo, int RushYdsAllowedTwo)
            {
                Random rnd = new Random();

                int totalScoreOne = 0;
                int totalScoreTwo = 0;
                int totalPassOne = 0;
                int totalPassTwo = 0;
                int totalRushOne = 0;
                int totalRushTwo = 0;

                //------------------Total Score-------------------------------

                if (PtsAllowedTwo > PtsOne)
                {
                    totalScoreOne = rnd.Next(0, PtsAllowedTwo);
                }
                

                if (PtsAllowedOne > PtsTwo)
                {
                    totalScoreTwo = rnd.Next(0, PtsAllowedOne);
                }

               

                if(PtsOne > PtsAllowedTwo)
                {
               
                    totalScoreOne = rnd.Next(PtsAllowedTwo, PtsOne);
                }
                else
                {
                    totalScoreOne = rnd.Next(PtsOne, PtsAllowedTwo);
                }

                if(PtsTwo > PtsAllowedOne)
                {
                   

                    totalScoreTwo = rnd.Next(PtsAllowedOne, PtsTwo);
                }

                else
                {
                    totalScoreTwo = rnd.Next(PtsTwo, PtsAllowedOne);
                }


                
               if(PtsOne == PtsAllowedTwo)
                {
                    PtsAllowedTwo += 10;

                    totalScoreOne = rnd.Next(PtsOne, PtsAllowedTwo);
                }


               if(PtsTwo == PtsAllowedOne)
                {
                    PtsAllowedOne += 10;

                    totalScoreTwo = rnd.Next(PtsTwo, PtsAllowedOne);
                }
               //----------------------Total Pass---------------------------------
                if(PassYdsAllowedTwo > PassYdsOne)
                {
                    totalPassOne = rnd.Next(0, PassYdsAllowedTwo);
                }
                

                if (PassYdsAllowedOne > PassYdsTwo)
                {
                    totalPassTwo = rnd.Next(0, PassYdsAllowedOne);
                }

               

                if(PassYdsOne > PassYdsAllowedTwo)
                {
               
                    totalPassOne = rnd.Next(PassYdsAllowedTwo, PassYdsOne);
                }
                else
                {
                    totalPassOne = rnd.Next(PassYdsOne, PassYdsAllowedTwo);
                }

                if(PassYdsTwo > PassYdsAllowedOne)
                {
                   

                    totalPassTwo = rnd.Next(PassYdsAllowedOne, PassYdsTwo);
                }

                else
                {
                    totalPassTwo = rnd.Next(PassYdsTwo, PassYdsAllowedOne);
                }


                
               if(PassYdsOne == PassYdsAllowedTwo)
                {
                    PassYdsAllowedTwo += 30;

                    totalPassOne = rnd.Next(PassYdsOne, PassYdsAllowedTwo);
                }


               if(PassYdsTwo == PassYdsAllowedOne)
                {
                    PassYdsAllowedOne += 30;

                    totalPassTwo = rnd.Next(PassYdsTwo, PassYdsAllowedOne);
                }
                //----------------------Total Rush----------------------------------
                if (RushYdsAllowedTwo > RushYdsOne)
                {
                    totalRushOne = rnd.Next(0, RushYdsAllowedTwo);
                }


                if (RushYdsAllowedOne > RushYdsTwo)
                {
                    totalRushTwo = rnd.Next(0, RushYdsAllowedOne);
                }



                if (RushYdsOne > RushYdsAllowedTwo)
                {

                    totalRushOne = rnd.Next(RushYdsAllowedTwo, RushYdsOne);
                }
                else
                {
                    totalRushOne = rnd.Next(RushYdsOne, RushYdsAllowedTwo);
                }

                if (RushYdsTwo > RushYdsAllowedOne)
                {


                    totalRushTwo = rnd.Next(RushYdsAllowedOne, RushYdsTwo);
                }

                else
                {
                    totalRushTwo = rnd.Next(RushYdsTwo, RushYdsAllowedOne);
                }



                if (RushYdsOne == RushYdsAllowedTwo)
                {
                    RushYdsAllowedTwo += 30;

                    totalRushOne = rnd.Next(RushYdsOne, RushYdsAllowedTwo);
                }


                if (RushYdsTwo == RushYdsAllowedOne)
                {
                    RushYdsAllowedOne += 30;

                    totalRushTwo = rnd.Next(RushYdsTwo, RushYdsAllowedOne);
                }

               

                //-------------------------Resutls---------------------------------

                string totalScoreOneTeam = Convert.ToString(totalScoreOne);

                string totalScoreTwoTeam = Convert.ToString(totalScoreTwo);

                string TotalPassOne = Convert.ToString(totalPassOne);

                string TotalPassTwo = Convert.ToString(totalPassTwo);

                string TotalRushOne = Convert.ToString(totalRushOne);

                string TotalRushTwo = Convert.ToString(totalRushTwo);

                Results.Text = "\tFinal Score " + "\n Team One: " + totalScoreOneTeam + "\t   Team Two:" + totalScoreTwoTeam +
                "\n  Team One Passing Yards: \t " + TotalPassOne + "\t  Team Two Passing Yards: " + TotalPassTwo +
                "\n  Team One Rushing Yards: \t " + TotalRushOne + "\t  Team Two Rushing Yards: " + TotalRushTwo;
                Results.HorizontalTextAlignment = TextAlignment.Center;
                Results.TextColor = Color.White;
               
            }

            var stack = new StackLayout
            {
                Children = { teamOne, teamTwo, Results, runsim, }
            };

            this.Content = stack;

        }

       
     
    }
}