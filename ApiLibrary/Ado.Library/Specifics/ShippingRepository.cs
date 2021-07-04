using Models.Dtos;
using System;
using System.Collections.Generic;
using Models.Ado.Library;
using System.Data.Entity;
using System.Linq;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{
    public class ShippingRepository : AdoRepository<Shipping>, IShippingRepository
    {
        public ShippingRepository(BookStoreEntities context,  string identificator = "IdShipping") : base(context, identificator)
        {
        }

        #region Arrival Date
        public IEnumerable<Shipping> GetByArrivalDate(DateTime date)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.ArrivalDate.HasValue && DbFunctions.TruncateTime(w.ArrivalDate.Value) == DbFunctions.TruncateTime(date));
            return (result);
        }

        public IEnumerable<Shipping> GetByArrivalDate(DateTime date, int pag, int element)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => DbFunctions.TruncateTime(w.ArrivalDate.Value) == DbFunctions.TruncateTime(date))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }

        public IEnumerable<Shipping> GetByArrivalDate(DateTime start, DateTime end, int pag, int element)
        {
            IEnumerable<Shipping> result= dbSet.Where(w=> DbFunctions.TruncateTime(w.ArrivalDate.Value)>= DbFunctions.TruncateTime(start) 
            && DbFunctions.TruncateTime(w.ArrivalDate.Value)<= DbFunctions.TruncateTime(end))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }

        public IEnumerable<Shipping> GetByArrivalDate(DateTime start, DateTime end)
        {
            IEnumerable<Shipping> result= dbSet.Where(w => DbFunctions.TruncateTime(w.ArrivalDate.Value) 
            >= DbFunctions.TruncateTime(start) 
            && DbFunctions.TruncateTime(w.ArrivalDate.Value) <= DbFunctions.TruncateTime(end))
            ;
            return (result);
        }
        #endregion

        #region Book
        public IEnumerable<Shipping> GetByBook(string idBook)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.ShippingLine.Any(s => s.IdBook.Equals(idBook)));
            return (result);
        }

        public IEnumerable<Shipping> GetByBook(string idBook, int pag, int element)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.ShippingLine.Any(s => s.IdBook.Equals(idBook)))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }
        #endregion

        #region DepartureDate 

        public IEnumerable<Shipping> GetByDepartureDate(DateTime date, int pag, int element)
        {
            IEnumerable<Shipping> result = dbSet.Where(w =>DbFunctions.TruncateTime(w.DepartureDate)==(DbFunctions.TruncateTime(date.Date)))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }

        public IEnumerable<Shipping> GetByDepartureDate(DateTime start, DateTime end, int pag, int element)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => DbFunctions.TruncateTime(w.DepartureDate) >=  DbFunctions.TruncateTime(start) 
            && DbFunctions.TruncateTime( w.DepartureDate) <= DbFunctions.TruncateTime( end))
                .OrderBy(w=> w.CreateDate)
               .Skip((pag - 1) * element)
               .Take(element)
               ;
            return (result);
        }
        public IEnumerable<Shipping> GetByDepartureDate(DateTime date)
        {
            IEnumerable<Shipping> result = dbSet.Where( w => DbFunctions.TruncateTime( w.DepartureDate)==(DbFunctions.TruncateTime( date)));
            return (result);
        }

        public IEnumerable<Shipping> GetByDepartureDate(DateTime start, DateTime end)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => DbFunctions.TruncateTime(w.DepartureDate) >= DbFunctions.TruncateTime(start) 
            && DbFunctions.TruncateTime(w.DepartureDate) <= DbFunctions.TruncateTime(end))
                ;
            return (result);
        }
        #endregion

        #region ExitAddress
        public IEnumerable<Shipping> GetByExitAddress(string idAddress)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.IdDirectionFrom.Equals(idAddress));
            return (result);
        }

        public IEnumerable<Shipping> GetByExitAddress(string idAddress, int pag, int element)
        {
            IEnumerable<Shipping> result = dbSet.Where(w=>w.IdDirectionFrom.Equals(idAddress))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }
        public IEnumerable<Shipping> GetByExitAddress( string idExitAddress,int status)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.ShippingStatus == status && w.IdDirectionFrom.Equals(idExitAddress));
            return (result);
        }

        public IEnumerable<Shipping> GetByExitAddress( string idExitAddress, int status, int pag, int element)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.ShippingStatus == status && w.IdDirectionFrom.Equals(idExitAddress))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }
        #endregion

        #region Recipent Addrees 
        public IEnumerable<Shipping> GetByRecipientAddress(string idAddrees)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.IdDirectionTo.Equals(idAddrees));
            return (result);
        }

        public IEnumerable<Shipping> GetByRecipientAddress(string idAddrees, int pag, int element)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.IdDirectionTo.Equals(idAddrees))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element);
            return (result);
        }
        public IEnumerable<Shipping> GetByRecipientAddress( string idRecipient, int status)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.ShippingStatus == status && w.IdDirectionTo.Equals(idRecipient));
            return (result);
        }

        public IEnumerable<Shipping> GetByRecipientAddress( string idRecipient, int status, int pag, int element)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.ShippingStatus == status && w.IdDirectionTo.Equals(idRecipient))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return (result);
        }
        #endregion

        #region Status 
        public IEnumerable<Shipping> GetByStatus(int status)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.ShippingStatus == status);
            return (result);
        }

        public IEnumerable<Shipping> GetByStatus(int status, int pag, int element)
        {
            IEnumerable<Shipping> result = dbSet.Where(w => w.ShippingStatus == status)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element);
            return (result);
        }

        #endregion

     

        private void ModifyStock(List<ShippingLine>lines,string idWareHouse)
        {
            foreach (ShippingLine line in lines)
            {
                _Context.Set<WareHouseBook>().Where(w => w.IdBook.Equals(line.IdBook) && w.IdWareHouse.Equals(idWareHouse)).SingleOrDefault().Stock -= line.Quantity;   
            }
        }

       
     
    }
}