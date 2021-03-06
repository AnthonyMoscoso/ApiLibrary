﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Mappers
{
    public interface IManualMapper<TMapTo,TMapFrom>
    {
        TMapTo Map(TMapFrom mapFrom);
        IEnumerable<TMapTo> Map(IEnumerable<TMapFrom> mapFroms);
    }
}
