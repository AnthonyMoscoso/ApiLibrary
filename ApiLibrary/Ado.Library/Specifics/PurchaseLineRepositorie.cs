using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Ado.Library;
using Nucleo.DBAccess.Ado;

namespace Models.Repositories.Concrect.Purchases
{
    public class PurchaseLineRepositorie : Repository<PurchaseLine,PurchaseLineDto>, IPurchaseLineRepositorie
    {
        public PurchaseLineRepositorie(string identificator="IdPurchaseLine") : base(identificator)
        {
        }

        public List<PurchaseLine> GetByPurchase(string idPruchase)
        {
            return dbSet.Where(w=>w.IdPurchase.Equals(idPruchase)).ToList();
        }
    }
}