using Autofac;
using Propella.Application.Commands;

namespace Propella.Infrastructure.Modules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(ICommand<>).Assembly)
                .AsImplementedInterfaces()
                .InstancePerDependency();
        }
    }
}