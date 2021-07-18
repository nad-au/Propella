using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using Propella.Application.Commands;
using Propella.Infrastructure.Pipelines;

namespace Propella.Infrastructure.Modules.Internal
{
    public class MediatorModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterMediatR(typeof(ICommand<>).Assembly, 
                typeof(CommandPipelineBehaviour<,>), typeof(QueryPipelineBehaviour<,>));
        }
    }
}