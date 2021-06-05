using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class RegisterLineRepository : Repository<RegisterLine>, IRegisterLineRepository
    {
        public RegisterLineRepository(BookStoreEntities context,string identificator="IdRegisterLine") : base(context,identificator)
        {
        }

        public IEnumerable<RegisterLine> GetByRegister(string idRegister)
        {
            var list= dbSet.Where(w => w.IdRegister.Equals(idRegister));
            return (list);
        }
    }
}