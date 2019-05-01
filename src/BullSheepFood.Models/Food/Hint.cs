using System.Collections.Generic;
using Newtonsoft.Json;

namespace BullSheepFood.Models.Food
{
    public class Hint
    {
        [JsonProperty("food")]
        public Food Food { get; set; }

        //[JsonProperty("measures")]
        //public List<Measure> Measures { get; set; }
    }
}
