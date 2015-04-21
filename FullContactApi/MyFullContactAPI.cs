using System.Net.Http;
using System.Threading.Tasks;
using FullContactApi.FullContactPersonItems;
using Newtonsoft.Json;

namespace FullContactApi
{
    public class MyFullContactApi : IFullContactApi
    {
        private const string UrlBase0 = @"https://api.fullcontact.com/v2/person.json?email=";
        private const string UrlBase1 = @"&apiKey=";

        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public MyFullContactApi(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task<FullContactPerson> LookupPersonByEmailAsync(string email)
        {
            var request = UrlBase0 + email + UrlBase1 + _apiKey;
            var response = await _httpClient.GetStringAsync(request);

            return await Task.Run(() => JsonConvert.DeserializeObject<FullContactPerson>(response));
        }
    }
}
