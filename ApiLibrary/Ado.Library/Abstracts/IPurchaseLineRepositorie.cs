using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IPurchaseLineRepositorie : IRepository<PurchaseLine>
    {
       List<PurchaseLine> GetByPurchase(string idPruchase);
    }
}
