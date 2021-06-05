using System;
using System.Collections.Generic;
using System.Text;

namespace Nucleo.Mappers
{
    public interface IManualMapper<TMapTo,TMapFrom>
    {
        TMapTo Map(TMapFrom mapFrom);
        IEnumerable<TMapTo> Map(IEnumerable<TMapFrom> mapFroms);
    }
}
