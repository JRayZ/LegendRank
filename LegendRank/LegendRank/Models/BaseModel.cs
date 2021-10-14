using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LegendRank.Models
{
    public abstract class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
