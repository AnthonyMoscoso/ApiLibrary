

using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Books;
using LibraryApiRest.Repositories.Concrect;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreApi.Repositories.Concrect.Books
{
    public class BookEditorialRepository : Repository<BookEditorial,BookEditorialDto>, IBookEditorialRepository
    {
        public BookEditorialRepository(string identificator="IdBookEditorial") : base(identificator)
        {
        }

        public double GetPurchasePrice(string idBook,string idEditorial)
        {
            double PurchasePrice = dbSet.Where(w => w.IdBook.Equals(idBook) && w.IdEditorial.Equals(idEditorial)).SingleOrDefault().PurchasePrice;
            return PurchasePrice;
        }

       
    }
}