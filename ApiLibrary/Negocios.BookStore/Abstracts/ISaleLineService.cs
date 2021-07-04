using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface ISaleLineService : IServices<SaleLineDto>
    {
        IEnumerable<SaleLineDto> GetBySale(string idSale);
    }
}
