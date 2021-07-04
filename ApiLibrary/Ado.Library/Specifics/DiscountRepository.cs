using System;
using System.Collections.Generic;
using System.Linq;
using Models.Dtos;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{
    public class DiscountRepository : AdoRepository<Discount>, IDiscountRepository
    {
        public DiscountRepository(BookStoreEntities context, string identificator="IdDiscount") : base(context,identificator)
        {
        }

        public Discount GetByBook(string idBook)
        {
            Discount search = dbSet.Where(w => w.Book.Any(b => b.IdBook.Equals(idBook)) && w.EndDate>DateTime.Now).SingleOrDefault();
            return search;
        }

        public IEnumerable<Discount> GetFinnalized()
        {
            return dbSet.Where(w => w.EndDate.Value <= DateTime.Now );
        }

        public IEnumerable<Discount> GetFinnalized(int pag, int element)
        {
            return dbSet.Where(w => w.EndDate.Value <= DateTime.Now)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element) ;
        }

        public IEnumerable<Discount> GetNotFinnalized()
        {
            var IEnumerable = dbSet.Where(w => w.EndDate.Value > DateTime.Now || !w.EndDate.HasValue);
            return IEnumerable;
        }

        public IEnumerable<Discount> GetNotFinnalized(int pag, int element)
        {
            return dbSet.Where(w => w.EndDate.Value > DateTime.Now || !w.EndDate.HasValue)
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
        }
    }
}