using Capstone.TeamProfilePageData;
using IronWebScraper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Json;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace APITesting
{
    public class Program
    {
        public static void Main(string[] args)
        {

            DataApi d = new DataApi();
            d.Request().Wait();

            // NFLPlayer p = new NFLPlayer();
            // p.test();
            //d.GetPlayerData().Wait();

            //var scraper = new BlogScraper();
            //scraper.Start();
          
         
        }
        
    }

    class BlogScraper : WebScraper
    {
        public override void Init()
        {
            this.LoggingLevel = WebScraper.LogLevel.All;
            this.Request("http://www.espn.com/nfl/team/stats/_/name/atl/atlanta-falcons", Parse);
        }

        public override void Parse(Response response)
        {
            foreach (var title_link in response.Css("li.name a"))
            {
                string strTitle = title_link.TextContentClean;
                Scrape(new ScrapedData() { { "Name:", strTitle } });

              
            }

            if (response.CssExists("div.prev-post > a[href]"))
            {
                var next_page = response.Css("div.prev-post > a[href]")[0].Attributes["href"];
                this.Request(next_page, Parse);
            }
        }
    }

}
