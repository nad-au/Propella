using MediatR;
using Propella.Domain.Results;

namespace Propella.Application.Common.Cqrs
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
        where TQuery : IQuery<TResponse>  where TResponse : Response
    {
    }
}