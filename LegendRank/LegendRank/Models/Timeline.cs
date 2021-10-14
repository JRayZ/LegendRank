using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace LegendRank.Models
{
    public class Timeline : BaseModel
    {
        [JsonPropertyName("participantId")]
        public int ParticipantId { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("lane")]
        public string Lane { get; set; }
    }
}
