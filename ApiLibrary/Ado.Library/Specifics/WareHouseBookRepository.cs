using Models.Dtos;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class WareHouseBookRepository : Repository<WareHouseBook>, IWareHouseBookRepository
    {
        public WareHouseBookRepository(BookStoreEntities context,string identificator="IdWareHouseBook") : base(context,identificator)
        {
        }

        public int GetStock(string idBook, string idWareHouse)
        {

            int stock = dbSet.Where(w => w.IdBook == idBook && w.IdWareHouse == idWareHouse).SingleOrDefault().Stock;
            return stock;
        }


    }
}