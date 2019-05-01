using Newtonsoft.Json;

namespace BullSheepFood.Models.Food
{
    public class Food
    {
        [JsonProperty("foodId")]
        public string FoodId { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("nutrients")]
        public Nutrients Nutrients { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
