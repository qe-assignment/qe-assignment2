using System.Net.Http;
using System.Threading.Tasks;
using FullContactApi.FullContactPersonItems;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nito.AsyncEx;

namespace FullContactApi
{
    public class MyFullContactApi : IFullContactApi
    {
        private const string UrlBase0 = @"https://api.fullcontact.com/v2/person.json?email=";
        private const string UrlBase1 = @"&style=dictionary&apiKey=";

        private readonly string _apiKey;
        private readonly AsyncLock _mutex = new AsyncLock();
        private readonly HttpClient _httpClient;

        public MyFullContactApi(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task<FullContactPerson> LookupPersonByEmailAsync(string email)
        {
            var request = UrlBase0 + email + UrlBase1 + _apiKey;

            string response;
            using (await _mutex.LockAsync())
            {
                response = await _httpClient.GetStringAsync(request);
            }

            var jObject = JsonConvert.DeserializeObject(response);
            jObject.ToString();
            var person = new FullContactPerson();

            return person;
        }
    }
}
