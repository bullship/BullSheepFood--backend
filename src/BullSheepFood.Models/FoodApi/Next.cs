using System;
using Newtonsoft.Json;

namespace BullSheepFood.Models.FoodApi
{
    public class Next
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }
    }
}
