using LegendRank.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LegendRank.Services
{
    public interface ISummonerApi
    {

        [Get("/by-name/{summonerName}?api_key={key}")]
        Task<HttpResponseMessage> GetSummonerByNameAsync(string summonerName, string key);
    }
}
