using Autofac;
using Domain.Api.V2.Client.Api;
using Domain.Api.V2.Client.Client;
using Microsoft.Extensions.Configuration;

namespace Propella.Infrastructure.Modules.Internal
{
    public class DomainApiV2Module : Module
    {
        private readonly IConfiguration _configuration;

        public DomainApiV2Module(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context =>
            {
                var config = new Configuration {BasePath = _configuration["Integrations:Domain:baseUrl"]};
                config.ApiKey.Add("x-api-key", _configuration["Integrations:Domain:apiKey"]);
                return config;
            }).SingleInstance();

            builder.RegisterType<DemographicsApi>().AsImplementedInterfaces().InstancePerDependency();
        }
    }
}