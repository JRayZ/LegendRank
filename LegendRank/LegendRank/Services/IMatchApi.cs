﻿using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using LegendRank.Models;
using System.Threading.Tasks;

namespace LegendRank.Services
{
    public interface IMatchApi
    {
        [Get("/matchlists/by-account/{accountId}?endIndex=5&beginIndex=0&api_key={key}")]
        Task<HttpResponseMessage> GetMatches(string accountId, string key);

        [Get("/matches/{matchId}?api_key={key}")]
        Task<HttpResponseMessage> GetMatchByIdAsync(string matchId, string key);
    }
}
