using Autofac;
using Propella.Infrastructure.Modules.Internal;
using Propella.Infrastructure.Services.Integrations.Domain;

namespace Propella.Infrastructure.Modules
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<ConfigurationModule>();
            builder.RegisterModule<DomainApiV1Module>();
            builder.RegisterModule<DomainApiV2Module>();
            
            builder.RegisterType<DemographicsService>().AsImplementedInterfaces().InstancePerDependency();
            builder.RegisterType<ResidentialSearchService>().AsImplementedInterfaces().InstancePerDependency();
        }
    }
}