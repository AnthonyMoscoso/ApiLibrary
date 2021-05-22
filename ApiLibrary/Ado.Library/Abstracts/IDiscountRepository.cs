using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IDiscountRepository : IRepository<Discount>
    {
        List<Discount> GetNotFinnalized();
        List<Discount> GetNotFinnalized(int pag,int element);
        List<Discount> GetFinnalized();
        List<Discount> GetFinnalized(int pag, int element);
        Discount GetByBook(string idBook);
    }
}
