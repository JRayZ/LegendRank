using LegendRank.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace LegendRank.Services
{
    public interface IRankingApiService
    {
        Task<ObservableCollection<Ranking>> GetRankingAync(string queue, string tier, string division);
    }
}