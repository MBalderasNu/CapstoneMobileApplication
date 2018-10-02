using Capstone.TeamProfilePageData;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using static Capstone.TeamProfilePageData.PlayerStatsModel;

namespace APITesting
{
    public class DataApi
    {
        public async Task<bool> Request()
        {

            string url = "https://api.mysportsfeeds.com/v1.2/pull/nfl/2017-regular/cumulative_player_stats.json?player=deshaun-watson&playerstats=Att,Comp,Yds,TD";

            var testjson = "{\"LastName\":Brady,\"FirstName\":Tom\"}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            String username = "MBalderasNu";
            String password = "Sexyback966";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader r = new StreamReader(stream);
                    string responefromserver = r.ReadToEnd();

                   
                     var k = JsonConvert.DeserializeObject<RootObject>(responefromserver).cumulativeplayerstats;

                     Console.WriteLine(k.playerstatsentry[0].player.FirstName + " " + k.playerstatsentry[0].stats.PassYards.text);

                 

                    return true;


                    //process the response


                }
            }

        }

       
        


    }
}
