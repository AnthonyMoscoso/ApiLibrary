using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface ISaleLineRepository :IRepository<SaleLine>
    {
        IEnumerable<SaleLine> GetBySale(string idSale);
    }
}
