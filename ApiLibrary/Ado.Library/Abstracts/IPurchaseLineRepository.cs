using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IPurchaseLineRepository : IRepository<PurchaseLine>
    {
        IEnumerable<PurchaseLine> GetByPurchase(string idPruchase);
    }
}
