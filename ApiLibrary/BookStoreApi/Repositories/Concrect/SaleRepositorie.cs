using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Sales;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Sales
{
    public class SaleRepositorie : Repository<Sale,SaleDto>, ISaleRepositorie
    {
        public SaleRepositorie(string identificator="IdSale") : base(identificator)
        {
        }

        #region GetByBuyer
        public List<Sale> GetByBuyer(string idBuyer)
        {
            return dbSet.Where(w=> w.IdBuyer.Equals(idBuyer)).ToList();
        }

        public List<Sale> GetByBuyer(string idBuyer, int pag, int element)
        {
            return dbSet.Where(w => w.IdBuyer.Equals(idBuyer)).Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Sale> GetByBuyer(string idBuyer, DateTime date)
        {
            return dbSet.Where(w => w.IdBuyer.Equals(idBuyer) && w.CreateDate.Date.Equals(date.Date)).ToList();
        }

        public List<Sale> GetByBuyer(string idBuyer, DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.IdBuyer.Equals(idBuyer) && w.CreateDate.Date.Equals(date.Date))
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Sale> GetByBuyer(string idBuyer, DateTime start, DateTime end)
        {
            return dbSet.Where(w => w.IdBuyer.Equals(idBuyer) && w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date)
                 .ToList();
        }

        public List<Sale> GetByBuyer(string idBuyer, DateTime start, DateTime end, int pag, int element)
        {
            return dbSet.Where(w => w.IdBuyer.Equals(idBuyer) && w.CreateDate.Date>= start.Date && w.CreateDate.Date<= end.Date)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        #endregion

        #region GetByDate
        public List<Sale> GetByDate(DateTime date)
        {
            return dbSet.Where(w => w.CreateDate.Date.Equals(date.Date)).ToList();
        }

        public List<Sale> GetByDate(DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate.Date.Equals(date.Date))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Sale> GetByDate(DateTime start, DateTime end)
        {
            return dbSet.Where(w => w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date)
                .ToList();
        }

        public List<Sale> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date)
                  .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region PayMethod
        public List<Sale> GetByPayMethod(int payMethod)
        {
            return dbSet.Where(w => w.PayMethod == payMethod).ToList();
        }

        public List<Sale> GetByPayMethod(int payMethod, int pag, int element)
        {
            return dbSet.Where(w => w.PayMethod == payMethod).Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<StoreSaleDto> GetByPayMethod(int payMethod, string idStore)
        {
            var list = Context.StoreSale.Where(w => w.Sale.PayMethod == payMethod && w.Store.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByPayMethod(int payMethod, string idStore, int pag, int element)
        {
            var list = Context.StoreSale.Where(w => w.Sale.PayMethod == payMethod && w.Store.IdStore.Equals(idStore))
                .OrderBy(w=> w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }
        #endregion

        #region SaleStatus 
        public List<Sale> GetBySaleStatus(int status)
        {
            return dbSet.Where(w => w.SaleStatus == status).ToList();
        }

        public List<Sale> GetBySaleStatus(int status, int pag, int element)
        {
            return dbSet.Where(w => w.SaleStatus == status)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<StoreSaleDto> GetBySaleStatus(int status, string idStore)
        {
            var list = Context.StoreSale.Where(w => w.Sale.SaleStatus == status && w.Store.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetBySaleStatus(int status, string idStore, int pag, int element)
        {
            var list = Context.StoreSale.Where(w => w.Sale.SaleStatus == status && w.Store.IdStore.Equals(idStore))
                   .OrderBy(w => w.Sale.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }
        #endregion

        #region Store
        public List<StoreSaleDto> GetByStore(string idStore)
        {
            var list = Context.StoreSale.Where(w => w.Store.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStore(string idStore, int pag, int element)
        {
            var list = Context.StoreSale.Where(w => w.Store.IdStore.Equals(idStore))
                .OrderBy(w=> w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStore(string idStore, DateTime date)
        {
            var list = Context.StoreSale.Where(w => w.Store.IdStore.Equals(idStore) && w.Sale.CreateDate.Date.Equals(date.Date)).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            var list = Context.StoreSale.Where(w => w.Store.IdStore.Equals(idStore) && w.Sale.CreateDate.Date.Equals(date.Date))
                .OrderBy(w=> w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();

            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end)
        {
            var list = Context.StoreSale.Where(w => w.Store.IdStore.Equals(idStore) && w.Sale.CreateDate.Date >= start.Date && w.Sale.CreateDate <= end.Date)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            var list = Context.StoreSale.Where(w => w.Store.IdStore.Equals(idStore) && w.Sale.CreateDate.Date >= start.Date && w.Sale.CreateDate <= end.Date)
                .OrderBy(w=> w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

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
        #endregion
    }
}