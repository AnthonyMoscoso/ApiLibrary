using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Models.Repositories.Abstract;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.DBAccess.Ado;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Specifics
{
    public class StoreSaleService : ServiceMapperBase<StoreSaleDto, StoreSale>, IStoreSaleService
    {
        public StoreSaleService(IStoreSaleRepository repository) : base(repository)
        {
        }

        public IEnumerable<StoreSaleDto> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreSaleDto> GetByDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreSaleDto> GetByDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreSaleDto> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreSaleDto> GetByStatus(int status, string idStore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreSaleDto> GetByStatus(int status, string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreSaleDto> GetByStore(string idStore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreSaleDto> GetByStore(string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreSaleDto> GetByStore(string idStore, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreSaleDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
