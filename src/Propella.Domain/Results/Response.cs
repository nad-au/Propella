using System.Collections.Generic;

namespace Propella.Domain.Results
{
    public record Response<T> : Response
    {
        public Response() { }

        public Response(T? data)
        {
            Data = data;
        }
        
        public T? Data { get; init; }
    }
    
    public record Response : IHaveMeta
    {
        public string? ErrorCode { get; init; }

        public string? Message { get; init; }

        public string? StackTrace { get; init; }

        public ICollection<Error> Errors { get; init; } = new List<Error>();

        public Dictionary<string, string> Meta { get; set; } = new();
    }
}