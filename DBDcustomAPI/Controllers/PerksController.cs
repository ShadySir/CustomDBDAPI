using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DBDcustomAPI.Model;
using DBDcustomAPI.Client;

namespace DBDcustomAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PerksController : ControllerBase
    {
        [HttpGet(Name = "GetPerks")]
        public List<Perk>? Perks()
        {
            PerkClient client = new PerkClient();
            return client.GetPerksAsync().Result;
        }
    }
}
