using Models.Dtos;
using Models.Ado.Library;
using System.Collections.Generic;
using System.Linq;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class BookTypeRepository : Repository<BookType>, IBookTypeRepository
    {
        public BookTypeRepository(BookStoreEntities context, string identificator= "IdType") : base(context,identificator)
        {

        }

      
        public BookType GetByName(string name)
        {
            var list = dbSet.Where(w => w.TypeName.Equals(name)).FirstOrDefault();
            return list;
        }

        public IEnumerable<BookType> SearchByName(string text)
        {
            var list = dbSet.Where(w => w.TypeName.Contains(text));
            return list;
        }

        public IEnumerable<BookType> SearchByName(string text, int pag, int element)
        {
            var list = dbSet.Where(w => w.TypeName.Contains(text))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return list;
        }
    }
}