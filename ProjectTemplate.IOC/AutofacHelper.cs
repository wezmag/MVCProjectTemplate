using Autofac;
using Autofac.Integration.Mvc;
using ProjectTemplate.IOC.AutofacModules;
using System.Reflection;
using System.Web.Mvc;

namespace ProjectTemplate.IOC
{
    public class AutofacHelper
    {
        public static void Bootstrapper(Assembly MvcApplication)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(MvcApplication);
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ServiceModule());
            builder.RegisterModule(new EFModule());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}