using System.Collections.Generic;

namespace Propella.Application.Results
{
    public interface IHaveErrors
    {
        public ICollection<Error> Errors { get; }
    }
}