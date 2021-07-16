using MediatR;
using Propella.Domain.Results;

namespace Propella.Application.Queries
{
    public interface IQuery<out TResponse> : IRequest<TResponse> where TResponse : Response
    {
    }
}