using Ado.User.Abstracts;
using Models.Ado.Library;
using Models.Ado.Login;
using Core.DBAccess.Ado;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Logger.Repository.Specifics;

namespace Ado.User.Specifics
{
    public class UserRepository : AdoRepository<Users> , IUserRepository
    {
        public UserRepository(ApiUsersEntities context,  string identificator="IdUser") : base(context, identificator)
        {
        }
    }
}
