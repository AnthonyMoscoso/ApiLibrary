using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Shippings;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Shippings
{
    public class ShippingRepositorie : Repository<Shipping>, IShippingRepositorie
    {
        public ShippingRepositorie(string identificator="IdShipping") : base(identificator)
        {
        }

        #region Arrival Date
        public List<Shipping> GetByArrivalDate(DateTime date)
        {
            return dbSet.Where(w => w.ArrivalDate.Value.Date.Equals(date.Date)).ToList();
        }

        public List<Shipping> GetByArrivalDate(DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.ArrivalDate.Value.Date.Equals(date.Date)).Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Shipping> GetByArrivalDate(DateTime start, DateTime end, int pag, int element)
        {
            return dbSet.Where(w=>w.ArrivalDate.Value.Date>=start.Date && w.ArrivalDate.Value.Date<=end.Date)
                .Skip((pag - 1) * element).Take(element).ToList();

        }

        public List<Shipping> GetByArrivalDate(DateTime start, DateTime end)
        {
            return dbSet.Where(w => w.ArrivalDate.Value.Date >= start.Date && w.ArrivalDate.Value.Date <= end.Date)
            .ToList();
        }
        #endregion

        #region Book
        public List<Shipping> GetByBook(string idBook)
        {
            return dbSet.Where(w => w.ShippingLine.Any(s => s.IdBook.Equals(idBook))).ToList();
        }

        public List<Shipping> GetByBook(string idBook, int pag, int element)
        {
            return dbSet.Where(w => w.ShippingLine.Any(s => s.IdBook.Equals(idBook))).Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region DepartureDate 

        public List<Shipping> GetByDepartureDate(DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.DepartureDate.Date.Equals(date.Date)).Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Shipping> GetByDepartureDate(DateTime start, DateTime end, int pag, int element)
        {
            return dbSet.Where(w => w.ArrivalDate.Value.Date >= start.Date && w.ArrivalDate.Value.Date <= end.Date)
               .Skip((pag - 1) * element).Take(element).ToList();
        }
        public List<Shipping> GetByDepartureDate(DateTime date)
        {
            return dbSet.Where(w => w.DepartureDate.Date.Equals(date.Date)).ToList();
        }

        public List<Shipping> GetByDepartureDate(DateTime start, DateTime end)
        {
            return dbSet.Where(w => w.DepartureDate.Date >= start.Date && w.DepartureDate.Date <= end.Date)
         .ToList();
        }
        #endregion

        #region ExitAddress
        public List<Shipping> GetByExitAddress(string idAddress)
        {
            return dbSet.Where(w => w.IdDirectionFrom.Equals(idAddress)).ToList();
        }

        public List<Shipping> GetByExitAddress(string idAddress, int pag, int element)
        {
            return dbSet.Where(w=>w.IdDirectionFrom.Equals(idAddress)).Skip((pag - 1) * element).Take(element).ToList();
        }
        public List<Shipping> GetByExitAddress( string idExitAddress,int status)
        {
            return dbSet.Where(w => w.StatusCode == status && w.IdDirectionFrom.Equals(idExitAddress)).ToList();
        }

        public List<Shipping> GetByExitAddress( string idExitAddress, int status, int pag, int element)
        {
            return dbSet.Where(w => w.StatusCode == status && w.IdDirectionFrom.Equals(idExitAddress)).Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region Recipent Addrees 
        public List<Shipping> GetByRecipientAddress(string idAddrees)
        {
            return dbSet.Where(w => w.IdDirectionTo.Equals(idAddrees)).ToList();
        }

        public List<Shipping> GetByRecipientAddress(string idAddrees, int pag, int element)
        {
            return dbSet.Where(w => w.IdDirectionTo.Equals(idAddrees)).Skip((pag - 1) * element).Take(element).ToList();
        }
        public List<Shipping> GetByRecipientAddress( string idRecipient, int status)
        {
            return dbSet.Where(w => w.StatusCode == status && w.IdDirectionTo.Equals(idRecipient)).ToList();
        }

        public List<Shipping> GetByRecipientAddress( string idRecipient, int status, int pag, int element)
        {
            return dbSet.Where(w => w.StatusCode == status && w.IdDirectionTo.Equals(idRecipient)).Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region Status 
        public List<Shipping> GetByStatus(int status)
        {
            return dbSet.Where(w=> w.StatusCode==status).ToList();
        }

        public List<Shipping> GetByStatus(int status, int pag, int element)
        {
            return dbSet.Where(w => w.StatusCode == status).Skip((pag - 1) * element).Take(element).ToList();
        }

        #endregion

       public dynamic Insert(List<ShippingDto> list)
       {
            foreach (ShippingDto dto in list)
            {
                ModifyStock(dto.ShippingLine,dto.IdWareHouse);
            }
            var shippings = mapper.Map<List<Shipping>>(list);
            dbSet.AddRange(shippings);
            return Save();

       }

        private void ModifyStock(List<ShippingLineDto>dtos,string idWareHouse)
        {
            foreach (ShippingLineDto lineDto in dtos)
            {
                Context.WareHouseBook.Where(w => w.IdBook.Equals(lineDto.IdBook) && w.IdWareHouse.Equals(idWareHouse)).SingleOrDefault().Stock -= lineDto.Quantity;   
            }
        }

        public new List<ShippingDto> Get()
        {
            var list = dbSet.ToList();
            return mapper.Map<List<ShippingDto>>(list);
        }

        public new ShippingDto Get(string id)
        {
            Shipping shipping= base.Get(id);
            return mapper.Map<ShippingDto>(shipping);
        }

        public new ShippingDto 
     
    }
}