using MediatR;
using Propella.Domain.Results;

namespace Propella.Application.Commands
{
    public interface ICommand<out TResponse> : IRequest<TResponse> where TResponse : Response
    {
    }
}