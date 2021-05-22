using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;

using Models.Dtos;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Permits
{
    public class PermitRepository : Repository<Permit,PermitDto>, IPermitRepository
    {
        public PermitRepository(string identificator="IdPermit") : base(identificator)
        {
        }

        public List<Permit> SearchByName(string text)
        {
            return dbSet.Where(w=>w.PermitName.Contains(text)).ToList();
        }

        public List<Permit> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.PermitName.Contains(text))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
    }
}