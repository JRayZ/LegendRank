﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegendRank.Services
{
    public interface ISerializerService
    {
        string Serialize(object data);

        T Deserialize<T>(string payload);
    }
}
