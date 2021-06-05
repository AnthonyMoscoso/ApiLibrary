using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IWareHouseBookService : IServices<WareHouseBookDto>
    {
        int GetStock(string idBook, string idStore);
    }
}
