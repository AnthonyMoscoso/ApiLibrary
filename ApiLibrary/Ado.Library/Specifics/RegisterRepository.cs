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
    public class RegisterRepository : Repository<Register>, IRegisterRepository
    {
        public RegisterRepository(BookStoreEntities context,string identificator="IdRegister") : base(context,identificator)
        {
        }
        public IEnumerable<Register> GetByDate(DateTime date)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date));
            return (result);
        }
        public IEnumerable<Register> GetByDate(DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return (result);
        }
        public IEnumerable<Register> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            var result = dbSet.Where(w => (DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(dateStart))
            && (DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(dateEnd)));
            return (result);
        }
        public IEnumerable<Register> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            var result = dbSet.Where(w => (DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(dateStart))
            && (DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(dateEnd.Date)))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return (result);
        }

        public IEnumerable<Register> GetByStore(string idStore)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore));
            return (result);
        }

        public IEnumerable<Register> GetByStore(string idStore, int pag, int element)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return (result);
        }

        public IEnumerable<Register> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore) && DbFunctions.TruncateTime(w.RegisterDate) == DbFunctions.TruncateTime(date))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return (result);
        }

        public IEnumerable<Register> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore) && DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(dateStart)
            && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(dateEnd))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return (result);
        }

        public IEnumerable<Register> GetByStore(string idStore, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Register> GetByStore(string idStore, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Register> GetByWareHouse(string idWareHouse)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse));
            return (result);
        }

        public IEnumerable<Register> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return (result);
        }

        public IEnumerable<Register> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse)
            && DbFunctions.TruncateTime(w.RegisterDate) == DbFunctions.TruncateTime(date))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element);
            return (result);
        }

        public IEnumerable<Register> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse)
            && DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(dateStart)
            && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(dateEnd))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return (result);
        }

        public IEnumerable<Register> GetByWareHouse(string idWareHouse, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Register> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd)
        {
            throw new NotImplementedException();
        }
    }
}