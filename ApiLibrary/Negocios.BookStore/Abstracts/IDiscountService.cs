using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IDiscountService : IServices<DiscountDto>
    {
        IEnumerable<DiscountDto> GetNotFinnalized();
        IEnumerable<DiscountDto> GetNotFinnalized(int pag, int element);
        IEnumerable<DiscountDto> GetFinnalized();
        IEnumerable<DiscountDto> GetFinnalized(int pag, int element);
        DiscountDto GetByBook(string idBook);
    }
}
