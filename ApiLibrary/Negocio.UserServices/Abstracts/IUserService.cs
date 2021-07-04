using Models.Dtos.User;
using Models.Models.Login;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.UserServices.Abstracts
{
    public interface IUserService : IServices<UserDto>
    {
        dynamic Login(LoginRequest login);
    }
}
