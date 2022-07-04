using DBDcustomAPI.Constant;
using DBDcustomAPI.Model;
using Newtonsoft.Json;

namespace DBDcustomAPI.Client
{
    internal class SteamClient
    {
        private HttpClient _client;
        private static string _address;
        private static string _apikey;

        public SteamClient()
        {
            _address = Constants.STaddress;
            _apikey = Constants.STapikey;
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_address);
        }
        public async Task<UserStats?> GetUserStatsForGameAsync(string SteamID)
        {
            var responce = await _client.GetAsync($"/ISteamUserStats/GetUserStatsForGame/v2/?appid=381210&key={_apikey}&steamid={SteamID}");
            var content = responce.Content.ReadAsStringAsync().Result;
            try
            {
                var result = JsonConvert.DeserializeObject<UserStats>(content);
                return result;
            }
            catch (Exception) { }

            return null;
        }
    }
}
