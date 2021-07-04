using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IWareHouseBookService : IServices<WareHouseBookDto>
    {
        int GetStock(string idBook, string idStore);
    }
}
