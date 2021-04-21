using BookStoreApi.Dtos;
using BookStoreApi.Models.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Receptions;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Receptions
{
    public class ReceptionRepository : Repository<Reception,ReceptionDto>, IReceptionRepository
    {
        public ReceptionRepository(string identificator="IdReception") : base(identificator)
        {
        }

        
        public List<ReceptionDto> GetByDate(DateTime date)
        {
            var result = dbSet.Where(w => (DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)))
                .ToList();
            return mapper.Map<List<ReceptionDto>>(result);
        }

        public List<ReceptionDto> GetByDate(DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => (DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReceptionDto>>(result);
        }
   
        public List<ReceptionDto> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime( dateStart) 
            && DbFunctions.TruncateTime( w.CreateDate ) <= DbFunctions.TruncateTime(dateEnd))
                .ToList();
            return mapper.Map<List<ReceptionDto>>(result);
        }

        public List<ReceptionDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( dateStart) 
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime( dateEnd.Date))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReceptionDto>>(result);
        }

        public List<ReceptionOrderDto> GetByOrder(string idOrder)
        {
            var result = dbSet.Where(w => w.Orders.IdOrder.Equals(idOrder)).ToList();
            return mapper.Map<List<ReceptionOrderDto>>(result);
        }

        public List<ReceptionPurchaseDto> GetByPurchase(string idPurchase)
        {
            var result = dbSet.Where(w => w.Purchase.IdPurchase.Equals(idPurchase)).ToList();
            return mapper.Map<List<ReceptionPurchaseDto>>(result);
        }

        public List<ReceptionDto> GetByStore(string idStore)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<ReceptionDto>>(result);
        }

        public List<ReceptionDto> GetByStore(string idStore, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReceptionDto>>(result);
        }
        public List<ReceptionDto> GetByStore(string idStore, DateTime date)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore) 
            && (DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)))
                .ToList();
            return mapper.Map<List<ReceptionDto>>(result);
        }

        public List<ReceptionDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore)
            && (DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReceptionDto>>(result);
        }

        public new dynamic Insert(List<Reception>list)
        {
            foreach (Reception entity in list)
            {
                foreach (ReceptionLine line in entity.ReceptionLine)
                {
                    Context.BookStore.Where(w => w.IdBook.Equals(line.IdBook) && w.IdStore.Equals(entity.IdStore)).SingleOrDefault().Stock += line.Quantity;
                }
            }
            dbSet.AddRange(mapper.Map<List<Reception>>(list));
            return Save();
        }

    }
}