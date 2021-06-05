using Models.Dtos;
using Models.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;

namespace Ado.Library.Specifics
{
    public class StoreSaleRepository : Repository<StoreSale>, IStoreSaleRepository
    {
        public StoreSaleRepository(BookStoreEntities context,string identificator="idStoreSale") : base(context,identificator)
        {
        }
        /*     #region Buyer

             public IEnumerable<StoreSale> GetByBuyer(string idBuyer) 
             {
                 var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer)).ToList();
                 return (list);
             }

             public IEnumerable<StoreSale> GetByBuyer(string idBuyer, int pag, int element)
             {
                 var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer))
                 .OrderBy(w => w.Sale.CreateDate)
                 .Skip((pag-1)*element)
                 .Take(element)
                 .ToList();
                 return (list);
             }

             public IEnumerable<StoreSale> GetByBuyer(string idBuyer, DateTime date)
             {
                 var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer) && DbFunctions.TruncateTime( w.Sale.CreateDate) == DbFunctions.TruncateTime(date))
                 .ToList();
                 return (list);
             }

             public IEnumerable<StoreSale> GetByBuyer(string idBuyer, DateTime date, int pag, int element)
             {
                 var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer) && DbFunctions.TruncateTime( w.Sale.CreateDate) > DbFunctions.TruncateTime( date))
                 .OrderBy(w => w.Sale.CreateDate)
                 .Skip((pag - 1) * element)
                 .Take(element)
                 .ToList();
                 return (list);
             }

             public IEnumerable<StoreSale> GetByBuyer(string idBuyer, DateTime start, DateTime end)
             {
                 var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer) && (w.Sale.CreateDate >= start & w.Sale.CreateDate <= end))
                .ToList();
                 return (list);
             }

             public IEnumerable<StoreSale> GetByBuyer(string idBuyer, DateTime start, DateTime end, int pag, int element)
             {
                 var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer) && (w.Sale.CreateDate >= start & w.Sale.CreateDate <= end))
                     .OrderBy(w => w.Sale.CreateDate)
                     .Skip((pag - 1) * element)
                     .Take(element)
                     .ToList();
                 return (list);
             }
       #endregion */
        public IEnumerable<StoreSale> GetByDate(DateTime date)
        {
            IEnumerable<StoreSale> list = dbSet.Where(w => DbFunctions.TruncateTime(date) == DbFunctions.TruncateTime(w.Sale.CreateDate));
            return (list);
        }

        public IEnumerable<StoreSale> GetByDate(DateTime date, int pag, int element)
        {
            IEnumerable<StoreSale> list = dbSet.Where(w => DbFunctions.TruncateTime(date) == DbFunctions.TruncateTime(w.Sale.CreateDate)).Skip((pag - 1) * element).Take(element);
            return (list);
        }

        public IEnumerable<StoreSale> GetByDate(DateTime start, DateTime end)
        {
            IEnumerable<StoreSale> list = dbSet.Where(w => DbFunctions.TruncateTime(w.Sale.CreateDate) >= DbFunctions.TruncateTime(start) & DbFunctions.TruncateTime(w.Sale.CreateDate) < DbFunctions.TruncateTime(end));
            return (list);
        }

        public IEnumerable<StoreSale> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            IEnumerable<StoreSale> list = dbSet.Where(w => DbFunctions.TruncateTime(w.Sale.CreateDate) >= DbFunctions.TruncateTime(start) & DbFunctions.TruncateTime(w.Sale.CreateDate) <= DbFunctions.TruncateTime(end)).OrderBy(w => w.Sale.CreateDate).Skip((pag - 1) * element).Take(element);
            return (list);
        }


        /*   public IEnumerable<StoreSale> GetByPayMethod(int payMethod, string idStore)
           {
               var list =dbSet.Where(w=> w.Sale.PayMethod.Equals(payMethod) && w.IdStore.Equals(idStore)).ToList();
               return (list);
           }

           public IEnumerable<StoreSale> GetByPayMethod(int payMethod, string idStore, int pag, int element)
           {
               var list = dbSet.Where(w => w.Sale.PayMethod.Equals(payMethod) && w.IdStore.Equals(idStore))
                   .OrderBy(w=> w.Sale.CreateDate)
                   .Skip((pag-1)*element)
                   .Take(element)
                   .ToList();
               return (list);
           }

           public IEnumerable<StoreSale> GetByPayMethod(int payMethod)
           {
               var list = dbSet.Where(w => w.Sale.PayMethod.Equals(payMethod)).ToList();
               return (list);
           }

           public IEnumerable<StoreSale> GetByPayMethod(int payMethod, int pag, int element)
           {
               var list = dbSet.Where(w => w.Sale.PayMethod.Equals(payMethod))
                   .OrderBy(w=> w.Sale.CreateDate)
                   .Skip((pag-1)*element)
                   .Take(element)
                   .ToList();
               return (list);
           }
        */
        public IEnumerable<StoreSale> GetByStatus(int status, string idStore)
        {
            IEnumerable<StoreSale> list = dbSet.Where(w => w.Sale.SaleStatus.Equals(status) && w.IdStore.Equals(idStore));
            return (list);
        }

        public IEnumerable<StoreSale> GetByStatus(int status, string idStore, int pag, int element)
        {
            IEnumerable<StoreSale> list = dbSet.Where(w => w.Sale.SaleStatus.Equals(status) && w.IdStore.Equals(idStore)).OrderBy(w => w.Sale.CreateDate).Skip((pag - 1) * element).Take(element);
            return (list);
        }



        public IEnumerable<StoreSale> GetByStore(string idStore)
        {
            IEnumerable<StoreSale> list = dbSet.Where(w => w.IdStore.Equals(idStore));
            return (list);
        }

        public IEnumerable<StoreSale> GetByStore(string idStore, int pag, int element)
        {
            IEnumerable<StoreSale> list = dbSet.Where(w => w.IdStore.Equals(idStore))
                .OrderBy(w => w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return (list);
        }

        public IEnumerable<StoreSale> GetByStore(string idStore, DateTime date)
        {
            DateTime tomorow = date.AddDays(1);
            IEnumerable<StoreSale> list = dbSet.Where(w => w.IdStore.Equals(idStore) && (w.Sale.CreateDate > date && w.Sale.CreateDate < tomorow));
            return (list);
        }

        public IEnumerable<StoreSale> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            DateTime tomorow = date.AddDays(1);
            IEnumerable<StoreSale> list = dbSet.Where(w => w.IdStore.Equals(idStore) && (w.Sale.CreateDate > date && w.Sale.CreateDate < tomorow)).OrderBy(w => w.Sale.CreateDate).Skip((pag - 1) * element).Take(element);
            return (list);
        }

        public IEnumerable<StoreSale> GetByStore(string idStore, DateTime start, DateTime end)
        {
            IEnumerable<StoreSale> list = dbSet.Where(w => w.IdStore.Equals(idStore) && (w.Sale.CreateDate >= start && w.Sale.CreateDate <= end));
            return (list);
        }

        public IEnumerable<StoreSale> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            IEnumerable<StoreSale> list = dbSet.Where(w => w.IdStore.Equals(idStore) && (w.Sale.CreateDate >= start && w.Sale.CreateDate <= end)).OrderBy(w => w.Sale.CreateDate).Skip((pag - 1) * element).Take(element);
            return (list);
        }

        /*    public dynamic Insert(IEnumerable<StoreSale> list)
            {
                dbSet.AddRange((list));
                Save();
                return ModifyStock(list);

            }*/

        /*   public new dynamic Delete(IEnumerable<string> ids)
           {
               string message = "";
               foreach (string id in ids)
               {
                   var search = dbSet.Find(id);
                   if (search!=null)
                   {
                       Context.SaleLine.RemoveRange(Context.SaleLine.Where(w => w.IdSale.Equals(id)).ToList());
                       Context.Sale.Remove(search.Sale);
                       dbSet.Remove(search);
                       Save();
                       message+=string.Format("sale with id {0} was delete",id);
                   }
                   else
                   {
                       message += string.Format("any entity was found with id {0}", id);
                   }
               }
               return message;
           }*/

        /*    public dynamic Update(IEnumerable<StoreSale>list)
            {
                string message = "";
                foreach (StoreSale entity in list)
                {
                    var searchEntity = dbSet.Find(entity);
                    if (searchEntity != null)
                    {
                        foreach (SaleLineDto line in entity.SaleLine)
                        {
                            var search = Context.SaleLine.Find(line.IdSaleLine);
                            if (search != null)
                            {
                                Context.SaleLine.Attach(search);
                                Context.Entry(entity).State = EntityState.Modified;
                            }
                            else
                            {
                                message += string.Format("Sale line with id {0} was not found", line.IdSaleLine);
                            }

                        }

                        StoreSale e = mapper.Map<StoreSale>(entity);
                        dbSet.Attach(e);
                        Context.Entry(e).State = EntityState.Modified;
                        message += Save();
                    }
                    else
                    {
                        message += "StoreSale with id " + entity.IdSale + " was not found";
                    }

                }
                return message;
            }
        */
        /*  private dynamic ModifyStock(IEnumerable<StoreSale> list)
          {
              try
              {
                  foreach (StoreSale entity in list)
                  {
                      ModifyStockInStore(entity.SaleLine.ToList(), entity.IdStore);

                  }
                  return Save(); 
              }
              catch (Exception e)
              {
                  var error = e.Message;
                  return e.Message;
              }

          }
        */
      /*  private void ModifyStockInStore(IEnumerable<SaleLineDto> list, string idStore)
        {

            foreach (SaleLineDto entity in list)
            {
                Context.BookStore.Where(w => w.IdBook.Equals(entity.IdBook) && w.IdStore.Equals(idStore)).SingleOrDefault().Stock -= entity.Quantity;
                Context.SaveChanges();
            }
        }*/



    }
}