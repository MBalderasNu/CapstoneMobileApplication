using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.TeamProfilePageData
{
    public class TeamPageViewModel : ViewModelBase
    {

        public IList<NFLTeam> team { get { return NFLTeamData.team; } }

        NFLTeam selectedTeam;
        public NFLTeam SelectedTeam
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
