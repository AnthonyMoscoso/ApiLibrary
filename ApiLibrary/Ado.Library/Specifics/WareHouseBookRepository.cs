using Models.Dtos;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.WareHouses
{
    public class WareHouseBookRepository : Repository<WareHouseBook,WareHouseBookDto>, IWareHouseBookRepository
    {
        public WareHouseBookRepository(string identificator="IdWareHouseBook") : base(identificator)
        {
        }

        public int GetStock(string idBook, string idWareHouse)
        {

            int stock = dbSet.Where(w => w.IdBook == idBook && w.IdWareHouse == idWareHouse).SingleOrDefault().Stock;
            return stock;
        }


    }
}