using System.Collections.Generic;

namespace Propella.Application.Results
{
    public record Error : IHaveMeta
    {
        public string? Code { get; init; }

        public string? Field { get; init; }

        public string? Message { get; init; }
        
        public ErrorLevel Level { get; init; } = ErrorLevel.Error;

        public Dictionary<string, string> Meta { get; set; } = new();
    }
}