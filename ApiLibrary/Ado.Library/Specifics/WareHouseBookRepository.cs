using Models.Dtos;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{
    public class WareHouseBookRepository : AdoRepository<WareHouseBook>, IWareHouseBookRepository
    {
        public WareHouseBookRepository(BookStoreEntities context, string identificator="IdWareHouseBook") : base(context,identificator)
        {
        }

        public int GetStock(string idBook, string idWareHouse)
        {

            int stock = dbSet.Where(w => w.IdBook == idBook && w.IdWareHouse == idWareHouse).SingleOrDefault().Stock;
            return stock;
        }


    }
}