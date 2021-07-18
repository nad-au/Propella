using System.Collections.Generic;

namespace Propella.Application.Results
{
    public interface IHaveMeta
    {
        Dictionary<string, string> Meta { get; set; }
    }
}