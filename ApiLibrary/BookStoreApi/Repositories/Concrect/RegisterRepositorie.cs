using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Registers;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Registers
{
    public class RegisterRepositorie : Repository<Register>, IRegisterRepositorie
    {
        public RegisterRepositorie(string identificator="IdRegister") : base(identificator)
        {
        }
        public List<Register> GetByDate(DateTime date)
        {
            return dbSet.Where(w => w.CreateDate.Date.Equals(date.Date)).ToList();
        }
        public List<Register> GetByDate(DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate.Date.Equals(date.Date)).Skip((pag - 1) * element).Take(element).ToList();
        }
        public List<Register> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            return dbSet.Where(w => w.CreateDate >= dateStart.Date && w.CreateDate.Date <= dateEnd.Date).ToList();
        }
        public List<Register> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate >= dateStart.Date && w.CreateDate.Date <= dateEnd.Date).Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Register> GetByStore(string idStore)
        {
            return dbSet.Where(w=> w.Store.IdStore.Equals(idStore)).ToList();
        }

        public List<Register> GetByStore(string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore))
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Register> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            return dbSet.Where(w=>w.Store.IdStore.Equals(idStore) && w.RegisterDate.Date.Equals(date.Date))
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Register> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.CreateDate >= dateStart.Date && w.CreateDate.Date <= dateEnd.Date)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Register> GetByWareHouse(string idWareHouse)
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse)).ToList();
        }

        public List<Register> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse))
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Register> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element )
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && w.RegisterDate.Date.Equals(date.Date))
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Register> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && w.CreateDate >= dateStart.Date && w.CreateDate.Date <= dateEnd.Date)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
    }
}