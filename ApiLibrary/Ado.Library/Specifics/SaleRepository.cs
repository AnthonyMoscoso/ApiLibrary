using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Sales
{
    public class SaleRepository : Repository<Sale,SaleDto>, ISaleRepository
    {
        public SaleRepository(string identificator="IdSale") : base(identificator)
        {
        }
     
        #region GetByBuyer
        public List<SaleDto> GetByBuyer(string idBuyer)
        {
            var result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer)).ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetByBuyer(string idBuyer, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer))
                .OrderBy(w=>w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetByBuyer(string idBuyer, DateTime date)
        {
            var result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer) && DbFunctions.TruncateTime( w.CreateDate.Date) == DbFunctions.TruncateTime(date)).ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetByBuyer(string idBuyer, DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer) && DbFunctions.TruncateTime(w.CreateDate.Date) == DbFunctions.TruncateTime(date))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetByBuyer(string idBuyer, DateTime start, DateTime end)
        {
            var result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer) 
            && DbFunctions.TruncateTime( w.CreateDate.Date ) >= DbFunctions.TruncateTime( start) 
            && DbFunctions.TruncateTime( w.CreateDate.Date ) <= DbFunctions.TruncateTime( end))
                 .ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetByBuyer(string idBuyer, DateTime start, DateTime end, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdBuyer.Equals(idBuyer) 
            && DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( start)
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime( end))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        #endregion

        #region GetByDate
        public List<SaleDto> GetByDate(DateTime date)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) == DbFunctions.TruncateTime(date)).ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetByDate(DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) == DbFunctions.TruncateTime(date))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetByDate(DateTime start, DateTime end)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( start) 
            && DbFunctions.TruncateTime( w.CreateDate ) <=  DbFunctions.TruncateTime( end))
                .ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( start) 
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime( end))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<SaleDto>>(result);
        }
        #endregion

        #region PayMethod
        public List<SaleDto> GetByPayMethod(int payMethod)
        {
            var result = dbSet.Where(w => w.PayMethod == payMethod).ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetByPayMethod(int payMethod, int pag, int element)
        {
            var result = dbSet.Where(w => w.PayMethod == payMethod)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetByPayMethod(int payMethod, string idStore)
        {
            var result = Context.StoreSale.Where(w => w.Sale.PayMethod == payMethod && w.Store.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<SaleDto>>(result);

        }

        public List<SaleDto> GetByPayMethod(int payMethod, string idStore, int pag, int element)
        {
            var result  = Context.StoreSale.Where(w => w.Sale.PayMethod == payMethod && w.Store.IdStore.Equals(idStore))
                .OrderBy(w=> w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<SaleDto>>(result);
        }
        #endregion

        #region SaleStatus 
        public List<SaleDto> GetBySaleStatus(int status)
        {
            var result = dbSet.Where(w => w.SaleStatus == status).ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetBySaleStatus(int status, int pag, int element)
        {
            var result = dbSet.Where(w => w.SaleStatus == status)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<SaleDto>>(result);
        }

        public List<SaleDto> GetBySaleStatus(int status, string idStore)
        {
            var list = Context.StoreSale.Where(w => w.Sale.SaleStatus == status && w.Store.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<SaleDto>>(list);
        }

        public List<SaleDto> GetBySaleStatus(int status, string idStore, int pag, int element)
        {
            var list = Context.StoreSale.Where(w => w.Sale.SaleStatus == status && w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.Sale.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<SaleDto>>(list);
        }
        #endregion



      
        public dynamic Insert(List<StoreSaleDto> list)
        {
            foreach (StoreSaleDto entity in list)
            {

                ModifyStock(entity.SaleLine.ToList(),entity.IdStore);
            }
            return Save();
        }

        private void ModifyStock(List<SaleLineDto>list,string idStore)
        {
            foreach (SaleLineDto entity in list)
            {
                var search = Context.BookStore.Where(w=> w.IdBook.Equals(entity.IdBook) && w.IdStore.Equals(idStore)).SingleOrDefault().Stock-=entity.Quantity;
            }
        }
        
    }
}