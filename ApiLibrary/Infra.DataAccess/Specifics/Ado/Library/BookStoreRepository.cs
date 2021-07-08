using Models.Ado.Library;
using System.Collections.Generic;
using System.Linq;
using Models.Dtos;
using Ado.Library;
using Core.DBAccess.Ado;


namespace Ado.Library.Specifics
{
    public class BookStoreRepository : AdoRepository<BookStore>, IBookStoreRepository
    {
        public BookStoreRepository(BookStoreEntities context, string identificator="IdBookStore") : base(context,identificator)
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

    }
}