using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.WareHouses;
using LibraryApiRest.Repositories.Concrect;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreApi.Repositories.Concrect.WareHouses
{
    public class WareHouseBookRepository : Repository<WareHouseBook>, IWareHouseBookRepositorie
    {
        public WareHouseBookRepository(string identificator="IdWareHouseBook") : base(identificator)
        {
        }

        public new List<WareHouseBookDto> Get()
        {
            var list = dbSet.ToList();
            return mapper.Map<List<WareHouseBookDto>>(list);
        }
        public int GetStock(string idBook, string idWareHouse)
        {

            int stock = dbSet.Where(w => w.IdBook == idBook && w.IdWareHouse == idWareHouse).SingleOrDefault().Stock;
            return stock;
        }


    }
}