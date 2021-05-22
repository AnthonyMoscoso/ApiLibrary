using Models.Ado.Library;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IBookStoreRepository : IRepository<BookStore>
    {
        int GetStock(string idBook, string idStore);
    }
}
