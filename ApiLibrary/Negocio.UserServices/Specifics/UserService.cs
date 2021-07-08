
using Models.Ado.Login;
using Models.Dtos.User;
using Models.Models.Login;
using Businness.UserServices.Abstracts;
using Core.Services.Abstracts;
using Ado.User.Abstracts;
using Core.Logger.Abstracts;

namespace Businness.UserServices.Specifics
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
