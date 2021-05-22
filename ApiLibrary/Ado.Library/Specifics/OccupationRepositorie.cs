using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace DBAccess.Ado.Repositories.Concrect.Occupations
{
    public class OccupationRepositorie : Repository<Occupation,OccupationDto>, IOccupationRepositorie
    {
        public OccupationRepositorie(string identificator="IdOccupation") : base(identificator)
        {
        }

        public List<Occupation> SearchByName(string text)
        {
            var list = dbSet.Where(w=>w.OcupationName.Contains(text)).ToList();
            return list;
        }

        public List<Occupation> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.OcupationName.Contains(text))
                .OrderBy(w=> w.OcupationName)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
    }
}