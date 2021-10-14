using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace LegendRank.Models
{
    public class ChampionRoot : BaseModel
    {

        [JsonPropertyName("data")]
        public Dictionary<string, Champion> Data { get; set; }

    }
}
