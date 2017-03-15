using Autofac;
using System.Linq;
using System.Reflection;

namespace ProjectTemplate.IOC.AutofacModules
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var asm = Assembly.Load("ProjectTemplate.Data");
            builder.RegisterAssemblyTypes(asm)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerRequest();
        }
    }
}