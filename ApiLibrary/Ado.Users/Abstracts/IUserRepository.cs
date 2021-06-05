using Models.Ado.Login;
using Nucleo.DBAccess.Ado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.User.Abstracts
{
    public interface IUserRepository : IRepository<Users>
    {
    }
}
