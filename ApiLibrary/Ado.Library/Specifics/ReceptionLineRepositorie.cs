using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Receptions
{
    public class ReceptionLineRepositorie : Repository<ReceptionLine,ReceptionLineDto>, IReceptionLineRepositorie
    {
        public ReceptionLineRepositorie(string identificator="IdReceptionLine") : base(identificator)
        {
        }

        public List<ReceptionLine> GetByReception(string idReception)
        {
            return dbSet.Where(w => w.IdReception.Equals(idReception)).ToList();
        }
    }
}