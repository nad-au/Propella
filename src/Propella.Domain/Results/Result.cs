using System.Collections.Generic;

namespace Propella.Domain.Results
{
    public record Result<T> : Result where T : class
    {
        public T Data { get; init; }
    }
    
    public record Result : IHaveMeta
    {
        public string ErrorCode { get; init; }

        public string Message { get; init; }

        public string StackTrace { get; init; }

        public ICollection<Error> Errors { get; init; }

        public Dictionary<string, string> Meta { get; set; }
    }
}