using Autofac;
using Autofac.Integration.Mvc;
using ProjectTemplate.IOC.AutofacModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;

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