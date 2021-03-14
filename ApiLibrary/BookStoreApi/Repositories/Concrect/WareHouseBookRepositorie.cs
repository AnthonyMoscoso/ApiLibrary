using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.WareHouses;
using LibraryApiRest.Repositories.Concrect;
using System.Linq;

namespace BookStoreApi.Repositories.Concrect.WareHouses
{
    public class WareHouseBookRepositorie : Repositorie<WareHouseBook>, IWareHouseBookRepositorie
    {
        public WareHouseBookRepositorie(string identificator="IdWareHouseBook") : base(identificator)
        {
        }
        public int GetStock(string idBook, string idWareHouse)
        {

            int stock = dbSet.Where(w => w.IdBook == idBook && w.IdWareHouse == idWareHouse).SingleOrDefault().Stock;
            return stock;
        }
    }
}