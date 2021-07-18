using MediatR;
using Propella.Application.Results;

namespace Propella.Application.Commands
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse> where TResponse : Response
    {
    }
}