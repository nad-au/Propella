using Autofac;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Microsoft.Extensions.Configuration;

namespace Propella.Infrastructure.Modules.Internal
{
    public class DomainApiV1Module : Module
    {
        private readonly IConfiguration _configuration;

        public DomainApiV1Module(IConfiguration configuration)
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
            
            builder.RegisterType<ListingsApi>().AsImplementedInterfaces().InstancePerDependency();
        }
    }
}