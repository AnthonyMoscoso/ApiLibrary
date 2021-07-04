using Models.Dtos;
using System.Collections.Generic;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{
    public class PurchaseRepository : AdoRepository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(BookStoreEntities context, string identificator = "IdPurchase") : base(context, identificator)
        {
        }
        public new dynamic Insert(IEnumerable<Purchase> list)
        {
            List<Purchase> purchasesWithStores = new List<Purchase>();
            foreach (Purchase purchase in list)
            {
                if (purchase.Store != null)
                {
                    var search = _Context.Set<Store>().Find(purchase.Store.IdStore);
                    if (search != null)
                    {

                        Purchase purchase1 = new Purchase()
                        {
                            IdPurchase = purchase.IdPurchase,
                            Store = purchase.Store
                        };
                        purchasesWithStores.Add(purchase1);
                        purchase.Store = null;
                    }

                }
            }
            dbSet.AddRange(list);
            Save();
            if (purchasesWithStores.Count > 0)
            {
                foreach (Purchase purchase in purchasesWithStores)
                {
                    var query = string.Format("Insert into  PurchaseStore values ('{0}','{1}')", purchase.IdPurchase, purchase.Store.IdStore);
                    _Context.Database.ExecuteSqlCommand(query);
                }
            }

            return Save();
            
        }

    }
}