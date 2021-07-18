using MediatR;
using Propella.Application.Results;

namespace Propella.Application.Queries
{
    public interface IQuery<out TResponse> : IRequest<TResponse> where TResponse : Response
    {
    }
}