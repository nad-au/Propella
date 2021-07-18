using Propella.Application.Results;

namespace Propella.Application.Exceptions
{
    public class QueryException : ErrorsException
    {
        public QueryException(IHaveErrors errors, string message) : base(errors, message) { }
    }
}