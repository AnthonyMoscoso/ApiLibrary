using Models.Ado.Library;
using System.Collections.Generic;
using System.Linq;
using Core.DBAccess.Ado;
using System.Data.Entity;

namespace Ado.Library.Specifics
{
    public class AutorRepository : AdoRepository<Autor>, IAutorRepository
    {
        public new readonly BookStoreEntities _Context;
        public AutorRepository(BookStoreEntities context, string identificator="IdAutor") : base(context, identificator)
        {
        }

        public bool ExistName(string name)
        {
            var result =dbSet.Where(W => W.AutorName.Equals(name)).SingleOrDefault();
            if (result!=null)
            {
               return true;
            }
            return false;
        }

        public Autor GetByName(string name)
        {
            var result = dbSet.Where(w => w.AutorName.Equals(name)).SingleOrDefault();
            return result;
        }

        public IEnumerable<Autor> SearchByName(string text)
        {
            var result= dbSet.Where(w => w.AutorName.Contains(text));
            return result;
        }

        public IEnumerable<Autor> SearchByName(string text, int pag, int element)
        {
            var result= dbSet.Where(w => w.AutorName.Contains(text))
                .OrderBy(w=> w.AutorName)
                .Skip((pag-1)*element)
                .Take(element).ToList();
            return result;
        }
    }
}