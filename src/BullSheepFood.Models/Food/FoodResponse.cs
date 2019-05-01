using System.Collections.Generic;
using Newtonsoft.Json;

namespace BullSheepFood.Models.Food
{
    public class FoodResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("parsed")]
        public List<object> Parsed { get; set; }

        [JsonProperty("hints")]
        public List<Hint> Hints { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }
}
