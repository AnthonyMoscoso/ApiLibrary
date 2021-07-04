using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;

using Models.Dtos;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;
namespace Ado.Library.Specifics
{
    public class PermitRepository : AdoRepository<Permit>, IPermitRepository
    {
        public PermitRepository(BookStoreEntities context, string identificator="IdPermit") : base(context,identificator)
        {
        }

        public IEnumerable<Permit> SearchByName(string text)
        {
            return dbSet.Where(w => w.PermitName.Contains(text)).ToList();
        }

        public IEnumerable<Permit> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.PermitName.Contains(text))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
    }
}