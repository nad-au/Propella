using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using Propella.Application.Exceptions;
using Propella.Application.Queries;
using Propella.Application.Results;
using Propella.Infrastructure.Logging;

namespace Propella.Infrastructure.Pipelines
{
    public class QueryPipelineBehaviour<TQuery, TResponse> : IPipelineBehavior<TQuery, TResponse>
        where TQuery : IQuery<TResponse> where TResponse : Response, new()
    {
        private readonly ILogger<QueryPipelineBehaviour<TQuery, TResponse>> _logger;
        private readonly ILifetimeScope _lifetimeScope;

        public QueryPipelineBehaviour(ILogger<QueryPipelineBehaviour<TQuery, TResponse>> logger, ILifetimeScope lifetimeScope)
        {
            _logger = logger;
            _lifetimeScope = lifetimeScope;
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
            
            var validator = _lifetimeScope.ResolveOptional<IValidator<TQuery>>();
            if (validator != null)
            {
                var result = await validator.ValidateAsync(command, cancellationToken);
                if (!result.IsValid)
                {
                    
                    var errorResponse = new TResponse
                    {
                        Message = "Its bad",
                        Errors = new List<Error>
                        {
                            new()
                            {
                                Level = ErrorLevel.Critical
                            }
                        }
                    };
                    _logger.LogInformation($"Query '{queryName}' terminated with errors");
                    throw new QueryException(errorResponse, $"Query '{queryName}' terminated with errors");
                }
            }
            
            var response = await next();
            _logger.LogInformation($"Query '{queryName}' finished");
            return response;
        }
    }
}