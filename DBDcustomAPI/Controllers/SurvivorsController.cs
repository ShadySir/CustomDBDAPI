using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DBDcustomAPI.Model;
using DBDcustomAPI.Client;

namespace DBDcustomAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SurvivorsController : ControllerBase
    {
        [HttpGet(Name = "GetSurvivors")]
        public List<Survivor>? Survivors()
        {
            SurvivorClient client = new SurvivorClient();
            return client.GetSurvivorsAsync().Result;
        }
    }
}
