using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LegendRank.Services
{
    public interface ILolIconsApiService
    {
        Task<string> GetProfileIconAsync(int profileIconId);
        Task<string> GetChampionIconAsync(string championId);
        Task<string> GetItemIconAsync(int itemId);
    }
}
