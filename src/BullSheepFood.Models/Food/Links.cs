using Newtonsoft.Json;

namespace BullSheepFood.Models.Food
{
    public class Links
    {
        [JsonProperty("next")]
        public Next Next { get; set; }
    }
}
