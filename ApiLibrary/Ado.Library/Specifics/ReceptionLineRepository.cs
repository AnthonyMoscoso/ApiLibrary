using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class ReceptionLineRepository : Repository<ReceptionLine>, IReceptionLineRepository
    {
        public ReceptionLineRepository(BookStoreEntities context,string identificator="IdReceptionLine") : base(context,identificator)
        {
        }

        public IEnumerable<ReceptionLine> GetByReception(string idReception)
        {
            return dbSet.Where(w => w.IdReception.Equals(idReception));
        }
    }
}