using Ado.User.Abstracts;
using Models.Ado.Library;
using Models.Ado.Login;
using Nucleo.DBAccess.Ado;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.User.Specifics
{
    public class UserRepository : Repository<Users> , IUserRepository
    {
        public UserRepository(ApiUsersEntities context, string identificator="IdUser") : base(context, identificator)
        {
        }
    }
}
