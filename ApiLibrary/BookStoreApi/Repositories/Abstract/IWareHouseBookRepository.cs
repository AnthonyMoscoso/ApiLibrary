using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;

namespace BookStoreApi.Repositories.Abstract.WareHouses
{
    interface IWareHouseBookRepository : IRepository<WareHouseBook>
    {
        int GetStock(string idBook, string idStore);
    }
}
