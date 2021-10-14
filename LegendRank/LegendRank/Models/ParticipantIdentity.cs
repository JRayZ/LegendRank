using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace LegendRank.Models
{
    public class ParticipantIdentity  : BaseModel
    {
        [JsonPropertyName("participantId")]
        public int ParticipantId { get; set; }

        [JsonPropertyName("player")]
        public Player Player { get; set; }
    }
}
