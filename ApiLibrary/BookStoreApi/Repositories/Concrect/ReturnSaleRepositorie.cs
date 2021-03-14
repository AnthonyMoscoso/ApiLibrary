using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Returns;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Returns
{
    public class ReturnSaleRepositorie : Repositorie<ReturnSale>, IReturnSaleRepositorie
    {
        public ReturnSaleRepositorie(string identificator="IdReturn") : base(identificator)
        {
        }

        #region Date
        public List<ReturnSale> GetByDate(DateTime date)
        {
            return dbSet.Where(w=>w.CreateDate.Date.Equals(date.Date)).ToList();
        }

        public List<ReturnSale> GetByDate(DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate.Date.Equals(date.Date)).Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<ReturnSale> GetByDate(DateTime start, DateTime end)
        {
            return dbSet.Where(w => w.CreateDate.Date>=start.Date && w.CreateDate.Date<=end.Date).ToList();
        }

        public List<ReturnSale> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region Method 
        public List<ReturnSale> GetByMethod(int RepaymentMethod)
        {
            return dbSet.Where(w => w.RepaymentMethod == RepaymentMethod).ToList();
        }

        public List<ReturnSale> GetByMethod(int RepaymentMethod, int pag, int element)
        {
            return dbSet.Where(w => w.RepaymentMethod == RepaymentMethod)
                .OrderBy(w=>w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<ReturnSale> GetByMethod(int RepaymentMethod, string idStore)
        {
            return dbSet.Where(w => w.RepaymentMethod == RepaymentMethod && w.Store.IdStore.Equals(idStore)).ToList();
        }

        public List<ReturnSale> GetByMethod(int RepaymentMethod, string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.RepaymentMethod == RepaymentMethod && w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region Motive 
        public List<ReturnSale> GetByMotive(string motive)
        {
            return dbSet.Where(w => w.ReturnMotive.Equals(motive)).ToList();
        }

        public List<ReturnSale> GetByMotive(string motive, int pag, int element)
        {
            return dbSet.Where(w => w.ReturnMotive.Equals(motive)).Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<ReturnSale> GetByMotive(string motive, string idStore)
        {
            return dbSet.Where(w => w.ReturnMotive.Equals(motive) && w.Store.IdStore.Equals(idStore)).ToList();
        }

        public List<ReturnSale> GetByMotive(string motive, string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.ReturnMotive.Equals(motive) && w.Store.IdStore.Equals(idStore))
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region Sale 
        public List<ReturnSale> GetBySale(string idSale)
        {
            return dbSet.Where(w => w.IdSale.Equals(idSale)).ToList();
        }
        #endregion

        #region Store 
        public List<ReturnSale> GetByStore(string idStore)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore)).ToList();
        }

        public List<ReturnSale> GetByStore(string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion
    }
}