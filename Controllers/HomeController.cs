using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project0.Models;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text;


namespace Project0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            MatchesModel matches;
            string dateFrom = DateTime.Now.Date.ToString();
            using (var httpClient = new HttpClient())
            {
                UriBuilder uri = new UriBuilder("https://api.football-data.org/v2/matches");
                uri.Path = "v2/matches";
                [DataType(DataType.Date)]
                [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
                string dateTo = DateTime.Now.Date.AddDays(7).ToString();
                string query = $"dateFrom={dateFrom}&dateTo={dateTo}";
                uri.Query = query;
                httpClient.DefaultRequestHeaders.Add("X-Auth-Token", "5f0f87aa7a314f9db4722f38c156d3d3");
                using (HttpResponseMessage response = await httpClient.GetAsync(uri.ToString()))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    matches = JsonConvert.DeserializeObject<MatchesModel>(apiResponse);
                }
            }
                return View(dateFrom);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Fixture()
        {
            return View();
        }

        public IActionResult Live()
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
