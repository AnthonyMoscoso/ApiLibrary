using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Discounts
{
    interface IDiscountRepository : IRepository<Discount>
    {
        List<Discount> GetNotFinnalized();
        List<Discount> GetNotFinnalized(int pag,int element);
        List<Discount> GetFinnalized();
        List<Discount> GetFinnalized(int pag, int element);
        Discount GetByBook(string idBook);
    }
}
