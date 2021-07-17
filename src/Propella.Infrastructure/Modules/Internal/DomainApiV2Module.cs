using Autofac;
using Domain.Api.V2.Client.Api;
using Propella.Domain.Configuration;
using Propella.Infrastructure.Configuration;
using V2Configuration = Domain.Api.V2.Client.Client.Configuration;

namespace Propella.Infrastructure.Modules.Internal
{
    public class DomainApiV2Module : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context =>
            {
                var settings = context.Resolve<ISettings<DomainApiSettings>>().Value;
                var config = new V2Configuration {BasePath = settings.BaseUrl};
                config.ApiKey.Add("x-api-key", settings.ApiKey);
                return config;
            }).SingleInstance();

            builder.RegisterType<DemographicsApi>().AsImplementedInterfaces().InstancePerDependency();
        }
    }
}