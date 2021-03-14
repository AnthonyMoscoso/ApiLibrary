using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Sales;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Sales
{
    public class SaleRepositorie : Repositorie<Sale>, ISaleRepositorie
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

        public List<Sale> GetByPayMethod(int payMethod, string idStore)
        {
            return dbSet.Where(w => w.PayMethod == payMethod && w.Store.IdStore.Equals(idStore)).ToList();
        }

        public List<Sale> GetByPayMethod(int payMethod, string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.PayMethod == payMethod && w.Store.IdStore.Equals(idStore)).Skip((pag - 1) * element).Take(element).ToList();
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

        public List<Sale> GetBySaleStatus(int status, string idStore)
        {
            return dbSet.Where(w => w.SaleStatus == status && w.Store.IdStore.Equals(idStore)).ToList();
        }

        public List<Sale> GetBySaleStatus(int status, string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.SaleStatus == status && w.Store.IdStore.Equals(idStore))
                   .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region Store
        public List<Sale> GetByStore(string idStore)
        {
            return dbSet.Where(w=> w.Store.IdStore.Equals(idStore)).ToList();
        }

        public List<Sale> GetByStore(string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<Sale> GetByStore(string idStore, DateTime date)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.CreateDate.Date.Equals(date.Date))
                .ToList();
        }

        public List<Sale> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.CreateDate.Date.Equals(date.Date))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<Sale> GetByStore(string idStore, DateTime start, DateTime end)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.CreateDate.Date >= start.Date && w.CreateDate <= end.Date)
                .ToList();
        }

        public List<Sale> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.CreateDate.Date >= start.Date && w.CreateDate <= end.Date)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
        #endregion
    }
}