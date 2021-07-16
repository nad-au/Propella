using Autofac;
using Microsoft.Extensions.Configuration;
using Propella.Infrastructure.Services.Domain;

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
            builder.RegisterType<DemographicsService>().AsImplementedInterfaces().InstancePerDependency();
            builder.RegisterType<ResidentialSearchService>().AsImplementedInterfaces().InstancePerDependency();
        }
    }
}