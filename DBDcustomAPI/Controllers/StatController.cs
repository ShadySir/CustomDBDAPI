using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DBDcustomAPI.Model;
using DBDcustomAPI.Client;

namespace DBDcustomAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatController : ControllerBase
    {
        [HttpGet(Name = "GetUserStats")]
        public UserStats? userStats(string SteamID)
        {
            SteamClient client = new SteamClient();
            return client.GetUserStatsForGameAsync(SteamID).Result;
        }
    }
}
