using System;
using System.Collections.Generic;
using Propella.Application.Results;

namespace Propella.Application.Exceptions
{
    public class ErrorsException : Exception, IHaveErrors
    {
        public ErrorsException(IHaveErrors errors, string message) : base(message) {
            Errors = errors.Errors;
        }

        public ICollection<Error> Errors { get; }
    }
}