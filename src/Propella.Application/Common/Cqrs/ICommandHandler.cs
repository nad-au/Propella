using MediatR;
using Propella.Domain.Results;

namespace Propella.Application.Common.Cqrs
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse> where TResponse : Response
    {
    }
}