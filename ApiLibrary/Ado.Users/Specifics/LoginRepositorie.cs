using Ado.User.Abstracts;
using Models.Ado.Login;
using Models.Models.Login;
using System.Linq;

namespace Ado.User.Specifics
{
    public class LoginRepositorie  : ILoginRepository
    {
        readonly ApiUsersEntities apiUsersEntities = new ApiUsersEntities();

        public dynamic Login(LoginRequest login)
        {
            Users search = apiUsersEntities.Users.Where(w => w.Username == login.Username).FirstOrDefault();
            bool canLogin = false;
            if (search!=null)
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