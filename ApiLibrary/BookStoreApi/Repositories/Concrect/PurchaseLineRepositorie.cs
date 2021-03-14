using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Purchases;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Purchases
{
    public class PurchaseLineRepositorie : Repositorie<PurchaseLine>, IPurchaseLineRepositorie
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