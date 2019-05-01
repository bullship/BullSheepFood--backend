using Newtonsoft.Json;

namespace BullSheepFood.Models.FoodApi
{
    public class Nutrients
    {
        [JsonProperty("ENERC_KCAL")]
        public long EnercKcal { get; set; }

        [JsonProperty("PROCNT")]
        public double Procnt { get; set; }

        [JsonProperty("FAT")]
        public double Fat { get; set; }

        [JsonProperty("CHOCDF")]
        public double Chocdf { get; set; }
    }
}
