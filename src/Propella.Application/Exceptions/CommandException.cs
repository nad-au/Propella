using Propella.Application.Results;

namespace Propella.Application.Exceptions
{
    public class CommandException : ErrorsException
    {
        public CommandException(IHaveErrors errors, string message) : base(errors, message) { }
    }
}