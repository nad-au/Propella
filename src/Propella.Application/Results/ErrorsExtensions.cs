using System.Linq;

namespace Propella.Application.Results
{
    public static class ErrorsExtensions
    {
        public static bool IsCritical(this IHaveErrors errors) => errors.HighestLevel() == ErrorLevel.Critical;
        
        public static ErrorLevel HighestLevel(this IHaveErrors errors)
        {
            if (errors.Errors.Any(e => e.Level == ErrorLevel.Critical))
                return ErrorLevel.Critical;
            
            if (errors.Errors.Any(e => e.Level == ErrorLevel.Error))
                return ErrorLevel.Error;
            
            if (errors.Errors.Any(e => e.Level == ErrorLevel.Warning))
                return ErrorLevel.Warning;

            return ErrorLevel.Information;
        }
    }
}