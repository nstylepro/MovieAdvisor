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
        
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Sales()
        {
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
