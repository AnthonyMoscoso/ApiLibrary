using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Order
{
    public class OrderRepositorie : Repositorie<Orders>, IOrderRepositorie
    {
        public OrderRepositorie(string identificator="IdOrder") : base(identificator)
        {
        }

        public List<Orders> GetByDate(DateTime date)
        {
            var list = dbSet.Where(w=>w.CreateDate.Date==date.Date).ToList();
            return list;
        }

        public List<Orders> GetByDate(DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate.Date == date.Date)
                .OrderBy(w=>w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }



        public List<Orders> GetByStore(string idStore)
        {
            var list = dbSet.Where(w=>w.IdStore.Equals(idStore)).ToList();
            return list;
        }

        public List<Orders> GetByStore(string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
        public List<Orders> GetByStore(string idStore, DateTime date)
        {
            var list = dbSet.Where(w => w.CreateDate.Date == date.Date && w.IdStore.Equals(idStore)).ToList();
            return list;
        }

        public List<Orders> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate.Date == date.Date && w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
        public List<Orders> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            var list = dbSet.Where(w => w.CreateDate >= dateStart && w.CreateDate <= dateEnd).ToList(); 
            return list;
        }

        public List<Orders> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate >= dateStart && w.CreateDate <= dateEnd)
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<Orders> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd)
        {
            var list = dbSet.Where(w => w.CreateDate >= dateStart && w.CreateDate <= dateEnd && w.IdStore.Equals(idStore)).ToList(); 
            return list;
        }

        public List<Orders> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate >= dateStart && w.CreateDate <= dateEnd && w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
    }
}