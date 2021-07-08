using Models.Models.Login;

using Core.Tokens;
using System.Net;
using System.Threading;
using System.Web.Http;
using Businness.UserServices.Abstracts;

namespace Models.Controllers
{
    /// <summary>
    /// login controller class for authenticate users
    /// </summary>
    [AllowAnonymous]
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        readonly IUserService _service;

        public LoginController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("echoping")]
        public IHttpActionResult EchoPing()
        {
            return Ok(true);
        }

        [HttpGet]
        [Route("echouser")]
        public IHttpActionResult EchoUser()
        {
            var identity = Thread.CurrentPrincipal.Identity;
            return Ok($" IPrincipal-user: {identity.Name} - IsAuthenticated: {identity.IsAuthenticated}");
        }

        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(LoginRequest login)
        {
            if (login == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                if (_service.Login(login))
                {
                    var token = TokenGenerator.GenerateTokenJwt(login.Username);
                    return Ok(token);
                }
                else
                {
                    return Unauthorized();
                }
            }
        }
    }
}

