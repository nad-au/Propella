using Autofac;
using Microsoft.Extensions.Configuration;
using Propella.Application.Commands;

namespace Propella.Infrastructure.Modules
{
    public class ApplicationModule : Module
    {
        private readonly IConfiguration _configuration;

        public ApplicationModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(ICommand<>).Assembly)
                .AsImplementedInterfaces()
                .InstancePerDependency();
        }
    }
}