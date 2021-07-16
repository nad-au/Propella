using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Propella.Application.Queries;
using Propella.Domain.Results;
using Propella.Infrastructure.Logging;

namespace Propella.Infrastructure.Pipelines
{
    public class QueryPipelineBehaviour<TQuery, TResponse> : IPipelineBehavior<TQuery, TResponse>
        where TQuery : IQuery<TResponse> where TResponse : Response
    {
        private readonly ILogger<QueryPipelineBehaviour<TQuery, TResponse>> _logger;

        public QueryPipelineBehaviour(ILogger<QueryPipelineBehaviour<TQuery, TResponse>> logger) {
            _logger = logger;
        }

        /// <inheritdoc />
        public async Task<TResponse> Handle(TQuery command, CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next) {
            var queryName = typeof(TQuery).Name;

            var logState = new Dictionary<string, object> {
                [LogStateKeys.Type] = LogStateValues.Query,
                [LogStateKeys.Name] = queryName
            };
            
            using var scope = _logger.BeginScope(logState);
            _logger.LogInformation($"Query '{queryName}' starting");
            var response = await next();
            _logger.LogInformation($"Query '{queryName}' finished");
            return response;
        }
    }
}