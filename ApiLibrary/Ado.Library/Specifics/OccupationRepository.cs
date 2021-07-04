using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace DBAccess.Ado.Repositories.Concrect
{
    public class OccupationRepository : AdoRepository<Occupation>, IOccupationRepository
    {
        public OccupationRepository(BookStoreEntities context, string identificator="IdOccupation") : base(context,identificator)
        {
        }

        public IEnumerable<Occupation> SearchByName(string text)
        {
            var list = dbSet.Where(w=>w.OcupationName.Contains(text)).ToList();
            return list;
        }

        public IEnumerable<Occupation> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.OcupationName.Contains(text))
                .OrderBy(w=> w.OcupationName)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
    }
}