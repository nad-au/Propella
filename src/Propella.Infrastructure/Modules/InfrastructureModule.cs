using Autofac;
using Microsoft.Extensions.Configuration;
using Propella.Infrastructure.Modules.Internal;
using Propella.Infrastructure.Services.Integrations.Domain;

namespace Propella.Infrastructure.Modules
{
    public class InfrastructureModule : Module
    {
        private readonly IConfiguration _configuration;

        public InfrastructureModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new DomainApiV1Module(_configuration));
            builder.RegisterModule(new DomainApiV2Module(_configuration));
            
            builder.RegisterType<DemographicsService>().AsImplementedInterfaces().InstancePerDependency();
            builder.RegisterType<ResidentialSearchService>().AsImplementedInterfaces().InstancePerDependency();
        }
    }
}