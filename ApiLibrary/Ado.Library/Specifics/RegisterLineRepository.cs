using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Registers
{
    public class RegisterLineRepository : Repository<RegisterLine,RegisterLineDto>, IRegisterLineRepository
    {
        public RegisterLineRepository(string identificator="IdRegisterLine") : base(identificator)
        {
        }

        public List<RegisterLineDto> GetByRegister(string idRegister)
        {
            var list= dbSet.Where(w => w.IdRegister.Equals(idRegister)).ToList();
            return mapper.Map<List<RegisterLineDto>>(list);
        }
    }
}