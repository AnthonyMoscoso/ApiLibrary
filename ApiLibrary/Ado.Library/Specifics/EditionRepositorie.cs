using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Editions
{
    public class EditionRepositorie : Repository<Edition,EditionDto>, IEditionRepositorie
    {
        public EditionRepositorie(string identificator="IdEdition") : base(identificator)
        {
        }

        public List<Edition> SearchByName(string text)
        {
            return dbSet.Where(w => w.EditionName.Contains(text)).ToList(); 
        }

        public List<Edition> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.EditionName.Contains(text))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
    }
}