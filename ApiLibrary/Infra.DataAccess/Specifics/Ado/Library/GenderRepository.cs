using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;


namespace Ado.Library.Specifics
{
    public class GenderRepository : AdoRepository<Gender>, IGenderRepository
    {
        public GenderRepository(BookStoreEntities context, string identificator="IdGender") : base(context,identificator)
        {
        }

        public IEnumerable<Gender> SearchByName(string text)
        {
            IEnumerable<Gender> list = dbSet.Where(w => w.GenderName.Contains(text));
            return list;
        }

        public IEnumerable<Gender> SearchByName(string text, int pag, int element)
        {
            IEnumerable<Gender> list = dbSet.Where(w => w.GenderName.Contains(text))
                .OrderBy(w => w.GenderName)
                .Skip((pag - 1) * element)
                .Take(element);
            return list;
        }

    }
}