using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Books
{
    interface IBookStoreRepository : IRepository<BookStore>
    {
        int GetStock(string idBook, string idStore);
    }
}
