using LegendRank.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendRank.Services
{
    public interface IChampionService
    {
        ChampionRoot GetChampions();
        Champion GetChampion(int championid);
    }
}
