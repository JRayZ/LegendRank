using LegendRank.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LegendRank.Services
{
    public interface IStatusApiService
    {
        Task<Status> GetStatusAsync();
    }
}
