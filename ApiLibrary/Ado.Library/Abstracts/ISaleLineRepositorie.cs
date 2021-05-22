using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface ISaleLineRepositorie :IRepository<SaleLine>
    {
        List<SaleLine> GetBySale(string idSale);
    }
}
