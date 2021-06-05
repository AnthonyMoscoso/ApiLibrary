using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
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
    public class ReturnSaleService : ServiceMapperBase<ReturnSaleDto, ReturnSale>, IReturnSaleService
    {
        public ReturnSaleService(IReturnSaleRepository repository) : base(repository)
        {
        }

        public IEnumerable<ReturnSaleDto> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByMethod(int RepaymentMethod)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByMethod(int RepaymentMethod, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByMethod(int RepaymentMethod, string idStore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByMethod(int RepaymentMethod, string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByMotive(string motive)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByMotive(string motive, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByMotive(string motive, string idStore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByMotive(string motive, string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetBySale(string idSale)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByStore(string idStore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByStore(string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByStore(string idStore, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByWareHouse(string idWareHouse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByWareHouse(string idWareHouse, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReturnSaleDto> GetByWareHouse(string idWareHouse, DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
