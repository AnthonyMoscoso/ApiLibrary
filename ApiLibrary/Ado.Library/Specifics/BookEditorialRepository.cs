

using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Core.DBAccess.Ado;
using Core.Logger.Repository.Specifics;
using System.Linq;

namespace Ado.Library.Specifics
{
    public class BookEditorialRepository : AdoRepository<BookEditorial>, IBookEditorialRepository
    {
        public BookEditorialRepository(BookStoreEntities context, string identificator="IdBookEditorial") : base(context,identificator)
        {
        }

        public double GetPurchasePrice(string idBook,string idEditorial)
        {
            double PurchasePrice = dbSet.Where(w => w.IdBook.Equals(idBook) && w.IdEditorial.Equals(idEditorial)).SingleOrDefault().PurchasePrice;
            return PurchasePrice;
        }

       
    }
}