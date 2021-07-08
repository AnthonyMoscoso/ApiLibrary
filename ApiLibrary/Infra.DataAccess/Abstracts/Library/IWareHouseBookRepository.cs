using Models.Ado.Library;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IWareHouseBookRepository : IRepository<WareHouseBook>
    {
        int GetStock(string idBook, string idStore);
    }
}
