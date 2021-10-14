﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.Json.Serialization;

namespace LegendRank.Models
{
    public class Status : BaseModel
    {
        [JsonPropertyName("tier")]
        public string Tier { get; set; }

        [JsonPropertyName("leagueId")]
        public string LeagueId { get; set; }

        [JsonPropertyName("queue")]
        public string Queue { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("entries")]
        public ObservableCollection<Entry> Entries { get; set; }
    }
}
