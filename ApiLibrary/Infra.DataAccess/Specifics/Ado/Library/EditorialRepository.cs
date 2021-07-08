using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;


namespace Ado.Library.Specifics
{
    public class EditorialRepository : AdoRepository<Editorial>, IEditorialRepository
    {
        public EditorialRepository(BookStoreEntities context, string identificator="IdEditorial") : base(context,identificator)
        {
        }

        public IEnumerable<Editorial> SearchByName(string text)
        {
            return dbSet.Where(w => w.EditorialName.Contains(text));
        }

        public IEnumerable<Editorial> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.EditorialName.Contains(text)).OrderBy(W => W.CreateDate).Skip((pag - 1) * element).Take(element);
        }
    }
}