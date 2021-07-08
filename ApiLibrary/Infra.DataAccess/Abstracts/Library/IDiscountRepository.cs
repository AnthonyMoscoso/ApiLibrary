using Models.Ado.Library;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IDiscountRepository : IRepository<Discount>
    {
        IEnumerable<Discount> GetNotFinnalized();
        IEnumerable<Discount> GetNotFinnalized(int pag,int element);
        IEnumerable<Discount> GetFinnalized();
        IEnumerable<Discount> GetFinnalized(int pag, int element);
        Discount GetByBook(string idBook);
    }
}
