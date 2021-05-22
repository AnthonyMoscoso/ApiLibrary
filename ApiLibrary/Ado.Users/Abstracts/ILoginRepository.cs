using Models.Models.Login;

namespace Ado.User.Abstracts
{
    public interface ILoginRepository
    {
        dynamic Login(LoginRequest login);
    }
}
