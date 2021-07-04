
using Business.AutoMapper;
using Business.DependencyInjection;
using Core.DependencyInjection;
using Ninject;
using Ninject.Modules;
using System.Web;
using System.Web.Http;

namespace WebApplication
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapperConfig.RegisterMappings();


            NinjectModule registrations = new ModuleNinject();
            StandardKernel kernel = new StandardKernel(registrations);

            NinjectDependencyResolver ninjectResolver = new NinjectDependencyResolver(kernel);
            //      DependencyResolver.SetResolver(ninjectResolver); // MVC
            GlobalConfiguration.Configuration.DependencyResolver = ninjectResolver;
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings
            .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters
                .Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
            GlobalConfiguration.Configure(WebApiConfig.Register);
       
        }
    }
}