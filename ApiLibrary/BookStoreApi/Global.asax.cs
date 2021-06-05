
using Negocios.AutoMapper;
using Negocios.DependencyInjection;
using Ninject;
using Ninject.Modules;
using Nucleo.DependencyInjection;
using System.Web;
using System.Web.Http;

namespace WebApplication1
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapperConfig.RegisterMappings();

            NinjectModule registrations = new ModuleNinject();
            var kernel = new StandardKernel(registrations);
            var ninjectResolver = new NinjectDependencyResolver(kernel);

      //      DependencyResolver.SetResolver(ninjectResolver); // MVC
            GlobalConfiguration.Configuration.DependencyResolver = ninjectResolver; // Web API

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings
            .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters
                .Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
            GlobalConfiguration.Configure(WebApiConfig.Register);
       
        }
    }
}