using Capstone.TeamProfilePageData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Capstone.NFLFantasyPerfectLineups
{
	public class FantasyPageViewModel : ViewModelBase
	{
        public IList<FantasyTeam> fantasyplayer { get { return FantasyTeamData.fantasyplayer; } }

        FantasyTeam selectedTeam;
        public FantasyTeam SelectedTeam
        {
            get { return selectedTeam; }
            set
            {
                if (selectedTeam != value)
                {
                    selectedTeam = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}