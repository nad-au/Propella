using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using Propella.Application.Commands;
using Propella.Application.Exceptions;
using Propella.Application.Results;
using Propella.Application.Validations;
using Propella.Infrastructure.Logging;

namespace Propella.Infrastructure.Pipelines
{
    public class CommandPipelineBehaviour<TCommand, TResponse> : IPipelineBehavior<TCommand, TResponse>
        where TCommand : ICommand<TResponse> where TResponse : Response, new()
    {
        private readonly ILogger<CommandPipelineBehaviour<TCommand, TResponse>> _logger;
        private readonly ILifetimeScope _lifetimeScope;

        public CommandPipelineBehaviour(ILogger<CommandPipelineBehaviour<TCommand, TResponse>> logger, ILifetimeScope lifetimeScope)
        {
            _logger = logger;
            _lifetimeScope = lifetimeScope;
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
         
            var validator = _lifetimeScope.ResolveOptional<IValidator<TCommand>>();
            if (validator != null)
            {
                var result = await validator.ValidateAsync(command, cancellationToken);
                if (!result.IsValid)
                {
                    var errorResponse = new TResponse
                    {
                        Message = "Validation error",
                        Errors = result.AsErrors()
                    };
                    _logger.LogInformation($"Command '{commandName}' terminated with errors");
                    throw new CommandException(errorResponse, $"Command '{commandName}' terminated with errors");
                }
            }

            var response = await next();
            _logger.LogInformation($"Command '{commandName}' finished");
            return response;
        }
    }
}