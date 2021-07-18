using Autofac;
using Propella.Infrastructure.Modules.Internal;

namespace Propella.Infrastructure.Modules
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<MediatorModule>();
            builder.RegisterModule<ConfigurationModule>();
            builder.RegisterModule<DomainApiV1Module>();
            builder.RegisterModule<DomainApiV2Module>();
            builder.RegisterModule<ServicesModule>();
        }
    }
}