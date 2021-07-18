using Autofac;
using Domain.Api.V1.Api;
using Propella.Application.Configuration;
using Propella.Infrastructure.Configuration;
using V1Configuration = Domain.Api.V1.Client.Configuration;

namespace Propella.Infrastructure.Modules.Internal
{
    public class DomainApiV1Module : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context =>
            {
                var settings = context.Resolve<ISettings<DomainApiSettings>>().Value;
                var config = new V1Configuration {BasePath = settings.BaseUrl};
                config.ApiKey.Add("x-api-key", settings.ApiKey);
                return config;
            }).SingleInstance();
            
            builder.RegisterType<ListingsApi>().AsImplementedInterfaces().InstancePerDependency();
        }
    }
}