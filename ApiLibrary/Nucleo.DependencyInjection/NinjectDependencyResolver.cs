using Ninject;
using System.Web.Http.Dependencies;

namespace Nucleo.DependencyInjection
{
    public class NinjectDependencyResolver : NinjectDependencyScope, IDependencyResolver
    { 
        private readonly IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
            : base(kernel)
        {
            this.kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(this.kernel.BeginBlock());
        }
    }
}
