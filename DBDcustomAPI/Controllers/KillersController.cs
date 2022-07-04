using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DBDcustomAPI.Model;
using DBDcustomAPI.Client;

namespace DBDcustomAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KillersController : ControllerBase
    {
        [HttpGet(Name = "GetKillers")]
        public List<Killer>? Killers()
        {
            KillerClient client = new KillerClient();
            return client.GetKillersAsync().Result;
        }
    }
}
