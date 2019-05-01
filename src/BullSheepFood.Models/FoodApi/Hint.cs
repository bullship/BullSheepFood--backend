using Newtonsoft.Json;

namespace BullSheepFood.Models.FoodApi
{
    public class Hint
    {
        [JsonProperty("food")]
        public FoodApi.Food Food { get; set; }

        //[JsonProperty("measures")]
        //public List<Measure> Measures { get; set; }
    }
}
