﻿using System;
using Newtonsoft.Json;

namespace BullSheepFood.Models.Food
{
    public class Measure
    {
        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }
}
