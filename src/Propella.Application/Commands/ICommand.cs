using MediatR;
using Propella.Application.Results;

namespace Propella.Application.Commands
{
    public interface ICommand<out TResponse> : IRequest<TResponse> where TResponse : Response
    {
    }
}