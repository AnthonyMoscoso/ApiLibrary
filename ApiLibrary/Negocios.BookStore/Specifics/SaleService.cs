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

namespace Business.BookStoreServices.Specifics
{
    public class SaleService : ServiceMapperBase<SaleDto, Sale>, ISaleService
    {
        public SaleService(IRepository<Sale> repository) : base(repository)
        {
        }

        public IEnumerable<SaleDto> GetByBuyer(string idBuyer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetByBuyer(string idBuyer, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetByBuyer(string idBuyer, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetByBuyer(string idBuyer, DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetByBuyer(string idBuyer, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetByBuyer(string idBuyer, DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetByDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetByDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetByPayMethod(int payMethod)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetByPayMethod(int payMethod, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetBySaleStatus(int status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleDto> GetBySaleStatus(int status, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
