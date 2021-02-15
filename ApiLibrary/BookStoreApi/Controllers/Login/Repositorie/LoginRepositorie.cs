using BookStoreApi.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Controllers.Login.Repositorie
{
    public class LoginRepositorie
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