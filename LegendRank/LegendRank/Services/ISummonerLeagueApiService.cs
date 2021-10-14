using LegendRank.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LegendRank.Services
{
    public interface ISummonerLeagueApiService
    {
        Task<List<SummonerLeagueDetail>> GetSummonerLeagueAsync(string leagueId);
    }
}
