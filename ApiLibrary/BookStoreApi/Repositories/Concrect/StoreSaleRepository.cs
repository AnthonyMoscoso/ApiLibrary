using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect
{
    public class StoreSaleRepository : Repository<StoreSale>, IStoreSaleRepository
    {
        public StoreSaleRepository(string identificator="idStoreSale") : base(identificator)
        {
        }
        #region Buyer

        public List<StoreSaleDto> GetByBuyer(string idBuyer)
        {
            var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer)).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByBuyer(string idBuyer, int pag, int element)
        {
            var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer))
            .OrderBy(w => w.Sale.CreateDate)
            .Skip((pag-1)*element)
            .Take(element)
            .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByBuyer(string idBuyer, DateTime date)
        {
            DateTime tomorrow = date.AddDays(1);
            var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer) && (w.Sale.CreateDate>date & w.Sale.CreateDate<tomorrow))
            .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByBuyer(string idBuyer, DateTime date, int pag, int element)
        {
            DateTime tomorrow = date.AddDays(1);
            var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer) && (w.Sale.CreateDate > date & w.Sale.CreateDate < tomorrow))
            .OrderBy(w => w.Sale.CreateDate)
            .Skip((pag - 1) * element)
            .Take(element)
            .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByBuyer(string idBuyer, DateTime start, DateTime end)
        {
            var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer) && (w.Sale.CreateDate >= start & w.Sale.CreateDate <= end))
           .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByBuyer(string idBuyer, DateTime start, DateTime end, int pag, int element)
        {
            var list = dbSet.Where(w => w.Sale.IdBuyer.Equals(idBuyer) && (w.Sale.CreateDate >= start & w.Sale.CreateDate <= end))
                .OrderBy(w => w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByDate(DateTime date)
        {
            DateTime tomorrow=date.AddDays(1);
            var list = dbSet.Where(w => w.Sale.CreateDate > date & w.Sale.CreateDate < tomorrow).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByDate(DateTime date, int pag, int element)
        {
            DateTime tomorrow = date.AddDays(1);
            var list = dbSet.Where(w => w.Sale.CreateDate > date & w.Sale.CreateDate < tomorrow)
                .OrderBy(w => w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByDate(DateTime start, DateTime end)
        {
            var list = dbSet.Where(w => w.Sale.CreateDate > start & w.Sale.CreateDate < end)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            var list = dbSet.Where(w => w.Sale.CreateDate > start & w.Sale.CreateDate < end)
              .OrderBy(w => w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }
        #endregion

        public List<StoreSaleDto> GetByPayMethod(int payMethod, string idStore)
        {
            var list =dbSet.Where(w=> w.Sale.PayMethod.Equals(payMethod) && w.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByPayMethod(int payMethod, string idStore, int pag, int element)
        {
            var list = dbSet.Where(w => w.Sale.PayMethod.Equals(payMethod) && w.IdStore.Equals(idStore))
                .OrderBy(w=> w.Sale.CreateDate)
                .Skip((pag-1)*element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByPayMethod(int payMethod)
        {
            var list = dbSet.Where(w => w.Sale.PayMethod.Equals(payMethod)).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByPayMethod(int payMethod, int pag, int element)
        {
            var list = dbSet.Where(w => w.Sale.PayMethod.Equals(payMethod))
                .OrderBy(w=> w.Sale.CreateDate)
                .Skip((pag-1)*element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStatus(int status, string idStore)
        {
            var list = dbSet.Where(w=> w.Sale.SaleStatus.Equals(status) && w.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStatus(int status, string idStore, int pag, int element)
        {
            var list = dbSet.Where(w=> w.Sale.SaleStatus.Equals(status) && w.IdStore.Equals(idStore))
                .OrderBy(w => w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStatus(int status)
        {
            var list = dbSet.Where(w => w.Sale.SaleStatus.Equals(status)).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStatus(int status, int pag, int element)
        {
            var list = dbSet.Where(w => w.Sale.SaleStatus.Equals(status))
                .OrderBy(w => w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStore(string idStore)
        {
            var list = dbSet.Where(w=> w.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStore(string idStore, int pag, int element)
        {
            var list = dbSet.Where(w => w.IdStore.Equals(idStore))
                .OrderBy(w => w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStore(string idStore, DateTime date)
        {
            DateTime tomorow = date.AddDays(1);
            var list = dbSet.Where(w=> w.IdStore.Equals(idStore) && (w.Sale.CreateDate>date && w.Sale.CreateDate<tomorow)).ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            DateTime tomorow = date.AddDays(1);
            var list = dbSet.Where(w => w.IdStore.Equals(idStore) && (w.Sale.CreateDate > date && w.Sale.CreateDate < tomorow))
                .OrderBy(w => w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end)
        {
            var list = dbSet.Where(w=> w.IdStore.Equals(idStore) && (w.Sale.CreateDate>= start && w.Sale.CreateDate<=end))
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public List<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            var list = dbSet.Where(w => w.IdStore.Equals(idStore) && (w.Sale.CreateDate >= start && w.Sale.CreateDate <= end))
                .OrderBy(w => w.Sale.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<StoreSaleDto>>(list);
        }

        public dynamic Insert(List<StoreSaleDto> list)
        {
            dbSet.AddRange(mapper.Map<List<StoreSale>>(list));
            Save();
            return ModifyStock(list);
          
        }

        public new dynamic Delete(List<string> ids)
        {
            string message = "";
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search!=null)
                {
                    Context.SaleLine.RemoveRange(Context.SaleLine.Where(w => w.IdSale.Equals(id)).ToList());
                    Context.Sale.Remove(search.Sale);
                    dbSet.Remove(search);
                    Save();
                    message+=string.Format("sale with id {0} was delete",id);
                }
                else
                {
                    message += string.Format("any entity was found with id {0}", id);
                }
            }
            return message;
        }

        public dynamic Update(List<StoreSaleDto>list)
        {
            foreach (StoreSaleDto entity in list)
            {
                foreach (SaleLine line in entity.SaleLine)
                {
                    Context.SaleLine.Attach(line);
                    Context.Entry(entity).State = EntityState.Modified;
                }

                StoreSale e = mapper.Map<StoreSale>(entity);
                dbSet.Attach(e);
                Context.Entry(e).State = EntityState.Modified;
            }
            return Save();
        }

        private dynamic ModifyStock(List<StoreSaleDto> list)
        {
            try
            {
                foreach (StoreSaleDto entity in list)
                {
                    ModifyStockInStore(entity.SaleLine.ToList(), entity.IdStore);

                }
                return Save(); 
            }
            catch (Exception e)
            {
                var error = e.Message;
                return e.Message;
            }
       
        }

        private void ModifyStockInStore(List<SaleLine> list, string idStore)
        {

                foreach (SaleLine entity in list)
                {
                   Context.BookStore.Where(w => w.IdBook.Equals(entity.IdBook) && w.IdStore.Equals(idStore)).SingleOrDefault().Stock-=entity.Quantity;
                   Context.SaveChanges();
            } 
        }

        public new List<StoreSaleDto> Get()
        {
            return mapper.Map<List<StoreSaleDto>>(dbSet.ToList());
        }

    }
}