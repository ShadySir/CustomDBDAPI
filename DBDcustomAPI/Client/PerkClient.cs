using DBDcustomAPI.Constant;
using DBDcustomAPI.Model;
using Newtonsoft.Json;

namespace DBDcustomAPI.Client
{
    internal class PerkClient
    {
        private HttpClient _client;
        private static string _address;
        public PerkClient()
        {
            _address = Constants.DBDaddress;
            _client = new()
            {
                BaseAddress = new Uri(_address)
            };
        }
        public async Task<List<Perk>?> GetPerksAsync()
        {
            var responce = await _client.GetAsync("/perks?lang=en");
            var content = responce.Content.ReadAsStringAsync().Result;
            try
            {
                var result = JsonConvert.DeserializeObject<List<Perk>>(content);
                return result;
            }
            catch (Exception) { }

            return null;
        }
    }
}
