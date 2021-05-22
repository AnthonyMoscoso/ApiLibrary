using Models.Ado.Library;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IBookEditorialRepository : IRepository<BookEditorial>
    {
        double GetPurchasePrice(string idBook, string idEditorial);
    }
}
