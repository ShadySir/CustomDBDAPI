using DBDcustomAPI.Constant;
using DBDcustomAPI.Model;
using Newtonsoft.Json;

namespace DBDcustomAPI.Client
{
    public class KillerClient
    {
        private HttpClient _client;
        private static string _address;
        public KillerClient()
        {
            _address = Constants.DBDaddress;
            _client = new()
            {
                BaseAddress = new Uri(_address)
            };
        }
        public async Task<List<Killer>?> GetKillersAsync()
        {
            var responce = await _client.GetAsync("/killers?lang=en");
            var content = responce.Content.ReadAsStringAsync().Result;
            try
            {
                var result = JsonConvert.DeserializeObject<List<Killer>>(content);
                return result;
            }
            catch (Exception) { }

            return null;
        }
    }
}
