using MediatR;
using Propella.Domain.Results;

namespace Propella.Application.Common.Cqrs
{
    public interface ICommand<out TResponse> : IRequest<TResponse> where TResponse : Response
    {
    }
}