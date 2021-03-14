

using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Books;
using LibraryApiRest.Repositories.Concrect;
using System.Linq;

namespace BookStoreApi.Repositories.Concrect.Books
{
    public class BookEditorialRepositorie : Repositorie<BookEditorial>, IBookEditorialRepositorie
    {
        public BookEditorialRepositorie(string identificator="IdBookEditorial") : base(identificator)
        {
        }

        public double GetPurchasePrice(string idBook,string idEditorial)
        {
            double PurchasePrice = dbSet.Where(w => w.IdBook.Equals(idBook) && w.IdEditorial.Equals(idEditorial)).SingleOrDefault().PurchasePrice;
            return PurchasePrice;
        }
       
    }
}