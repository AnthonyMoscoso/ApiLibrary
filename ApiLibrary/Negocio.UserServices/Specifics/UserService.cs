using Ado.User.Abstracts;
using Models.Ado.Login;
using Models.Dtos.User;
using Models.Models.Login;
using Negocio.UserServices.Abstracts;
using Nucleo.DBAccess.Ado;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.UserServices.Specifics
{
    public class UserService : ServiceMapperBase<UserDto, Users>, IUserService
    {
        public UserService(IUserRepository repository) : base(repository)
        {
        }

        public dynamic Login(LoginRequest login)
        {
            Users search = _repository.GetSingle(w => w.Username == login.Username);

            bool canLogin = false;
            if (search != null)
            {
                if (search.PassWord == login.Password)
                {
                    return true;
                }

            }
            return canLogin;
        }
    }
}
