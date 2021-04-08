using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Receptions;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Receptions
{
    public class ReceptionRepositorie : Repository<Reception>, IReceptionRepositorie
    {
        public ReceptionRepositorie(string identificator="IdReception") : base(identificator)
        {
        }

        public List<Reception> GetByDate(DateTime date)
        {
            return dbSet.Where(w=>w.CreateDate.Date.Equals(date.Date)).ToList();
        }

        public List<Reception> GetByDate(DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate.Date.Equals(date.Date)).Skip((pag - 1) * element).Take(element).ToList();
        }
   
        public List<Reception> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            return dbSet.Where(w => w.CreateDate >= dateStart.Date && w.CreateDate.Date <= dateEnd.Date).ToList(); 
        }

        public List<Reception> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate >= dateStart.Date && w.CreateDate.Date <= dateEnd.Date).Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Reception> GetByStore(string idStore)
        {
            return dbSet.Where(w => w.IdStore.Equals(idStore)).ToList();
        }

        public List<Reception> GetByStore(string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.IdStore.Equals(idStore))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        public List<Reception> GetByStore(string idStore, DateTime date)
        {
            return dbSet.Where(w => w.IdStore.Equals(idStore) && w.CreateDate.Date.Equals(date.Date)).ToList();
        }

        public List<Reception> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.IdStore.Equals(idStore) && w.CreateDate.Date.Equals(date.Date))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public dynamic Insert(List<ReceptionDto>list)
        {
            foreach (ReceptionDto dto in list)
            {
                foreach (ReceptionLine line in dto.ReceptionLine)
                {
                    Context.BookStore.Where(w => w.IdBook.Equals(line.IdBook) && w.IdStore.Equals(dto.IdStore)).SingleOrDefault().Stock += line.Quantity;
                }
            }
            dbSet.AddRange(mapper.Map<List<Reception>>(list));
            return Save();
        }

    }
}