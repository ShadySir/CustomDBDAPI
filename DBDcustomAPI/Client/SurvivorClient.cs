using DBDcustomAPI.Constant;
using DBDcustomAPI.Model;
using Newtonsoft.Json;

namespace DBDcustomAPI.Client
{
    public class SurvivorClient
    {
        private HttpClient _client;
        private static string _address;
        public SurvivorClient()
        {
            _address = Constants.DBDaddress;
            _client = new()
            {
                BaseAddress = new Uri(_address)
            };
        }
        public async Task<List<Survivor>?> GetSurvivorsAsync()
        {
            var responce = await _client.GetAsync("/survivors?lang=en");
            var content = responce.Content.ReadAsStringAsync().Result;
            try
            {
                var result = JsonConvert.DeserializeObject<List<Survivor>>(content);
                return result;
            }
            catch (Exception) { }

            return null;
        }
    }
}
