using System.Collections.Generic;

namespace Propella.Domain.Results
{
    public interface IHaveMeta
    {
        Dictionary<string, string> Meta { get; set; }
    }
}