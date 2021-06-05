using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IRegisterLineRepository : IRepository<RegisterLine>
    {
        IEnumerable<RegisterLine> GetByRegister(string idRegister);
    }
}
