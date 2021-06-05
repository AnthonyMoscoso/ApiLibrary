using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Ado.Library;
using Nucleo.DBAccess.Ado;

namespace Ado.Library.Specifics
{
    public class PurchaseLineRepository : Repository<PurchaseLine>, IPurchaseLineRepository
    {
        public PurchaseLineRepository(BookStoreEntities context,string identificator="IdPurchaseLine") : base(context,identificator)
        {
        }

        public IEnumerable<PurchaseLine> GetByPurchase(string idPruchase)
        {
            return dbSet.Where(w=>w.IdPurchase.Equals(idPruchase));
        }
    }
}