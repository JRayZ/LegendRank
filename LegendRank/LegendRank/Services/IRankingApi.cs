﻿using LegendRank.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LegendRank.Services
{
    public interface IRankingApi
    {
        [Get("/{queue}/{tier}/{division}?page=1&api_key={key}")]
        Task<HttpResponseMessage> GetRankingAync(string queue, string tier, string division, string key);
    }
}
