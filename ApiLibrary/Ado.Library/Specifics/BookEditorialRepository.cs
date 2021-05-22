

using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Nucleo.DBAccess.Ado;
using System.Linq;

namespace Models.Repositories.Concrect.Books
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