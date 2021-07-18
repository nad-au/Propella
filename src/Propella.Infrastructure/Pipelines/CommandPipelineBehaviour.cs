using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Propella.Application.Commands;
using Propella.Application.Results;
using Propella.Infrastructure.Logging;

namespace Propella.Infrastructure.Pipelines
{
    public class CommandPipelineBehaviour<TCommand, TResponse> : IPipelineBehavior<TCommand, TResponse>
        where TCommand : ICommand<TResponse> where TResponse : Response
    {
        private readonly ILogger<CommandPipelineBehaviour<TCommand, TResponse>> _logger;

        public CommandPipelineBehaviour(ILogger<CommandPipelineBehaviour<TCommand, TResponse>> logger) {
            _logger = logger;
        }

        /// <inheritdoc />
        public async Task<TResponse> Handle(TCommand command, CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next) {
            var commandName = typeof(TCommand).Name;

            var logState = new Dictionary<string, object> {
                [LogStateKeys.Type] = LogStateValues.Command,
                [LogStateKeys.Name] = commandName
            };
            
            using var scope = _logger.BeginScope(logState);
            _logger.LogInformation($"Command '{commandName}' starting");
            var response = await next();
            _logger.LogInformation($"Command '{commandName}' finished");
            return response;
        }
    }
}