using LegendRank.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LegendRank.Services
{
    public interface IRuneService
    {
        List<RuneRoot> GetRunes();
        void GetSlots(Participant participant);
    }
}
