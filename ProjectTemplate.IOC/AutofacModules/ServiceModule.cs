using Autofac;
using System.Linq;
using System.Reflection;

namespace ProjectTemplate.IOC.AutofacModules
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var asm = Assembly.Load("ProjectTemplate.Service");
            builder.RegisterAssemblyTypes(asm)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerRequest();
        }
    }
}