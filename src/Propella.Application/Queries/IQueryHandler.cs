using MediatR;
using Propella.Application.Results;

namespace Propella.Application.Queries
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
        where TQuery : IQuery<TResponse>  where TResponse : Response
    {
    }
}