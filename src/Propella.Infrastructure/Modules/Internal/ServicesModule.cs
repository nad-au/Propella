using Autofac;
using Propella.Infrastructure.Services.Integrations.Domain;

namespace Propella.Infrastructure.Modules.Internal
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DemographicsService>().AsImplementedInterfaces().InstancePerDependency();
            builder.RegisterType<ResidentialSearchService>().AsImplementedInterfaces().InstancePerDependency();
        }
    }
}