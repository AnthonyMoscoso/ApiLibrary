using System;
using System.Collections.Generic;
using System.Linq;
using Models.Dtos;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Discounts
{
    public class DiscountRepository : Repository<Discount,DiscountDto>, IDiscountRepository
    {
        public DiscountRepository(string identificator="IdDiscount") : base(identificator)
        {
        }

        public Discount GetByBook(string idBook)
        {
            var entity = dbSet.Where(w => w.Book.Any(b => b.IdBook.Equals(idBook)) && w.EndDate>DateTime.Now).SingleOrDefault();
            return entity;
        }

        public List<Discount> GetFinnalized()
        {
            return dbSet.Where(w => w.EndDate.Value <= DateTime.Now ).ToList();
        }

        public List<Discount> GetFinnalized(int pag, int element)
        {
            return dbSet.Where(w => w.EndDate.Value <= DateTime.Now)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<Discount> GetNotFinnalized()
        {
            var list = dbSet.Where(w => w.EndDate.Value > DateTime.Now || !w.EndDate.HasValue).ToList();
            return list;
        }

        public List<Discount> GetNotFinnalized(int pag, int element)
        {
            return dbSet.Where(w => w.EndDate.Value > DateTime.Now || !w.EndDate.HasValue)
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
    }
}