using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(BookStoreEntities context,string identificator="IdSale") : base(context,identificator)
        {
        }
     
        #region GetByBuyer
        public IEnumerable<Sale> GetByBuyer(string idBuyer)
        {
            IEnumerable<Sale> result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer));
            return (result);
        }

        public IEnumerable<Sale> GetByBuyer(string idBuyer, int pag, int element)
        {
            IEnumerable<Sale> result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer))
                .OrderBy(w=>w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }

        public IEnumerable<Sale> GetByBuyer(string idBuyer, DateTime date)
        {
            IEnumerable<Sale> result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer) && DbFunctions.TruncateTime( w.CreateDate.Date) == DbFunctions.TruncateTime(date));
            return (result);
        }

        public IEnumerable<Sale> GetByBuyer(string idBuyer, DateTime date, int pag, int element)
        {
            IEnumerable<Sale> result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer) && DbFunctions.TruncateTime(w.CreateDate.Date) == DbFunctions.TruncateTime(date))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }

        public IEnumerable<Sale> GetByBuyer(string idBuyer, DateTime start, DateTime end)
        {
            IEnumerable<Sale> result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer) 
            && DbFunctions.TruncateTime( w.CreateDate.Date ) >= DbFunctions.TruncateTime( start) 
            && DbFunctions.TruncateTime( w.CreateDate.Date ) <= DbFunctions.TruncateTime( end));
            return (result);
        }

        public IEnumerable<Sale> GetByBuyer(string idBuyer, DateTime start, DateTime end, int pag, int element)
        {
            IEnumerable<Sale> result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer) 
            && DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( start)
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime( end))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element) ;
            return (result);
        }

        #endregion

        #region GetByDate
        public IEnumerable<Sale> GetByDate(DateTime date)
        {
            IEnumerable<Sale> result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) == DbFunctions.TruncateTime(date));
            return (result);
        }

        public IEnumerable<Sale> GetByDate(DateTime date, int pag, int element)
        {
            IEnumerable<Sale> result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) == DbFunctions.TruncateTime(date))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element);
            return (result);
        }

        public IEnumerable<Sale> GetByDate(DateTime start, DateTime end)
        {
            IEnumerable<Sale> result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( start) 
            && DbFunctions.TruncateTime( w.CreateDate ) <=  DbFunctions.TruncateTime( end))
                ;
            return (result);
        }

        public IEnumerable<Sale> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            IEnumerable<Sale> result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( start) 
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime( end))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }
        #endregion

        #region PayMethod
        public IEnumerable<Sale> GetByPayMethod(int payMethod)
        {
            IEnumerable<Sale> result = dbSet.Where(w => w.PayMethod == payMethod);
            return (result);
        }

        public IEnumerable<Sale> GetByPayMethod(int payMethod, int pag, int element)
        {
            IEnumerable<Sale> result = dbSet.Where(w => w.PayMethod == payMethod)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }

  
        #endregion

        #region SaleStatus 
        public IEnumerable<Sale> GetBySaleStatus(int status)
        {
            IEnumerable<Sale> result = dbSet.Where(w => w.SaleStatus == status);
            return (result);
        }

        public IEnumerable<Sale> GetBySaleStatus(int status, int pag, int element)
        {
            IEnumerable<Sale> result = dbSet.Where(w => w.SaleStatus == status)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element);
            return (result);
        }

      
        #endregion



      
        /*public dynamic Insert(IEnumerable<StoreSale> IEnumerable)
        {
            foreach (StoreSale entity in IEnumerable)
            {

                ModifyStock(entity.SaleLine,entity.IdStore);
            }
            return Save();
        }

        private void ModifyStock(IEnumerable<SaleLineDto>IEnumerable,string idStore)
        {
            foreach (SaleLineDto entity in IEnumerable)
            {
                var search = Context.BookStore.Where(w=> w.IdBook.Equals(entity.IdBook) && w.IdStore.Equals(idStore)).SingleOrDefault().Stock-=entity.Quantity;
            }
        }*/
        
    }
}