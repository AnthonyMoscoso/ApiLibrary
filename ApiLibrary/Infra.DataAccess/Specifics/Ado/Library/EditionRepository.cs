using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;


namespace Ado.Library.Specifics
{
    public class EditionRepository : AdoRepository<Edition>, IEditionRepository
    {
        public EditionRepository(BookStoreEntities context,string identificator="IdEdition") : base(context,identificator)
        {
        }

        public IEnumerable<Edition> SearchByName(string text)
        {
            return dbSet.Where(w => w.EditionName.Contains(text)); 
        }

        public IEnumerable<Edition> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.EditionName.Contains(text))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element);
        }
    }
}