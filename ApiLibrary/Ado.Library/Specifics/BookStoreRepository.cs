using Models.Ado.Library;
using System.Collections.Generic;
using System.Linq;
using Models.Dtos;
using Ado.Library;
using Nucleo.DBAccess.Ado;

namespace Models.Repositories.Concrect.Books
{
    public class BookStoreRepository : Repository<BookStore,BookStoreDto>, IBookStoreRepository
    {
        public BookStoreRepository(string identificator = "IdBookStore") : base(identificator)
        {
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="idBook"></param>
        /// <param name="idStore"></param>
        /// <returns></returns>
        public int GetStock(string idBook, string idStore)
        {

            int stock = dbSet.Where(w => w.IdBook == idBook && w.IdStore == idStore).SingleOrDefault().Stock;
            return stock;
        }

        public new List<BookStoreDto> Get(){
            var list = dbSet.ToList();
            return mapper.Map<List<BookStoreDto>>(list);
        }

        
    }
}