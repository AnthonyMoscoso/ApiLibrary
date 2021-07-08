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
    public class SaleLineService : ServiceMapperBase<SaleLineDto, SaleLine>, ISaleLineService
    {
        public SaleLineService(ISaleLineRepository repository) : base(repository)
        {
        }

        public IEnumerable<SaleLineDto> GetBySale(string idSale)
        {
            throw new NotImplementedException();
        }
    }
}
