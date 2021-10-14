﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegendRank.Models
{
    public class Summoner : BaseModel
    {
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string Puuid { get; set; }
        public string Name { get; set; }
        public int ProfileIconId { get; set; }
        public string ProfileIcon
        {
            get
            {
                return $"{Config.ProfileIconUrl}{ProfileIconId}.png";
            }
        }
        
        public long RevisionDate { get; set; }
        public int SummonerLevel { get; set; }
    }
}
