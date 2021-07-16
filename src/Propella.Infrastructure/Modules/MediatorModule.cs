using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Propella.Application.Commands;
using Propella.Infrastructure.Pipelines;

namespace Propella.Infrastructure.Modules
{
    public class MediatorModule : Module
    {
        private readonly IConfiguration _configuration;

        public MediatorModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterMediatR(typeof(ICommand<>).Assembly, 
                typeof(CommandPipelineBehaviour<,>), typeof(QueryPipelineBehaviour<,>));
        }
    }
}