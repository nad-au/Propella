using System.Collections.Generic;

namespace Propella.Domain.Results
{
    public record Error : IHaveMeta
    {
        public string Code { get; init; }

        public string Field { get; init; }

        public string Message { get; init; }

        public Dictionary<string, string> Meta { get; set; }        
    }
}