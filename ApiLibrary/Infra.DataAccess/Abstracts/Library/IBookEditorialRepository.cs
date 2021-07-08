using Models.Ado.Library;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IBookEditorialRepository : IRepository<BookEditorial>
    {
        double GetPurchasePrice(string idBook, string idEditorial);
    }
}
