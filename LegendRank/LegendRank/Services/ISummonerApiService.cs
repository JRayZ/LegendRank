﻿using LegendRank.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace LegendRank.Services
{

    public interface ISummonerApiService
    {
        Task<Summoner> GetSummonerAsync(string summonerName);
    }
}
