using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieLand.Models;
using Newtonsoft.Json;

namespace MovieLand.Controllers
{
    using MovieLand.Models;

    public class HomeController : Controller
    {

        // this was used originaly to manualy create a twitter access token, then manualy get the twitts from twitter api
        // this + and the commented out index task work to fetch tweets manualy but later i found a better way to display an interactive twitter timeline
        // i saved the code in case somthing goes wrong with the other way and to show the work iv put into this 
        public async Task<string> GetAccessToken()
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.twitter.com/oauth2/token ");
            var customerInfo = Convert.ToBase64String(new UTF8Encoding()
                                      .GetBytes("3nVuSoBZnx6U4vzUxf5w" + ":" + "Bcs59EFbbsdF6Sl9Ng71smgStWEGwXXKSjYvPVt7qys"));
            request.Headers.Add("Authorization", "Basic " + customerInfo);
            request.Content = new StringContent("grant_type=client_credentials",
                                                    Encoding.UTF8, "application/x-www-form-urlencoded");

            HttpResponseMessage response = await httpClient.SendAsync(request);

            string json = await response.Content.ReadAsStringAsync();

            dynamic item = JsonConvert.DeserializeObject<object>(json);
            return item["access_token"];
        }

        // this is commented out but was the former home page with manauly tweet fetching like i explained before
        //IEnumerable<string>
        //public async Task<IActionResult> Index(string userName = "steam_games", int count = 10, string accessToken = "AAAAAAAAAAAAAAAAAAAAAFXzAwAAAAAAMHCxpeSDG1gLNLghVe8d74hl6k4%3DRUMF4xAQLsbeBhTSRrCiQpJtxoGWeyHrDb5te2jpGskWDFW82F")
        //{
            //if (accessToken == null)
            //{
                //accessToken = await GetAccessToken();
            //}

            //var requestUserTimeline = new HttpRequestMessage(HttpMethod.Get,
                //string.Format("https://api.twitter.com/1.1/statuses/user_timeline.json?count={0}&screen_name={1}&trim_user=1&exclude_replies=1", count, userName));

            //requestUserTimeline.Headers.Add("Authorization", "Bearer " + accessToken);
            //var httpClient = new HttpClient();
            //HttpResponseMessage responseUserTimeLine = await httpClient.SendAsync(requestUserTimeline);
            //var serializer = new JavaScriptSerializer();
            //dynamic json = JsonConvert.DeserializeObject<object>(await responseUserTimeLine.Content.ReadAsStringAsync());
            //var enumerableTweets = (json as IEnumerable<dynamic>);

            //if (enumerableTweets == null)
            //{
                //return View();
            //}
            //var tweets = enumerableTweets.ToList();//Select(t => (string)(t["text"].ToString()));
            //return View(tweets);
        //}

        public IActionResult Index()
        {

            //var tweets = GetTweets();
            return View();
        }
        public IActionResult Sales()
        {

            //var tweets = GetTweets();
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       
    }
}
