using System.Collections.Generic;

namespace Propella.Domain.Results
{
    public record Response<T> : Response where T : class
    {
        public T Data { get; init; }
    }
    
    public record Response : IHaveMeta
    {
        public string ErrorCode { get; init; }

        public string Message { get; init; }

        public string StackTrace { get; init; }

        public ICollection<Error> Errors { get; init; }

        public Dictionary<string, string> Meta { get; set; }
    }
}