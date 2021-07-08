using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Ado.Library;
using Core.DBAccess.Ado;


namespace Ado.Library.Specifics
{
    public class PurchaseLineRepository : AdoRepository<PurchaseLine>, IPurchaseLineRepository
    {
        public PurchaseLineRepository(BookStoreEntities context, string identificator = "IdPurchaseLine") : base(context, identificator)
        {
        }

        public IEnumerable<PurchaseLine> GetByPurchase(string idPruchase)
        {
            return dbSet.Where(w=>w.IdPurchase.Equals(idPruchase));
        }
    }
}