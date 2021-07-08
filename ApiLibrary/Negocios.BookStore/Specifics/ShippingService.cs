using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class ShippingService : ServiceMapperBase<ShippingDto, Shipping>, IShippingService
    {
        public ShippingService(IShippingRepository repository) : base(repository)
        {
        }

        public IEnumerable<ShippingDto> GetByArrivalDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByArrivalDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByArrivalDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByArrivalDate(DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByBook(string idBook)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByBook(string idBook, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByDepartureDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByDepartureDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByDepartureDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByDepartureDate(DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByExitAddress(string idAddress)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByExitAddress(string idExitAddress, int status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByExitAddress(string idExitAddress, int status, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByExitAddress(string idAddress, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByRecipientAddress(string idAddrees)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByRecipientAddress(string idAddrees, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByRecipientAddress(string idRecipient, int status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByRecipientAddress(string idRecipient, int status, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByStatus(int status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShippingDto> GetByStatus(int status, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
