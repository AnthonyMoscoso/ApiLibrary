using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;


namespace Ado.Library.Specifics
{
    public class ReceptionRepository : AdoRepository<Reception>, IReceptionRepository
    {
        public ReceptionRepository(BookStoreEntities context, string identificator="IdReception") : base(context,identificator)
        {
        }

        
        public IEnumerable<Reception> GetByDate(DateTime date)
        {
            IEnumerable<Reception> result = dbSet.Where(w => (DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)));
            return result;
        }

        public IEnumerable<Reception> GetByDate(DateTime date, int pag, int element)
        {
            IEnumerable<Reception> result = dbSet.Where(w => (DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return result;
        }
   
        public IEnumerable<Reception> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            IEnumerable<Reception> result = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime( dateStart) 
            && DbFunctions.TruncateTime( w.CreateDate ) <= DbFunctions.TruncateTime(dateEnd))
                .ToList();
            return result;
        }

        public IEnumerable<Reception> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            IEnumerable<Reception> result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( dateStart) 
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime( dateEnd.Date))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return result;
        }

        public IEnumerable<Reception> GetByOrder(string idOrder)
        {
            IEnumerable<Reception> result = dbSet.Where(w => w.Orders.IdOrder.Equals(idOrder));
            return result;
        }

        public IEnumerable<Reception> GetByPurchase(string idPurchase)
        {
            IEnumerable<Reception> result = dbSet.Where(w => w.Purchase.IdPurchase.Equals(idPurchase));
            return result;
        }

        public IEnumerable<Reception> GetByStore(string idStore)
        {
            IEnumerable<Reception> result = dbSet.Where(w => w.IdStore.Equals(idStore)).ToList();
            return result;
        }

        public IEnumerable<Reception> GetByStore(string idStore, int pag, int element)
        {
            IEnumerable<Reception> result = dbSet.Where(w => w.IdStore.Equals(idStore))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return result;
        }
        public IEnumerable<Reception> GetByStore(string idStore, DateTime date)
        {
            IEnumerable<Reception> result = dbSet.Where(w => w.IdStore.Equals(idStore) 
            && (DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)))
                .ToList();
            return result;
        }

        public IEnumerable<Reception> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            IEnumerable<Reception> result = dbSet.Where(w => w.IdStore.Equals(idStore)
            && (DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return result;
        }

        /*public new dynamic Insert(IEnumerable<Reception>list)
        {
            foreach (Reception entity in list)
            {
                foreach (ReceptionLine line in entity.ReceptionLine)
                {
                    Context.BookStore.Where(w => w.IdBook.Equals(line.IdBook) && w.IdStore.Equals(entity.IdStore)).SingleOrDefault().Stock += line.Quantity;
                }
            }
            dbSet.AddRange(mapper.Map<IEnumerable<Reception>>(list));
            return Save();
        }*/

    }
}