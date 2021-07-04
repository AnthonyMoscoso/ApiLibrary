using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using Core.DBAccess.Ado;
using Core.Utilities;
using Core.Utilities.Enums;
using Ado.Library;
using System.Data.Entity;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{
    public class ReturnSaleRepository : AdoRepository<ReturnSale>, IReturnSaleRepository
    {
        public ReturnSaleRepository(BookStoreEntities context, string identificator="IdReturn") : base(context,identificator)
        {
        }






        #region Date
        public IEnumerable<ReturnSale> GetByDate(DateTime date)
        {
            var result = dbSet.Where(w => w.CreateDate.Date.Equals(date.Date));
            return (result);
        }

        public IEnumerable<ReturnSale> GetByDate(DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => w.CreateDate.Date.Equals(date.Date))
                .OrderBy(W => W.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }

        public IEnumerable<ReturnSale> GetByDate(DateTime start, DateTime end)
        {
            var result = dbSet.Where(w => w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date);
            return (result);
        }

        public IEnumerable<ReturnSale> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            var result = dbSet.Where(w => w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date)
                 .OrderBy(W => W.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return (result);
        }
        #endregion

        #region Method 
        public IEnumerable<ReturnSale> GetByMethod(int RepaymentMethod)
        {
            var result = dbSet.Where(w => w.RepaymentMethod == RepaymentMethod);
            return (result);
        }

        public IEnumerable<ReturnSale> GetByMethod(int RepaymentMethod, int pag, int element)
        {
            var result = dbSet.Where(w => w.RepaymentMethod == RepaymentMethod)
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }

        public IEnumerable<ReturnSale> GetByMethod(int RepaymentMethod, string idStore)
        {
            var result = dbSet.Where(w => w.RepaymentMethod == RepaymentMethod && w.Store.IdStore.Equals(idStore));
            return (result);
        }

        public IEnumerable<ReturnSale> GetByMethod(int RepaymentMethod, string idStore, int pag, int element)
        {
            var result = dbSet.Where(w => w.RepaymentMethod == RepaymentMethod && w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element);
            return (result);
        }
        #endregion

        #region Motive 
        public IEnumerable<ReturnSale> GetByMotive(string motive)
        {
            var result = dbSet.Where(w => w.ReturnMotive.Equals(motive));
            return (result);
        }

        public IEnumerable<ReturnSale> GetByMotive(string motive, int pag, int element)
        {
            var result = dbSet.Where(w => w.ReturnMotive.Equals(motive))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element);
            return (result);
        }

        public IEnumerable<ReturnSale> GetByMotive(string motive, string idStore)
        {
            var result = dbSet.Where(w => w.ReturnMotive.Equals(motive)
            && w.Store.IdStore.Equals(idStore));
            return (result);
        }

        public IEnumerable<ReturnSale> GetByMotive(string motive, string idStore, int pag, int element)
        {
            var result = dbSet.Where(w => w.ReturnMotive.Equals(motive) && w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }
        #endregion

        #region Sale 
        public IEnumerable<ReturnSale> GetBySale(string idSale)
        {
            var result = dbSet.Where(w => w.IdSale.Equals(idSale));
            return (result);
        }
        #endregion

        #region Store 
        public IEnumerable<ReturnSale> GetByStore(string idStore)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore));
            return (result);
        }

        public IEnumerable<ReturnSale> GetByStore(string idStore, int pag, int element)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element);
            return (result);
        }




        #endregion




        #region Private Methods

        private dynamic InsertReturnWareHouse(string idReturn, string idWareHouse)
        {
            try
            {
                var query = $"Insert into ReturnWareHouse values ('{idReturn}','{idWareHouse}');";
                _Context.Database.ExecuteSqlCommand(query);

               _log.Write( $"ReturnWareHouse with {Identificator} : {idReturn} was insert");
                

              
            }
            catch (DbUpdateException e)
            {

                _log.Write($"{e.InnerException.InnerException.Message ?? e.Message}", MessageCode.exception);

            
            }
            catch (SqlException e)
            {
                _log.Write($"{e.InnerException.InnerException.Message ?? e.Message}", MessageCode.exception);
            }
            catch (Exception e)
            {
                _log.Write($"{e.InnerException.InnerException.Message ?? e.Message}", MessageCode.exception);

            }
            return Save();

        }

        private dynamic InsertReturnStore(string idReturn, string idStore)
        {
            try
            {
                var query = $"Insert into ReturnStore values ('{idReturn}','{idStore}');";
                _Context.Database.ExecuteSqlCommand(query);

                _log.Write($"ReturnStore with {Identificator} : {idReturn} was insert");
                
            }
            catch (DbUpdateException e)
            {
                _log.Write($"{e.InnerException.InnerException.Message ?? e.Message}", MessageCode.exception);

               
            }
            catch (SqlException e)
            {
                _log.Write($"{e.InnerException.InnerException.Message ?? e.Message}", MessageCode.exception);
            }
            catch (Exception e)
            {
                _log.Write($"{e.InnerException.InnerException.Message ?? e.Message}", MessageCode.exception);

            }
            return Save();

        }

        #endregion

        #region 
        public IEnumerable<ReturnSale> GetByWareHouse(string idWareHouse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSale> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSale> GetByWareHouse(string idWareHouse, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSale> GetByWareHouse(string idWareHouse, DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSale> GetByStore(string idStore, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSale> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}