using Newtonsoft.Json;

namespace BullSheepFood.Models.FoodApi
{
    public class Links
    {
        [JsonProperty("next")]
        public Next Next { get; set; }
    }
}
