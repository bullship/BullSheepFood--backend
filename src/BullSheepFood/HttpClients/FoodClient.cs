using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using BullSheepFood.Models.Food;

namespace BullSheepFood.HttpClients
{
    public class FoodClient
    {
        private readonly HttpClient _client;
        public string ApplicationId { get; set; }
        public string ApplicationKey { get; set; }

        public FoodClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<FoodResponse> Get(string ingredientName)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["app_id"] = ApplicationId;
            query["app_key"] = ApplicationKey;
            query["ingr"] = ingredientName;
            var queryString = query.ToString();

            var response = await _client.GetAsync("?"+queryString);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<FoodResponse>();
        }
    }
}
