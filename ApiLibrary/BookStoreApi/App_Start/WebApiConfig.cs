
using BookStoreApi.GlobalHandler;
using Core.MiddleWareService;
using Core.Tokens;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace WebApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            config.Filters.Add(new CustomExceptionFilter());
            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());
            config.MapHttpAttributeRoutes();
            config.MessageHandlers.Add(new TokenValidationHandler());
            config.Routes.MapHttpRoute(
                name: "BookStoreApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
