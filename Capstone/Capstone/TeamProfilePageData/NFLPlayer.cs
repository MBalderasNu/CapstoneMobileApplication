using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Capstone.TeamProfilePageData
{
    public class NFLPlayer : INotifyPropertyChanged
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string  Image { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

   

}
