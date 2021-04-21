using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Shippings;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Shippings
{
    public class ShippingRepository : Repository<Shipping,ShippingDto>, IShippingRepository
    {
        public ShippingRepository(string identificator="IdShipping") : base(identificator)
        {
        }

        #region Arrival Date
        public List<ShippingDto> GetByArrivalDate(DateTime date)
        {
            var result = dbSet.Where(w => w.ArrivalDate.HasValue && DbFunctions.TruncateTime(w.ArrivalDate.Value) == DbFunctions.TruncateTime(date)).ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        public List<ShippingDto> GetByArrivalDate(DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime(w.ArrivalDate.Value) == DbFunctions.TruncateTime(date))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        public List<ShippingDto> GetByArrivalDate(DateTime start, DateTime end, int pag, int element)
        {
            var result= dbSet.Where(w=> DbFunctions.TruncateTime(w.ArrivalDate.Value)>= DbFunctions.TruncateTime(start) 
            && DbFunctions.TruncateTime(w.ArrivalDate.Value)<= DbFunctions.TruncateTime(end))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        public List<ShippingDto> GetByArrivalDate(DateTime start, DateTime end)
        {
            var result= dbSet.Where(w => DbFunctions.TruncateTime(w.ArrivalDate.Value) 
            >= DbFunctions.TruncateTime(start) 
            && DbFunctions.TruncateTime(w.ArrivalDate.Value) <= DbFunctions.TruncateTime(end))
            .ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }
        #endregion

        #region Book
        public List<ShippingDto> GetByBook(string idBook)
        {
            var result = dbSet.Where(w => w.ShippingLine.Any(s => s.IdBook.Equals(idBook))).ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        public List<ShippingDto> GetByBook(string idBook, int pag, int element)
        {
            var result = dbSet.Where(w => w.ShippingLine.Any(s => s.IdBook.Equals(idBook)))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }
        #endregion

        #region DepartureDate 

        public List<ShippingDto> GetByDepartureDate(DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w =>DbFunctions.TruncateTime(w.DepartureDate)==(DbFunctions.TruncateTime(date.Date)))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        public List<ShippingDto> GetByDepartureDate(DateTime start, DateTime end, int pag, int element)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime(w.DepartureDate) >=  DbFunctions.TruncateTime(start) 
            && DbFunctions.TruncateTime( w.DepartureDate) <= DbFunctions.TruncateTime( end))
                .OrderBy(w=> w.CreateDate)
               .Skip((pag - 1) * element)
               .Take(element)
               .ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }
        public List<ShippingDto> GetByDepartureDate(DateTime date)
        {
            var result = dbSet.Where( w => DbFunctions.TruncateTime( w.DepartureDate)==(DbFunctions.TruncateTime( date))).ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        public List<ShippingDto> GetByDepartureDate(DateTime start, DateTime end)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime(w.DepartureDate) >= DbFunctions.TruncateTime(start) 
            && DbFunctions.TruncateTime(w.DepartureDate) <= DbFunctions.TruncateTime(end))
                .ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }
        #endregion

        #region ExitAddress
        public List<ShippingDto> GetByExitAddress(string idAddress)
        {
            var result = dbSet.Where(w => w.IdDirectionFrom.Equals(idAddress)).ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        public List<ShippingDto> GetByExitAddress(string idAddress, int pag, int element)
        {
            var result = dbSet.Where(w=>w.IdDirectionFrom.Equals(idAddress))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }
        public List<ShippingDto> GetByExitAddress( string idExitAddress,int status)
        {
            var result = dbSet.Where(w => w.ShippingStatus == status && w.IdDirectionFrom.Equals(idExitAddress)).ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        public List<ShippingDto> GetByExitAddress( string idExitAddress, int status, int pag, int element)
        {
            var result = dbSet.Where(w => w.ShippingStatus == status && w.IdDirectionFrom.Equals(idExitAddress))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }
        #endregion

        #region Recipent Addrees 
        public List<ShippingDto> GetByRecipientAddress(string idAddrees)
        {
            var result = dbSet.Where(w => w.IdDirectionTo.Equals(idAddrees)).ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        public List<ShippingDto> GetByRecipientAddress(string idAddrees, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdDirectionTo.Equals(idAddrees))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }
        public List<ShippingDto> GetByRecipientAddress( string idRecipient, int status)
        {
            var result = dbSet.Where(w => w.ShippingStatus == status && w.IdDirectionTo.Equals(idRecipient)).ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        public List<ShippingDto> GetByRecipientAddress( string idRecipient, int status, int pag, int element)
        {
            var result = dbSet.Where(w => w.ShippingStatus == status && w.IdDirectionTo.Equals(idRecipient))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }
        #endregion

        #region Status 
        public List<ShippingDto> GetByStatus(int status)
        {
            var result = dbSet.Where(w => w.ShippingStatus == status).ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        public List<ShippingDto> GetByStatus(int status, int pag, int element)
        {
            var result = dbSet.Where(w => w.ShippingStatus == status)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ShippingDto>>(result);
        }

        #endregion

       public new dynamic Insert(List<Shipping> list)
       {
            foreach (Shipping entity in list)
            {
                ModifyStock(entity.ShippingLine.ToList(),entity.IdWareHouse);
            }
            var shippings = mapper.Map<List<Shipping>>(list);
            dbSet.AddRange(shippings);
            return Save();

       }

        private void ModifyStock(List<ShippingLine>lines,string idWareHouse)
        {
            foreach (ShippingLine line in lines)
            {
                Context.WareHouseBook.Where(w => w.IdBook.Equals(line.IdBook) && w.IdWareHouse.Equals(idWareHouse)).SingleOrDefault().Stock -= line.Quantity;   
            }
        }

       
     
    }
}