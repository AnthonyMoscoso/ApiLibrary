using Models.Dtos;
using System.Collections.Generic;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Purchases
{
    public class PurchaseRepository : Repository<Purchase,PurchaseDto>, IPurchaseRepository
    {
        public PurchaseRepository(string identificator="IdPurchase") : base(identificator)
        {
        }
        public new dynamic Insert(List<Purchase> list)
        {
            List<Purchase> purchasesWithStores = new List<Purchase>();
            foreach (Purchase purchase in list)
            {
                if (purchase.Store!=null)
                {
                    var search = Context.Store.Find(purchase.Store.IdStore);
                    if (search!=null){
                    
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
            if (purchasesWithStores.Count>0)
            {
                foreach (Purchase purchase in purchasesWithStores)
                {
                    var query = string.Format("Insert into  PurchaseStore values ('{0}','{1}')", purchase.IdPurchase, purchase.Store.IdStore);
                    Context.Database.ExecuteSqlCommand(query);
                }
            }
            return Save();
        }
        
    }
}